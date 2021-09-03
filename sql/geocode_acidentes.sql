--
-- PostgreSQL database dump
--

SET client_encoding = 'SQL_ASCII';
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- Name: geocode; Type: SCHEMA; Schema: -; Owner: pgsql
--

CREATE SCHEMA geocode;


ALTER SCHEMA geocode OWNER TO pgsql;

SET search_path = geocode, pg_catalog;

--
-- Name: geocode_result; Type: TYPE; Schema: geocode; Owner: pgsql
--

CREATE TYPE geocode_result AS (
	oid oid,
	rank integer,
	streetnum integer,
	streetname character varying,
	"type" character varying,
	predir character varying,
	sufdir character varying,
	geom public.geometry,
	point_geom public.geometry,
	fulladdress character varying,
	city character varying,
	zip integer,
	fulladdwcity character varying
);


ALTER TYPE geocode.geocode_result OWNER TO pgsql;

--
-- Name: normalize_result; Type: TYPE; Schema: geocode; Owner: pgsql
--

CREATE TYPE normalize_result AS (
	number character varying,
	predir character varying,
	streetname character varying,
	"type" character varying,
	postdir character varying,
	zipcode character varying,
	zip5 integer,
	numberint integer,
	city character varying,
	state character varying
);


ALTER TYPE geocode.normalize_result OWNER TO pgsql;

--
-- Name: TYPE normalize_result; Type: COMMENT; Schema: geocode; Owner: pgsql
--

COMMENT ON TYPE normalize_result IS 'holds result of normalize()';


--
-- Name: standardize_result; Type: TYPE; Schema: geocode; Owner: pgsql
--

CREATE TYPE standardize_result AS (
	address character varying,
	dirs character varying,
	types character varying
);


ALTER TYPE geocode.standardize_result OWNER TO pgsql;

--
-- Name: TYPE standardize_result; Type: COMMENT; Schema: geocode; Owner: pgsql
--

COMMENT ON TYPE standardize_result IS 'holds result of standardize()';


