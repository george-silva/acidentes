CREATE TABLE severidade
(
  cod_severidade serial NOT NULL, -- chave primaria, unica
  cod_acidente int4 NOT NULL, --codigo do acidente que participou
  cod_veiculo int4 NOT NULL, --codigo do veiculo que participou do acidente
  sem_danos int4, --numero de pessoas/automoveis sem dano
  danos_materiais int4,--numero de danos materiais (em veiculos)
  feridos_leves int4,--numero de feridos leves
  feridos_graves int4,--numero de feridos graves
  mortos int4,--numero de fatalidades
  nao_apurado int4,--numero de severidades nao apuradas
  constraint severidade_pk primary key(cod_severidade),
  constraint severidade_unique unique(cod_severidade),
  constraint checa_semdanos check(sem_danos >=0),
  constraint checa_danosmateriais check(danos_materiais >=0),
  constraint checa_feridosleves check(feridos_leves >=0),
  constraint checa_feridosgraves check(feridos_graves >=0),
  constraint checa_mortos check(mortos >=0),
  constraint checa_naoapurado check(nao_apurado >=0)
)
WITH (OIDS=FALSE);
ALTER TABLE severidade OWNER TO postgres;
