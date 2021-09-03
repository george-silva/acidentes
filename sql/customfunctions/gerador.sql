create or replace function customfunctions.gerador(contador_geral integer) returns text as
$$
declare
contador integer;
no_veiculos integer;

sqlacidente text;
sqlveiculo text;
sqlcondutor text;

dummyveiculo text;
dummycondutor text;

sqlgeral text;

begin
contador:=0;
no_veiculos:= myrandom(1,5);

raise notice 'noveiculos: %', no_veiculos;
	
--definde sqlacidente
sqlacidente:=customfunctions.gera_acidente(contador_geral,no_veiculos);
sqlveiculo:='';
sqlcondutor:='';

	while contador <= no_veiculos - 1 loop --entrada loop	
		
		dummyveiculo:= customfunctions.gera_veiculo(contador_geral);--esta variavel passa o valor do codigo do acidente

		sqlveiculo:= sqlveiculo || dummyveiculo;

		dummycondutor:= customfunctions.gera_condutor(contador_geral,contador);--variaveis passam o valor do codigo do acidente e veiculo

		sqlcondutor:=sqlcondutor || dummycondutor;

		contador:=contador+1;

--limpa variaveis

		dummyveiculo:='';
		dummycondutor:='';

	end loop; --saida loop

	sqlgeral:=sqlacidente || sqlveiculo || sqlcondutor;

	return sqlgeral;

end;
$$
language 'plpgsql'

