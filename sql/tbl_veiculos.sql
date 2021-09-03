CREATE TABLE veiculos
(
  cod_veiculo serial NOT NULL,
  cod_acidente integer NOT NULL,
  tipo_veiculo integer NOT NULL,
  placa_veiculo character varying(10),
  apreendido integer,
  no_ocupantes integer,
  sentido_veiculo integer,
  veic_equipseg integer,
  CONSTRAINT veiculos_pk PRIMARY KEY (cod_veiculo),
  CONSTRAINT checa_noocupantes CHECK (no_ocupantes >= 1),
  CONSTRAINT checa_sentidoveiculo CHECK (sentido_veiculo > 0),
  CONSTRAINT checa_tipoveiculo CHECK (tipo_veiculo > 0)
)
WITH (OIDS=FALSE);
ALTER TABLE veiculos OWNER TO postgres;