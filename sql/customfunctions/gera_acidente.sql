create or replace function customfunctions.gera_acidente(cd_acidente integer,n_veiculos integer) returns text as
$$
declare
--declaracao das variaveis
--o codigo do acidente numero de veiculos envolvidos sao parametros da funcao.
--a razao para isto é poder passar o contador do loop para o codigo do acidente.
tp_logradouro integer;
desc_tp_logradouro text;
nome_logradouro integer;
no_viario integer;
caracteristica_acidente integer;
causa_acidente integer;
tipo_acidente integer;
caracteristica_via integer;
condicao_via integer;
pavimentacao_via integer;
tipo_socorro integer;
orgao_responsavel integer;
controle_trafego integer;
clima integer;
veiculos_envolvidos integer;

sqlbase text;

begin

sqlbase:= 'insert into acidentes(cod_acidente,tipolog,nomelog,numero,acid_caracteristica,acid_causa,acid_tipo,acid_caracteristicavia,acid_condicaovia,acid_pavimentacao,acid_tiposocorro,acid_orgaoresponsavel,acid_controletrafego,acid_clima,no_veiculos) values (';

--assinalando variaveis
--procurando um endereco compativel ao tipo do logradouro escolhido aleatoriamente
nome_logradouro:= (select cod_logradouro from aux_enderecos order by random() limit 1);
desc_tp_logradouro:= (select tipo_logradouro from aux_enderecos where cod_logradouro = nome_logradouro);
tp_logradouro:= (select cod_tipolog from aux_tipo_logradouro where desc_tipolog = desc_tp_logradouro);
--fim procura pelo nome_logradouro;

no_viario:=myrandom(1,1000);

caracteristica_acidente:= (select cod_caracteristica from aux_acid_caracteristica order by random() limit 1);
causa_acidente:= (select cod_causa from aux_acid_causa order by random() limit 1);
tipo_acidente:= (select cod_tipo from aux_acid_tipo order by random() limit 1);
caracteristica_via:= (select cod_caracteristica from aux_acid_caracteristicavia order by random() limit 1);
condicao_via:= (select cod_condicao from aux_acid_condicaovia order by random() limit 1);
pavimentacao_via:= (select cod_pavimentacao from aux_acid_pavimentacao order by random() limit 1);
tipo_socorro:= (select cod_socorro from aux_acid_socorro order by random() limit 1);
orgao_responsavel:= (select cod_orgao from aux_acid_orgaoresp order by random() limit 1);
controle_trafego:= (select cod_controle from aux_acid_controletrafego order by random() limit 1);
clima:= (select cod_clima from aux_acid_clima order by random() limit 1);

veiculos_envolvidos:=n_veiculos;

sqlbase:= sqlbase ||
cd_acidente::text || ',' || 
tp_logradouro::text || ',' ||
nome_logradouro::text || ',' ||
no_viario::text || ',' ||
caracteristica_acidente::text || ',' ||
causa_acidente::text || ',' ||
tipo_acidente::text || ',' ||
caracteristica_via::text || ',' ||
condicao_via::text || ',' ||
pavimentacao_via::text || ',' ||
tipo_socorro::text || ',' ||
orgao_responsavel::text || ',' ||
controle_trafego::text || ',' ||
clima::text || ',' ||
veiculos_envolvidos::text || ');';

return sqlbase::text;

end;
$$
language 'plpgsql'

