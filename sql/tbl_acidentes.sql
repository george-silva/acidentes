CREATE TABLE acidentes
(
  cod_acidente serial NOT NULL,
  tipolog integer NOT NULL,
  nomelog integer NOT NULL,
  numero integer,
  intersecao1 integer,
  intersecao2 integer,
  bairro integer,
  data_acid date,
  hora_acid time without time zone,
  no_boletim integer,
  acid_caracteristica integer,
  acid_causa integer,
  acid_tipo integer,
  acid_caracteristicavia integer,
  acid_condicaovia integer,
  acid_pavimentacao integer,
  acid_tiposocorro integer,
  acid_orgaoresponsalvel integer,
  acid_controletrafego integer,
  acid_clima integer,
  no_veiculos integer,

  CONSTRAINT acidentes_pk PRIMARY KEY (cod_acidente)

)
WITH (OIDS=FALSE);
ALTER TABLE acidentes OWNER TO postgres;



select addgeometrycolumn('public','acidentes','the_geom',29182,'POINT',2);


create function geocodificar() returns trigger as
$$
declare
endereco varchar(100);	
tipo_logradouro varchar(30);
via_principal varchar(50);
intersecao1 varchar(50);
intersecao2 varchar(50);

-- necessario testar cada variavel, para depois mandar o trigger para a funcao correta!!!!
begin
tipo_logradouro:= (select desc_tipolog from tipolog where cod_tipolog = new.tipolog);
via_principal:= (select desc_logradouro from nomelog where cod_logradouro = new.nomelog);
intersecao1:= (select desc_logradouro from nomelog where cod_logradouro = new.intersecao1);
intersecao2:= (select desc_logradouro from nomelog where cod_logradouro = new.intersecao2);

	if new.numero is null then
		if intersecao1 is not null and intersecao2 is not null then
		-- FUNCAO TRECHO
		raise notice 'Trecho';
		update acidentes set the_geom = geocode_trecho(via_principal,intersecao1,intersecao2) where cod_acidente = new.cod_acidente;
		return null;
		else
			if intersecao1 is not null and intersecao2 is null then
				-- FUNCAO CRUZAMENTO
				raise notice 'Cruzamento';
				update acidentes set the_geom = geocode_cruzamento(via_principal,intersecao2) where cod_acidente = new.cod_acidente;
				return null;
			else
			-- nenhuma geocodificaçao executada
			end if;
		end if;
	else
	--execute a funcao geocoder
	--montar endereco
	endereco:= new.numero || ' ' || nome_logradouro || ' ' || tipo_logradouro;
	raise notice 'Interpolada';
	update acidentes set the_geom = (select point_geom from geocode.geocode(endereco,'logradouros'))where cod_acidente = new.cod_acidente;
	return null;
	end if;
end;
$$
language plpgsql;

CREATE TRIGGER trigger_geocode
  AFTER INSERT
  ON acidentes
  FOR EACH ROW
  EXECUTE PROCEDURE geocodificar();