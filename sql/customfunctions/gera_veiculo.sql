create or replace function customfunctions.gera_veiculo(cd_acidente integer) returns text as
$$
declare
 
tp_veiculo integer;
veiculo_apreendido integer;
no_ocupantes integer;
equipseguranca integer;

sqlbase text;

begin

sqlbase:='insert into veiculos(cod_acidente_veiculo,tipo_veiculo,apreendido,no_ocupantes,sentido_veiculo,veic_equipseg) values (';

tp_veiculo:= (select cod_tipo from aux_veic_tipo order by random() limit 1);
veiculo_apreendido := (select cod_apreendido from aux_veic_apreendido order by random() limit 1);
no_ocupantes := myrandom(1,5);
equipseguranca:= (select cod_equip from aux_veic_equipamentoseg order by random() limit 1);

sqlbase:= sqlbase || 
cd_acidente::text || ','||
tp_veiculo::text || ','||
veiculo_apreendido::text || ','||
no_ocupantes::text || ','||
equipseguranca::text || ');';

return sqlbase;

end;
$$
language 'plpgsql'