--
-- Name: firstnumber(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION firstnumber(character varying) RETURNS character varying
    AS $_$my ($foo)=@_;
$foo=~/([0-9]+(?:\.5)?)/;
return $1;$_$
    LANGUAGE plperl;


ALTER FUNCTION geocode.firstnumber(character varying) OWNER TO pgsql;

--
-- Name: fuzzyaddress(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION fuzzyaddress(character varying) RETURNS character varying
    AS $_$declare
  streetname varchar;
  num varchar;
  space varchar;
  txt varchar;
  mettxt varchar;
  retval varchar;
begin
 streetname=$1;
 num=geocode.firstnumber(streetname);
 if length(num)>0 then
   return num;
 else
   streetname=geocode.stripwhitespace(streetname);
   streetname:=metaphone(streetname,4);
   return streetname;
 end if;

end;$_$
    LANGUAGE plpgsql IMMUTABLE;


ALTER FUNCTION geocode.fuzzyaddress(character varying) OWNER TO pgsql;

--
-- Name: geocode(character varying, character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION geocode(character varying, character varying) RETURNS SETOF geocode_result
    AS $_$declare
geocoder geocode.geocoders%ROWTYPE;
sr geocode.standardize_result;
nr geocode.normalize_result;
gr geocode.geocode_result;
percent float;
address varchar;
gn varchar;
sql varchar;
rds record;
nrname varchar;
nrnum int4;
rank int4;

begin
address:=$1;
gn:=$2;


select into geocoder * from geocode.geocoders where geocoder_name=gn;
select into sr * from geocode.standardize(address,geocoder.directions_table,geocoder.types_table);
select into nr * from geocode.normalize(sr.address,sr.dirs,sr.types);

sql:='select * from geocode.view_geocode_' 
  || geocoder.table_name ||
   ' where searchadd=geocode.fuzzyaddress('''|| nr.streetname || ''') 
   and ' 
  || nr.numberint || 
   ' between minadd and maxadd;';

raise notice 'sql:%',sql;

for rds in execute sql
loop
raise notice 'nr.number: % right from:% to:%',nr.number, rds.right_from_add, rds.right_to_add;
raise notice 'nr.number: % left from:% to:%',nr.number, rds.left_from_add, rds.left_to_add;
if ((nr.numberint between geocode.min2(rds.left_from_add,rds.left_to_add) and geocode.max2(rds.left_from_add,rds.left_to_add)) or
    (nr.numberint between geocode.min2(rds.right_from_add,rds.right_to_add) and geocode.max2(rds.right_from_add,rds.right_to_add))) then
raise notice 'good address range';
rank:=0;
  if (rds.prefix_direction=nr.predir and rds.suffix_direction=nr.postdir) then rank=rank+4;
    elseif (rds.prefix_direction=nr.predir or rds.suffix_direction=nr.postdir) then rank=rank+3; 
    elseif (rds.suffix_direction=nr.predir or rds.prefix_direction=nr.postdir) then rank=rank+2; 
  end if;
raise notice 'Score after pre/suffix: %',rank;
  if (geocode.standardized_address(rds.streetname,'geocode.dirs','geocode.types')=nr.streetname) then rank=rank+5; end if;
  if (rds.zip5_right=nr.zip5 or rds.zip5_left=nr.zip5) then rank=rank+2; end if;
  if (rds.street_type=nr.type) then rank=rank+5; end if;
raise notice 'Score after zip/type: %',rank;
  if ((geocode.iseven(geocode.max2(rds.left_from_add,rds.left_to_add))=geocode.iseven(nr.numberint) 
      and nr.numberint between geocode.min2(rds.left_from_add,rds.left_to_add) and geocode.max2(rds.left_from_add,rds.left_to_add)) or
      not (nr.numberint between geocode.min2(rds.right_from_add,rds.right_to_add) and geocode.max2(rds.right_from_add,rds.right_to_add))) then
    gr.city=rds.city_left;
    gr.zip=rds.zip5_left;
    if rds.zip5_left=nr.zip5 then rank=rank+2; end if;
raise notice 'Score after left: %',rank;
 
    percent:=(nr.number::float - geocode.min2(rds.left_from_add,rds.left_to_add)::float)/
       (geocode.max2(rds.left_from_add,rds.left_to_add)::float - geocode.min2(rds.left_from_add,rds.left_to_add)::float +.0001);
raise notice 'nr.number: % % %',nr.number, rds.left_from_add, rds.left_to_add;
raise notice 'percent: %',percent;
    gr.point_geom=line_interpolate_point(geometryn(rds.geom,1),percent);
    gr.fulladdress:=geocode.unnull(nr.numberint::varchar) || ' ' || geocode.unnull(rds.prefix_direction::varchar) || ' ' || 
       geocode.unnull(rds.streetname::varchar) || ' ' || geocode.unnull(rds.street_type::varchar) || ' ' || geocode.unnull(rds.suffix_direction::varchar) ||
       ' ' || geocode.unnull(rds.zip5_left::varchar);
raise notice 'fulladdress: %',gr.fulladdress;
    gr.fulladdwcity:=geocode.unnull(nr.numberint::varchar) || ' ' || geocode.unnull(rds.prefix_direction) || ' ' || 
       geocode.unnull(rds.streetname) || ' ' || geocode.unnull(rds.street_type) || ' ' || geocode.unnull(rds.suffix_direction) ||
       ' ' || geocode.unnull(rds.city_left) || ' ' || geocode.unnull(rds.zip5_left::varchar);
    if not (nr.numberint between geocode.min2(rds.left_from_add,rds.left_to_add) and geocode.max2(rds.left_from_add,rds.left_to_add)) then rank=rank-2; end if;
  else
    gr.city=rds.city_right;
    gr.zip=rds.zip5_right;
    if rds.zip5_left=nr.zip5 then rank=rank+2; end if;
raise notice 'Score after right: %',rank;
    percent:=(nr.number::float - geocode.min2(rds.right_from_add,rds.right_to_add)::float)/
       (geocode.max2(rds.right_from_add,rds.right_to_add)::float - geocode.min2(rds.right_from_add,rds.right_to_add)::float +.0001);
raise notice 'nr.number: % % %',nr.number, rds.right_from_add, rds.right_to_add;
raise notice 'percent: %',percent;
   gr.point_geom=line_interpolate_point(geometryn(rds.geom,1),percent);
    gr.fulladdress:=geocode.unnull(nr.numberint::varchar) || ' ' || geocode.unnull(rds.prefix_direction::varchar) || ' ' || geocode.unnull(rds.streetname::varchar) || ' ' || geocode.unnull(rds.street_type::varchar) || ' ' || geocode.unnull(rds.suffix_direction::varchar) || ' ' || geocode.unnull(rds.zip5_right::varchar);
raise notice 'fulladdress: %',gr.fulladdress;
    gr.fulladdwcity:=geocode.unnull(nr.numberint::varchar) || ' ' || geocode.unnull(rds.prefix_direction) || ' ' || geocode.unnull(rds.streetname) || ' ' || geocode.unnull(rds.street_type) || ' ' || geocode.unnull(rds.suffix_direction) || ' ' || geocode.unnull(rds.city_right) || ' ' || geocode.unnull(rds.zip5_right::varchar);
    if not (nr.numberint between geocode.min2(rds.right_from_add,rds.right_to_add) and geocode.max2(rds.right_from_add,rds.right_to_add)) then rank=rank-2; end if; 
end if;   
    
  gr.rank=rank;
  gr.streetname=rds.streetname;
  gr.geom=rds.geom;
  gr.predir:=rds.prefix_direction;
  gr.sufdir:=rds.suffix_direction;
  gr.streetnum:=nr.numberint;
  gr.fulladdress:=geocode.strip_double_spaces(gr.fulladdress); 
  gr.fulladdwcity:=geocode.strip_double_spaces(gr.fulladdwcity);


  return next gr;
end if;
end loop;
return;

end;

    
$_$
    LANGUAGE plpgsql;


ALTER FUNCTION geocode.geocode(character varying, character varying) OWNER TO pgsql;

--
-- Name: iseven(bigint); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION iseven(bigint) RETURNS boolean
    AS $_$my ($num)=@_;
if ($num-2*int($num/2)==0){
return true;}
else {return false};$_$
    LANGUAGE plperl;


ALTER FUNCTION geocode.iseven(bigint) OWNER TO pgsql;

--
-- Name: max2(bigint, bigint); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION max2(bigint, bigint) RETURNS bigint
    AS $_X$if ($_[0] > $_[1]) { return $_[0]; }
    return $_[1];$_X$
    LANGUAGE plperl;


ALTER FUNCTION geocode.max2(bigint, bigint) OWNER TO pgsql;

--
-- Name: max4(bigint, bigint, bigint, bigint); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION max4(bigint, bigint, bigint, bigint) RETURNS bigint
    AS $_$DECLARE
        foo integer;

BEGIN
        foo := $1;
        IF $2 > foo THEN
            foo := $2;
        END IF;
        IF $3 > foo THEN
            foo := $3;
        END IF;
        IF $4 > foo THEN
            foo := $4;
        END IF;

        RETURN foo;
END;$_$
    LANGUAGE plpgsql IMMUTABLE;


ALTER FUNCTION geocode.max4(bigint, bigint, bigint, bigint) OWNER TO pgsql;

--
-- Name: min2(bigint, bigint); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION min2(bigint, bigint) RETURNS bigint
    AS $_$DECLARE
        foo integer;

BEGIN
        foo := $1;
        IF ($2 < foo or foo=0) and $2 != 0 THEN
            foo := $2;
        end if;
        RETURN foo;
END;$_$
    LANGUAGE plpgsql;


ALTER FUNCTION geocode.min2(bigint, bigint) OWNER TO pgsql;

--
-- Name: min4(bigint, bigint, bigint, bigint); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION min4(bigint, bigint, bigint, bigint) RETURNS bigint
    AS $_$DECLARE
        foo integer;

BEGIN
        foo := $1;
        IF ($2 < foo or foo=0) and $2 != 0 THEN
            foo := $2;
        END IF;
        IF ($3 < foo or foo=0) and $3 != 0 THEN
            foo := $3;
        END IF;
        IF ($4 < foo or foo=0)and $4 != 0 THEN
            foo := $4;
        END IF;

        RETURN foo;
END;$_$
    LANGUAGE plpgsql IMMUTABLE;


ALTER FUNCTION geocode.min4(bigint, bigint, bigint, bigint) OWNER TO pgsql;

--
-- Name: normalize(character varying, character varying, character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION normalize(character varying, character varying, character varying) RETURNS normalize_result
    AS $_$my ($address,$dirs,$types)=@_;
my $type='';
my $zip5='';
my $zipcode='';
my $number='';
my $numberint=null;
my $predir='';
my $postdir='';
my $name='';


$address=uc($address);

# Get house number from beginning
$address=~/^\s*([0-9]+(?:\.5)?)\s+/;
$number=$1;
$number=~/^\s*(\d+)/;
$numberint=int($1);
$address=~s/^\s*([0-9]+(?:\.5)?)\s+//;

#Get rid of apartment info then ditch all periods
$address=~s/\./ /g;
$address=~s/(AP(ARTMEN)?T|NUM(BER)?|SUITE|#)[ ]?#?[ ]?[A-Z0-9\-]+//i;

#get zip from end
#$address=~s/\s+(\d\d\d\d\d)(\-/d/d/d/d)?\s*$//;
$address=~/\s+(\d\d\d\d\d)\s*$/;
$zip5=int($1);
$address=~s/\s+(\d\d\d\d\d)\s*$//;
#my $zipcode=$1.$2;

#get all data up to comma
my @parts=split(/,/,$address);
$address=shift(@parts);

#get prefix direction from beginning
$address=~/^\s*($dirs)\s+/;
$predir=$1;
$address=~s/^\s*($dirs)\s+//;

#get post direction from end
$address=~/\b($dirs)\s*$/;
$postdir=$1;
$address=~s/\b($dirs)\s*$//;

#get street type from end
$address=~/\b($types)\s*$/;
$type=$1;
$address=~s/\b($types)\s*$//;

#remove leading and trailing spaces
$address=~s/^\s*//;
$address=~s/\s*$//;

#make every attempt possible to ensure streetname is filled
if (length($address)>0) {
  $name=$address;
} elsif (length($predir)>0){
  $name=$predir;
  $predir='';
} elsif (length($type)>0){
  $name=$type;
  $type='';
} elsif (length($postdir)>0){
  $name=$postdir;
  $postdir='';
}

return {number=>$number,predir=>$predir,streetname=>$name,type=>$type,postdir=>$postdir,zipcode=>$zipcode,zip5=>$zip5,numberint=>$numberint};$_$
    LANGUAGE plperl;


ALTER FUNCTION geocode.normalize(character varying, character varying, character varying) OWNER TO pgsql;

--
-- Name: prepgeocoder(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION prepgeocoder(character varying) RETURNS boolean
    AS $_$select geocode.prepgeocoder_alter($1);
select geocode.prepgeocoder_update($1);
select geocode.prepgeocoder_view($1);
select geocode.prepgeocoder_index($1); 
select true;$_$
    LANGUAGE sql;


ALTER FUNCTION geocode.prepgeocoder(character varying) OWNER TO pgsql;

--
-- Name: prepgeocoder_alter(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION prepgeocoder_alter(character varying) RETURNS character varying
    AS $_$declare
geocoder geocode.geocoders%ROWTYPE;
sql varchar;

begin
select into geocoder * from geocode.geocoders where geocoder_name=$1;
sql:='alter table ' || geocoder.table_name || ' add column geocode_minadd int4;';
execute sql;
sql:='alter table ' || geocoder.table_name || ' add column geocode_maxadd int4;';
execute sql;
sql:='alter table ' || geocoder.table_name || ' add column geocode_searchadd varchar;';
execute sql;
sql:='alter table ' || geocoder.table_name || ' add column geocode_standardadd varchar;';
execute sql;
return true;
end; $_$
    LANGUAGE plpgsql;


ALTER FUNCTION geocode.prepgeocoder_alter(character varying) OWNER TO pgsql;

--
-- Name: prepgeocoder_index(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION prepgeocoder_index(character varying) RETURNS character varying
    AS $_$declare
geocoder geocode.geocoders%ROWTYPE;
sql varchar;

begin
select into geocoder * from geocode.geocoders where geocoder_name=$1;
sql:='create index geocode_' || geocoder.geocoder_name || '_idx on '
|| geocoder.table_name || ' using btree(geocode_searchadd,geocode_minadd,geocode_maxadd);';
execute sql;
return true;
end;$_$
    LANGUAGE plpgsql;


ALTER FUNCTION geocode.prepgeocoder_index(character varying) OWNER TO pgsql;

--
-- Name: prepgeocoder_update(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION prepgeocoder_update(character varying) RETURNS boolean
    AS $_$declare
geocoder geocode.geocoders%ROWTYPE;
sql varchar;

begin
select into geocoder * from geocode.geocoders where geocoder_name=$1;
sql:='update ' 
  || geocoder.table_name || 
  ' set geocode_minadd = geocode.min4('
  || geocoder.left_from_add || ','
  || geocoder.right_from_add || ','
  || geocoder.left_to_add || ','
  || geocoder.right_to_add || 
  '), geocode_maxadd = geocode.max4('  
  || geocoder.left_from_add || ','
  || geocoder.right_from_add || ','
  || geocoder.left_to_add || ','
  || geocoder.right_to_add || 
  '), geocode_searchadd = geocode.fuzzyaddress(geocode.standardized_address(' 
  || geocoder.streetname ||
  ', ''' || geocoder.directions_table ||
  ''', ''' || geocoder.types_table ||
  ''')), geocode_standardadd = geocode.standardized_address('
  || geocoder.streetname ||
  ', ''' || geocoder.directions_table ||
  ''', ''' || geocoder.types_table ||
  ''');';
execute sql;



return true;
end;$_$
    LANGUAGE plpgsql;


ALTER FUNCTION geocode.prepgeocoder_update(character varying) OWNER TO pgsql;

--
-- Name: prepgeocoder_view(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION prepgeocoder_view(character varying) RETURNS boolean
    AS $_$declare
geocoder geocode.geocoders%ROWTYPE;
sql varchar;

begin
select into geocoder * from geocode.geocoders where geocoder_name=$1;
sql:='create or replace view geocode.view_geocode_' || geocoder.geocoder_name || 
' as select ' 
|| geocoder.left_from_add || ' as left_from_add, '
|| geocoder.right_from_add || ' as right_from_add, '
|| geocoder.left_to_add || ' as left_to_add, '
|| geocoder.right_to_add || ' as right_to_add, '
|| geocoder.zip5_left || ' as zip5_left, '
|| geocoder.zip5_right || ' as zip5_right, '
|| geocoder.city_left || ' as city_left, '
|| geocoder.city_right || ' as city_right, '
|| geocoder.prefix_direction || ' as prefix_direction, '
|| geocoder.suffix_direction || ' as suffix_direction, '
|| geocoder.street_type || ' as street_type, '
|| geocoder.streetname || ' as streetname, '
|| geocoder.geom || 
' as geom, geocode_minadd as minadd, geocode_maxadd as maxadd, geocode_searchadd as searchadd, geocode_standardadd as standardadd from '
|| geocoder.table_name || ';';
execute sql;

return true;
end;$_$
    LANGUAGE plpgsql;


ALTER FUNCTION geocode.prepgeocoder_view(character varying) OWNER TO pgsql;

--
-- Name: regex_word(text); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION regex_word(text) RETURNS text
    AS $_$declare
result text;
begin
result:='[[:<:]](' || $1 || ')[[:>:]]';
return result;
end;$_$
    LANGUAGE plpgsql;


ALTER FUNCTION geocode.regex_word(text) OWNER TO pgsql;

--
-- Name: standardize(character varying, character varying, character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION standardize(character varying, character varying, character varying) RETURNS standardize_result
    AS $_$my($a,$d,$t)=@_;
$a=uc($a);
$dirregex='';
$typeregex='';
$sql="select distinct on (corrected) corrected,regex from ".$d." where '".$a."' ~* geocode.regex_word(regex);";
$rv=spi_exec_query($sql);
for ( my $i=0; $i < @{$rv->{rows}} ; $i++ ) {
	$regex=$rv->{rows}[$i]->{'regex'};
	$corrected=$rv->{rows}[$i]->{'corrected'};
	$a=~s/$regex/$corrected/gi;
        $dirregex.=''.$corrected.'|';
}
chop($dirregex);
$sql="select distinct on (corrected) corrected,regex from ".$t." where '".$a."' ~* geocode.regex_word(regex);";
$rv=spi_exec_query($sql);
for ( my $i=0; $i < @{$rv->{rows}} ; $i++ ) {
	$regex=$rv->{rows}[$i]->{'regex'};
	$corrected=$rv->{rows}[$i]->{'corrected'};
	$a=~s/$regex/$corrected/gi;
        $typeregex.=''.$corrected.'|';
}
chop($typeregex);
return {address=>$a , dirs=>$dirregex, types=>$typeregex };
$_$
    LANGUAGE plperl IMMUTABLE;


ALTER FUNCTION geocode.standardize(character varying, character varying, character varying) OWNER TO pgsql;

--
-- Name: standardized_address(character varying, character varying, character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION standardized_address(character varying, character varying, character varying) RETURNS character varying
    AS $_$select address from geocode.standardize($1::varchar,$2::varchar,$3::varchar)$_$
    LANGUAGE sql IMMUTABLE;


ALTER FUNCTION geocode.standardized_address(character varying, character varying, character varying) OWNER TO pgsql;

--
-- Name: strip_double_spaces(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION strip_double_spaces(character varying) RETURNS character varying
    AS $_$my ($foo)=@_;
$foo=~s/\s+/ /g;
return $foo; $_$
    LANGUAGE plperl;


ALTER FUNCTION geocode.strip_double_spaces(character varying) OWNER TO pgsql;

--
-- Name: stripwhitespace(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION stripwhitespace(character varying) RETURNS character varying
    AS $_$my ($foo)=@_;
$foo=~s/\s//g;
return $foo; $_$
    LANGUAGE plperl;


ALTER FUNCTION geocode.stripwhitespace(character varying) OWNER TO pgsql;

--
-- Name: unnull(character varying); Type: FUNCTION; Schema: geocode; Owner: pgsql
--

CREATE FUNCTION unnull(character varying) RETURNS character varying
    AS $_$begin
if ($1 is null) then return ''; end if;
return $1;
end;$_$
    LANGUAGE plpgsql;


ALTER FUNCTION geocode.unnull(character varying) OWNER TO pgsql;

SET default_tablespace = '';

SET default_with_oids = true;

--
-- Name: dirs; Type: TABLE; Schema: geocode; Owner: pgsql; Tablespace: 
--

CREATE TABLE dirs (
    corrected character varying,
    regex character varying
);


ALTER TABLE geocode.dirs OWNER TO pgsql;

--
-- Name: geocoders; Type: TABLE; Schema: geocode; Owner: pgsql; Tablespace: 
--

CREATE TABLE geocoders (
    geocoder_name character varying,
    table_name character varying,
    left_from_add character varying,
    right_from_add character varying,
    left_to_add character varying,
    right_to_add character varying,
    zip5_left character varying,
    zip5_right character varying,
    city_left character varying,
    city_right character varying,
    prefix_direction character varying,
    suffix_direction character varying,
    street_type character varying,
    streetname character varying,
    geom character varying,
    directions_table character varying,
    types_table character varying
);


ALTER TABLE geocode.geocoders OWNER TO pgsql;

--
-- Name: types; Type: TABLE; Schema: geocode; Owner: pgsql; Tablespace: 
--

CREATE TABLE types (
    corrected character varying,
    regex character varying
);


ALTER TABLE geocode.types OWNER TO pgsql;

--
-- Data for Name: dirs; Type: TABLE DATA; Schema: geocode; Owner: pgsql
--

INSERT INTO dirs VALUES ('N', 'NO?(RTH)?');
INSERT INTO dirs VALUES ('S', 'SO?(UTH)?');
INSERT INTO dirs VALUES ('W', 'W(EST)?');
INSERT INTO dirs VALUES ('E', 'E(AST)?');
INSERT INTO dirs VALUES ('NW', 'N(ORTH)?W(EST)?');
INSERT INTO dirs VALUES ('NE', 'N(ORTH)?E(AST)?');
INSERT INTO dirs VALUES ('SE', 'S(OUTH)?E(AST)?');
INSERT INTO dirs VALUES ('SW', 'S(OUTH)?E(AST)?');
INSERT INTO dirs VALUES ('N', 'NO?(RTH)?');
INSERT INTO dirs VALUES ('S', 'SO?(UTH)?');
INSERT INTO dirs VALUES ('W', 'W(EST)?');
INSERT INTO dirs VALUES ('E', 'E(AST)?');
INSERT INTO dirs VALUES ('NW', 'N(ORTH)?W(EST)?');
INSERT INTO dirs VALUES ('NE', 'N(ORTH)?E(AST)?');
INSERT INTO dirs VALUES ('SE', 'S(OUTH)?E(AST)?');
INSERT INTO dirs VALUES ('SW', 'S(OUTH)?E(AST)?');

--
-- Data for Name: types; Type: TABLE DATA; Schema: geocode; Owner: pgsql
--

INSERT INTO types VALUES ('ALC', 'ALC');
INSERT INTO types VALUES ('BAY', 'BAY');
INSERT INTO types VALUES ('BLF', 'BLF');
INSERT INTO types VALUES ('BND', 'BND');
INSERT INTO types VALUES ('CONN', 'CONN');
INSERT INTO types VALUES ('CRES', 'CRES');
INSERT INTO types VALUES ('CTR', 'CTR');
INSERT INTO types VALUES ('DNS', 'DNS');
INSERT INTO types VALUES ('DRAW', 'DRAW');
INSERT INTO types VALUES ('ECHO', 'ECHO');
INSERT INTO types VALUES ('EXT', 'EXT');
INSERT INTO types VALUES ('FRST', 'FRST');
INSERT INTO types VALUES ('GATE', 'GATE');
INSERT INTO types VALUES ('GRN', 'GRN');
INSERT INTO types VALUES ('KNLS', 'KNLS');
INSERT INTO types VALUES ('LNDG', 'LNDG');
INSERT INTO types VALUES ('LOOP', 'LOOP');
INSERT INTO types VALUES ('MALL', 'MALL');
INSERT INTO types VALUES ('MEWS', 'MEWS');
INSERT INTO types VALUES ('MNR', 'MNR');
INSERT INTO types VALUES ('OAK', 'OAK');
INSERT INTO types VALUES ('OAKS', 'OAKS');
INSERT INTO types VALUES ('PARK', 'PARK');
INSERT INTO types VALUES ('PASS', 'PASS');
INSERT INTO types VALUES ('PATH', 'PATH');
INSERT INTO types VALUES ('RAMP', 'RAMP');
INSERT INTO types VALUES ('RISE', 'RISE');
INSERT INTO types VALUES ('ROW', 'ROW');
INSERT INTO types VALUES ('RUN', 'RUN');
INSERT INTO types VALUES ('SHRS', 'SHRS');
INSERT INTO types VALUES ('SPUR', 'SPUR');
INSERT INTO types VALUES ('STA', 'STA');
INSERT INTO types VALUES ('TRCE', 'TRCE');
INSERT INTO types VALUES ('TURN', 'TURN');
INSERT INTO types VALUES ('VIS', 'VIS');
INSERT INTO types VALUES ('VLG', 'VLG');
INSERT INTO types VALUES ('VW', 'VW');
INSERT INTO types VALUES ('WALK', 'WALK');
INSERT INTO types VALUES ('WAY', 'WAY');
INSERT INTO types VALUES ('XING', 'XING');
INSERT INTO types VALUES ('XRD', 'XRD');
INSERT INTO types VALUES ('ALY', 'AL(LE)?Y');
INSERT INTO types VALUES ('AVE', 'AVE?(NUE)?');
INSERT INTO types VALUES ('BLVD', 'B(OU)?LE?V(AR)?D');
INSERT INTO types VALUES ('BCH', 'B(EA)?CH');
INSERT INTO types VALUES ('CIR', 'CIR(CLE)?');
INSERT INTO types VALUES ('CLOS', 'CLOSE?');
INSERT INTO types VALUES ('CMNS', 'CO?MM?O?NS');
INSERT INTO types VALUES ('CRK', 'CR(E[E|A])?K');
INSERT INTO types VALUES ('CRST', 'CRE?ST');
INSERT INTO types VALUES ('CRV', 'CU?RVE?');
INSERT INTO types VALUES ('CT', 'C(OUR)?T');
INSERT INTO types VALUES ('CV', 'CO?VE?');
INSERT INTO types VALUES ('DR', 'DR(IVE)?');
INSERT INTO types VALUES ('EXCH', 'EXCH(ANGE)?');
INSERT INTO types VALUES ('FWY', 'F(REE)?WA?Y');
INSERT INTO types VALUES ('GDN', 'G(AR)?DE?N');
INSERT INTO types VALUES ('GDNS', 'G(AR)?DE?NS');
INSERT INTO types VALUES ('GLN', 'GLE?N?N');
INSERT INTO types VALUES ('GRV', 'GRO?VE?');
INSERT INTO types VALUES ('HL', 'H(IL)?L');
INSERT INTO types VALUES ('HOLW', 'HOL(LO)?W');
INSERT INTO types VALUES ('HTS', 'H(EIGH)?TS');
INSERT INTO types VALUES ('HWY', 'H(IGH)?WA?Y');
INSERT INTO types VALUES ('IS', 'IS(LAND)?');
INSERT INTO types VALUES ('JCT', 'J(UN)?CT(ION)?');
INSERT INTO types VALUES ('KNL', 'KNO?LL?');
INSERT INTO types VALUES ('LDG', 'L(AN)?D(IN)?G');
INSERT INTO types VALUES ('TER', 'TER(RACE)?');
INSERT INTO types VALUES ('PKWY', 'P(AR)?KWA?Y');
INSERT INTO types VALUES ('PL', 'PL(ACE)?');
INSERT INTO types VALUES ('PLZ', 'PLA?ZA?');
INSERT INTO types VALUES ('PNES', 'PI?NES');
INSERT INTO types VALUES ('PT', 'P(OIN)?T');
INSERT INTO types VALUES ('RD', 'R(OA)?D');
INSERT INTO types VALUES ('RDG', 'RI?DGE?');
INSERT INTO types VALUES ('RTE', 'R(OU)?TE?');
INSERT INTO types VALUES ('SQ', 'SQ(UARE)?');
INSERT INTO types VALUES ('ST', 'STR?(EET)?');
INSERT INTO types VALUES ('TRL', 'TRL?');
INSERT INTO types VALUES ('LN', 'LA?N?E?');


--
-- Name: dirs_idx; Type: INDEX; Schema: geocode; Owner: pgsql; Tablespace: 
--

CREATE INDEX dirs_idx ON dirs USING btree (corrected, regex);


ALTER INDEX geocode.dirs_idx OWNER TO pgsql;

--
-- Name: types_idx; Type: INDEX; Schema: geocode; Owner: pgsql; Tablespace: 
--

CREATE INDEX types_idx ON types USING btree (corrected, regex);


ALTER INDEX geocode.types_idx OWNER TO pgsql;

--
-- PostgreSQL database dump complete
--

