truncate nomelog;

create or replace function geocode.geocode_trecho(text,text,text) returns geometry as
$$

declare
geo_ponto geometry;
geometria geometry;
begin

--seleciona o trecho de logradouro correto
geometria:= (select the_geom from logradouros where nomelog=$1 and prefixo_direcao=$2 and sufixo_direcao=$3) ;

	if geometria is not null then
	--interpola o logradouro e localiza o ponto no ponto médio
	geo_ponto := st_line_interpolate_point(st_geometryn(geometria,1),.5);
	raise notice 'Ponto Encontrado';
	return geo_ponto;
	
	else
	raise notice 'Ponto Não-Encontrado';
	Return null;
	end if;
end;
$$
language plpgsql;



create or replace function geocode.geocode_cruzamento(varchar, varchar) returns geometry as
$$

declare
geo_ponto geometry;
geometria geometry;

begin

geometria:=(select the_geom from logradouros where nomelog=$1 and sufixo_direcao=$2);

	if geometria is not null then
	geo_ponto := st_line_interpolate_point(st_geometryn(geometria,1),.99);
		raise notice 'Ponto Encontrado';
		return geo_ponto;
	else
	raise notice 'Ponto Não Encontrado';
	return null;

	end if;
end;
$$
language plpgsql;

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

	if new.numero is null or new.numero = 0 then
		if intersecao1 is not null and intersecao2 is not null then
		-- FUNCAO TRECHO
		raise notice 'Trecho';
		update acidentes set the_geom = geocode.geocode_trecho(via_principal,intersecao1,intersecao2) where cod_acidente = new.cod_acidente;
		return null;
		else
			if intersecao1 is not null and intersecao2 is null or intersecao2 = 0 then
				-- FUNCAO CRUZAMENTO
				raise notice 'Cruzamento';
				update acidentes set the_geom = geocode.geocode_cruzamento(via_principal,intersecao2) where cod_acidente = new.cod_acidente;
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