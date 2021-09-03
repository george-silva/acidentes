create or replace function customfunctions.gera_condutor(cd_acidente integer,cd_veiculo integer) returns text as
$$
declare
--declaracao de variaveis
--o codigo do acidente e condutor vem dos contadores na funcao
escolaridade_condutor integer;
profissao_condutor integer;
comportamento_condutor integer;
condicao_condutor integer;
habilitacao_condutor integer;
sexo_condutor integer;

sqlbase text;

begin

sqlbase:= 'insert into condutor(cod_acidente_condutor, cod_veiculo_condutor, escolaridade, profissao, comportamento, condicao_fisica, habilitacao, cond_sexo) values (';

escolaridade_condutor:= (select cod_escolaridade from aux_cond_escolaridade order by random() limit 1);
profissao_condutor:= (select cod_profissao from aux_cond_profissao order by random() limit 1);
comportamento_condutor:= (select cod_comportamento from aux_cond_comportamento order by random() limit 1);
condicao_condutor:= (select cod_condicao from aux_cond_condicao order by random() limit 1);
habilitacao_condutor:= (select cod_habilitacao from aux_cond_habilitacao order by random() limit 1);
sexo_condutor:= (select cod_sexo from aux_cond_sexo order by random() limit 1);

sqlbase:=sqlbase ||
escolaridade_condutor::text || ',' ||
profissao_condutor::text || ',' ||
comportamento_condutor::text || ',' ||
condicao_condutor::text || ',' ||
habilitacao_condutor::text || ',' ||
sexo_condutor::text || ',' || ');';

return sqlbase;

end;
$$
language 'plpgsql'


