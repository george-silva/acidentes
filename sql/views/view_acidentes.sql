create or replace view view_acidentes as
select 
cod_acidente as "C�digo do Acidente",
no_veiculos as "N�mero de Ve�culos Envolvidos",
aux_enderecos.tipo_logradouro as "Tipo do Logradouro",
aux_enderecos.desc_logradouro as "Logradouro", 
numero as "N�mero Vi�rio",
aux_bairros.desc_bairro as "Bairro",
data as "Data",
hora as "Hora", 
no_boletim as "N�mero do Boletim de Ocorr�ncia",
aux_acid_caracteristica.desc_caracteristica as "Caracter�stica do Acidente",
aux_acid_causa.desc_causa as "Causa do Acidente",
aux_acid_tipo.desc_tipo as "Tipo do Acidente",
aux_acid_caracteristicavia.desc_caracteristica as "Caracter�stica da Via",
aux_acid_condicaovia.desc_condicao as "Condi��o da Via",
aux_acid_pavimentacao.desc_pavimentacao as "Tipo de Pavimenta��o",
aux_acid_socorro.desc_socorro as "Tipo de Socorro",
aux_acid_orgaoresp.desc_orgao as "�rg�o Respons�vel",
aux_acid_controletrafego.desc_controle as "Controle de Tr�fego",
aux_acid_clima.desc_clima as "Clima",
acid_obs as "Observa��es" from acidentes
join aux_enderecos on (acidentes.nomelog = aux_enderecos.cod_logradouro)
join aux_bairros on (acidentes.bairro = aux_bairros.cod_bairro)
join aux_acid_caracteristica on (acidentes.acid_caracteristica = aux_acid_caracteristica.cod_caracteristica)
join aux_acid_causa on (acidentes.acid_causa = aux_acid_causa.cod_causa)
join aux_acid_tipo on (acidentes.acid_tipo = aux_acid_tipo.cod_tipo)
join aux_acid_caracteristicavia on (acidentes.acid_caracteristicavia = aux_acid_caracteristicavia.cod_caracteristica)
join aux_acid_condicaovia on (acidentes.acid_condicaovia = aux_acid_condicaovia.cod_condicao)
join aux_acid_pavimentacao on (acidentes.acid_pavimentacao = aux_acid_pavimentacao.cod_pavimentacao)
join aux_acid_socorro on (acidentes.acid_tiposocorro = aux_acid_socorro.cod_socorro)
join aux_acid_orgaoresp on (acidentes.acid_orgaoresponsavel = aux_acid_orgaoresp.cod_orgao)
join aux_acid_controletrafego on (acidentes.acid_controletrafego = aux_acid_controletrafego.cod_controle)
join aux_acid_clima on (acidentes.acid_clima = aux_acid_clima.cod_clima)