CREATE TABLE tipolog (
    cod_tipolog smallint NOT NULL,
    desc_tipolog character varying(30) NOT NULL,
    constraint tipolog_pk primary key(cod_tipolog)
);

ALTER TABLE tipolog OWNER TO postgres;
--insert
insert into tipolog values (1,'Avenida');
insert into tipolog values (2,'Rua');
insert into tipolog values (3,'Praça');
insert into tipolog values (4,'Alameda');
insert into tipolog values (5,'Travessa');
insert into tipolog values (6,'Rodovia');
insert into tipolog values (7,'Outro');
--------------------------------------------
create table acid_orgaoresp(
cod_orgao int4 not null,
desc_orgao varchar(15),
constraint acidorgaoresp_pk primary key(cod_orgao)
);
alter table acid_orgaoresp owner to postgres;
--insert
insert into acid_orgaoresp(cod_orgao,desc_orgao) values(1,'NOT');
insert into acid_orgaoresp(cod_orgao,desc_orgao) values(2,'PM 17°');
insert into acid_orgaoresp(cod_orgao,desc_orgao) values(3,'PM 32° - 171°');
insert into acid_orgaoresp(cod_orgao,desc_orgao) values(4,'PAV');
insert into acid_orgaoresp(cod_orgao,desc_orgao) values(5,'PM 32° - 92°');
insert into acid_orgaoresp(cod_orgao,desc_orgao) values(6,'PM 32° - 109°');
insert into acid_orgaoresp(cod_orgao,desc_orgao) values(7,'PM 32° - 169°');

----------------------------------------------------------------------------

create table acid_controletrafego(
cod_controle int4 not null,
desc_controle varchar(40),
constraint acidcontroletrafego_pk primary key(cod_controle)
);
alter table acid_controletrafego owner to postgres;
--insercao
insert into acid_controletrafego(cod_controle,desc_controle) values (1,'Feito por Gesto');
insert into acid_controletrafego(cod_controle,desc_controle) values (2,'Sinal Luminoso');
insert into acid_controletrafego(cod_controle,desc_controle) values (3,'Sinalização de Regulamentação');
insert into acid_controletrafego(cod_controle,desc_controle) values (4,'Sinalização de Advertência');
insert into acid_controletrafego(cod_controle,desc_controle) values (5,'Nenhuma Sinalização');
insert into acid_controletrafego(cod_controle,desc_controle) values (6,'Não Apurado');
------------------------------------------------------------------------------------

create table acid_clima(
cod_clima int4 not null,
desc_clima varchar(15),
constraint acidclima_pk primary key (cod_clima)
);
alter table acid_clima owner to postgres;
--insercao
insert into acid_clima(cod_clima,desc_clima) values (1,'Bom');
insert into acid_clima(cod_clima,desc_clima) values (2,'Chuva');
insert into acid_clima(cod_clima,desc_clima) values (3,'Neblina');
insert into acid_clima(cod_clima,desc_clima) values (4,'Nublado');
insert into acid_clima(cod_clima,desc_clima) values (5,'Não Apurado');

--------------------------------------------------------------------------------------------

create table acid_pavimentacao(
cod_pavimentacao int4 not null,
desc_pavimentacao varchar(15),
constraint acidpavimentacao_pk primary key (cod_pavimentacao)
);
alter table acid_pavimentacao owner to postgres;

--inserts

insert into acid_pavimentacao(cod_pavimentacao,desc_pavimentacao) values(1,'Asfalto');
insert into acid_pavimentacao(cod_pavimentacao,desc_pavimentacao) values(2,'Concreto');
insert into acid_pavimentacao(cod_pavimentacao,desc_pavimentacao) values(3,'Terra');
insert into acid_pavimentacao(cod_pavimentacao,desc_pavimentacao) values(4,'Cascalho');
insert into acid_pavimentacao(cod_pavimentacao,desc_pavimentacao) values(5,'Paralelepípedo');
insert into acid_pavimentacao(cod_pavimentacao,desc_pavimentacao) values(6,'Não Apurada');
insert into acid_pavimentacao(cod_pavimentacao,desc_pavimentacao) values(7,'Outros');
---------------------------------------------------------------------------------------------
create table acid_caracteristicavia(
cod_caracteristica int4 not null,
desc_caracteristica varchar(30),
constraint acidcaracteristicavia_pk primary key (cod_caracteristica)
);
alter table acid_caracteristicavia owner to postgres;

--inserts

insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (1,'Cruzamento');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (2,'Reta');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (3,'Aclive');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (4,'Declive');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (5,'Depressão');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (6,'Rotatória');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (7,'Redutor de Velocidade');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (8,'Curva');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (9,'Não Apurada');
insert into acid_caracteristicavia(cod_caracteristica,desc_caracteristica) values (10,'Outra');


---------------------------------------------------------------------------------------------
create table acid_condicaovia(
cod_condicao int4 not null,
desc_condicao varchar(30),
constraint acidcondicaovia_pk primary key(cod_condicao)
);
alter table acid_condicaovia owner to postgres;

--insercao
insert into acid_condicaovia(cod_condicao,desc_condicao) values (1,'Oleosa');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (2,'Interrompida');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (3,'Obstruída');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (4,'Em Obras');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (5,'Esburacada');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (6,'Lamacenta');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (7,'Boas Condições');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (8,'Material na Pista');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (9,'Seca');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (10,'Molhada');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (11,'Não Apurada');
insert into acid_condicaovia(cod_condicao,desc_condicao) values (12,'Outra');
--------------------------------------------------------------------------------------------


----
create table acid_socorro
(
  cod_socorro int4 not null,
  desc_socorro varchar(40),
  constraint acidsocorro_pk primary key (cod_socorro)
  )
with (oids=false);
alter table acid_socorro owner to postgres;

--insercao tabela tipo socorro
insert into acid_socorro(cod_socorro,desc_socorro) values (1,'Bombeiros');
insert into acid_socorro(cod_socorro,desc_socorro) values (2,'Polícia');
insert into acid_socorro(cod_socorro,desc_socorro) values (3,'Transeuntes');
insert into acid_socorro(cod_socorro,desc_socorro) values (4,'Familiares');
insert into acid_socorro(cod_socorro,desc_socorro) values (5,'Envolvidos');
insert into acid_socorro(cod_socorro,desc_socorro) values (6,'Não Apurado');
insert into acid_socorro(cod_socorro,desc_socorro) values (7,'Outros');
insert into acid_socorro(cod_socorro,desc_socorro) values (8,'Não Necessitou de Socorro');

---------------------------------------------
create table acid_tipo
(
cod_tipo int4 not null,
desc_tipo varchar(50),
constraint acidtipo_pk primary key(cod_tipo)
);
alter table acid_tipo owner to postgres;
---insercao
insert into acid_tipo(cod_tipo,desc_tipo) values (1,'Capotamento/Tombamento');
insert into acid_tipo(cod_tipo,desc_tipo) values (2,'Abalroamento');
insert into acid_tipo(cod_tipo,desc_tipo) values (3,'Queda de Veículo');
insert into acid_tipo(cod_tipo,desc_tipo) values (4,'Queda de Pessoa do Veículo');
insert into acid_tipo(cod_tipo,desc_tipo) values (5,'Queda/Vazamento de Carga');
insert into acid_tipo(cod_tipo,desc_tipo) values (6,'Atropelamento de Animal');
insert into acid_tipo(cod_tipo,desc_tipo) values (7,'Choque Mecânico');
insert into acid_tipo(cod_tipo,desc_tipo) values (8,'Colisão de Veículo');
insert into acid_tipo(cod_tipo,desc_tipo) values (9,'Incêndio');
insert into acid_tipo(cod_tipo,desc_tipo) values (10,'Saída da Pista');
insert into acid_tipo(cod_tipo,desc_tipo) values (11,'Queda no Interior do Veículo');
insert into acid_tipo(cod_tipo,desc_tipo) values (12,'Atropelamento de Pedestre');
insert into acid_tipo(cod_tipo,desc_tipo) values (13,'Outros');

----------------------------------------------------------------------------------------

--tabela caracteristica do acidente - esquema: public

CREATE TABLE acid_caracteristica
(
  cod_caracteristica int4 NOT NULL,
  desc_caracteristica character varying(30) NOT NULL,
  CONSTRAINT acidcaracteristica_pk PRIMARY KEY (cod_caracteristica)
)
WITH (OIDS=FALSE);
ALTER TABLE acid_caracteristica OWNER TO postgres;

--insercao de dados tabela caracteristica do acidente

insert into acid_caracteristica(cod_caracteristica,desc_caracteristica) values (1,'Frontal');
insert into acid_caracteristica(cod_caracteristica,desc_caracteristica) values (2,'Traseira');
insert into acid_caracteristica(cod_caracteristica,desc_caracteristica) values (3,'Longitudinal');
insert into acid_caracteristica(cod_caracteristica,desc_caracteristica) values (4,'Transversal');
insert into acid_caracteristica(cod_caracteristica,desc_caracteristica) values (5,'Não Apurado');
insert into acid_caracteristica(cod_caracteristica,desc_caracteristica) values (6,'Outro');

--------------------------------------------------------
--tabela causa do acidente - esquema: public

CREATE TABLE acid_causa
(
  cod_causa int4 NOT NULL,
  desc_causa character varying(50) NOT NULL,
  CONSTRAINT acidcausa_pk PRIMARY KEY (cod_causa)
)
WITH (OIDS=FALSE);
ALTER TABLE acid_causa OWNER TO postgres;
--insercao de dados tabela causa do acidente

insert into acid_causa(cod_causa,desc_causa) values(1,'Animal na Pista');
insert into acid_causa(cod_causa,desc_causa) values(2,'Defeito no Veículo');
insert into acid_causa(cod_causa,desc_causa) values(3,'Desobedecer Sinalização');
insert into acid_causa(cod_causa,desc_causa) values(4,'Desobedecer Sinal de Pare');
insert into acid_causa(cod_causa,desc_causa) values(5,'Excesso de Velocidade');
insert into acid_causa(cod_causa,desc_causa) values(6,'Defeito na Via');
insert into acid_causa(cod_causa,desc_causa) values(7,'Avanço de Sinal Luminoso');
insert into acid_causa(cod_causa,desc_causa) values(8,'Não Manteve Distância Segura');
insert into acid_causa(cod_causa,desc_causa) values(9,'Contra-Mão de Direção');
insert into acid_causa(cod_causa,desc_causa) values(10,'Ultrapassagem Forçada');
insert into acid_causa(cod_causa,desc_causa) values(11,'Parou Subitamente');
insert into acid_causa(cod_causa,desc_causa) values(12,'Má Visibilidade');
insert into acid_causa(cod_causa,desc_causa) values(13,'Pista Escorregadia');
insert into acid_causa(cod_causa,desc_causa) values(14,'Falta de Atenção');
insert into acid_causa(cod_causa,desc_causa) values(15,'Pedestre Atravessou Subitamente');
insert into acid_causa(cod_causa,desc_causa) values(16,'Não Usou os Freios');
insert into acid_causa(cod_causa,desc_causa) values(17,'Visão Prejudicada por Carga');
insert into acid_causa(cod_causa,desc_causa) values(18,'Mudou Subitamente de Direção');
insert into acid_causa(cod_causa,desc_causa) values(19,'Não Apurada');
insert into acid_causa(cod_causa,desc_causa) values(20,'Outras');

-----------------------------------------------------------

-- FINAL DAS TABELAS AUXILIARES PARA ACIDENTES

-----------------------------------------------------------
-- comportamento do condutor após acidente
CREATE TABLE cond_comportamento
(
  cod_comportamento int4 NOT NULL,
  desc_comportamento character varying(25) NOT NULL,
  CONSTRAINT condcomportamento_pk PRIMARY KEY (cod_comportamento)
)
WITH (OIDS=FALSE);
ALTER TABLE cond_comportamento OWNER TO postgres;

--insercao de dados
insert into cond_comportamento(cod_comportamento,desc_comportamento) values(1,'Permaneceu no Local');
insert into cond_comportamento(cod_comportamento,desc_comportamento) values(2,'Prestou Socorro');
insert into cond_comportamento(cod_comportamento,desc_comportamento) values(3,'Evadiu do Local');
insert into cond_comportamento(cod_comportamento,desc_comportamento) values(4,'Encaminhado ao PS');
insert into cond_comportamento(cod_comportamento,desc_comportamento) values(5,'Não Apurado');
insert into cond_comportamento(cod_comportamento,desc_comportamento) values(6,'Outros');

-----------------------------------------------------------
create table cond_escolaridade(
cod_escolaridade int4 not null,
desc_escolaridade varchar(50),
constraint condescolaridade_pk primary key (cod_escolaridade)
);
alter table cond_escolaridade owner to postgres;
--insercao
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (1,'Analfabeto');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (2,'Alfabetizado');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (3,'Ensino Fundamental Incompleto');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (4,'Ensino Fundamental Completo');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (5,'Ensino Médio Incompleto');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (6,'Ensino Médio Completo');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (7,'Superior Incompleto');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (8,'Superior Completo');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (9,'Não Necessita');
insert into cond_escolaridade(cod_escolaridade,desc_escolaridade) values (10,'Não Apurada');

-------------------------------------------------------------------
create table cond_condicao(
cod_condicao int4 not null,
desc_condicao varchar(25),
constraint condcondicao_pk primary key(cod_condicao)
);
alter table cond_condicao owner to postgres;

--inserts

insert into cond_condicao(cod_condicao,desc_condicao) values(1,'Aparência Normal');
insert into cond_condicao(cod_condicao,desc_condicao) values(2,'Aparência Sonolenta');
insert into cond_condicao(cod_condicao,desc_condicao) values(3,'Sintomas de Embriaguez');
insert into cond_condicao(cod_condicao,desc_condicao) values(4,'Mal Súbito');
insert into cond_condicao(cod_condicao,desc_condicao) values(5,'Não Apurado');
insert into cond_condicao(cod_condicao,desc_condicao) values(6,'Outros');

-------------------------------------------------------------------
CREATE TABLE cond_sexo
(
  cod_sexo int4 NOT NULL,
  desc_sexo character varying(15),
  CONSTRAINT condsexo_pk PRIMARY KEY (cod_sexo)
)
WITH (OIDS=FALSE);
ALTER TABLE cond_sexo OWNER TO postgres;
--insercao de dados
insert into cond_sexo(cod_sexo,desc_sexo) values(1,'Masculino');
insert into cond_sexo(cod_sexo,desc_sexo) values(2,'Feminino');
insert into cond_sexo(cod_sexo,desc_sexo) values(3,'Não Apurado');

-------------------------------------------------------------------------
create table cond_profissao(
cod_profissao int4 not null,
desc_profissao varchar(50),
constraint condprofissao_pk primary key(cod_profissao)
);
alter table cond_profissao owner to postgres;
--insercao
insert into cond_profissao(cod_profissao,desc_profissao) values (1,'Nenhuma');
insert into cond_profissao(cod_profissao,desc_profissao) values (2,'Estudante');
insert into cond_profissao(cod_profissao,desc_profissao) values (3,'Aposentado');
insert into cond_profissao(cod_profissao,desc_profissao) values (4,'Atividades Sociais');
insert into cond_profissao(cod_profissao,desc_profissao) values (5,'Cargos Operacionais');
insert into cond_profissao(cod_profissao,desc_profissao) values (6,'Cargos Administrativos');
insert into cond_profissao(cod_profissao,desc_profissao) values (7,'Cargos de Chefia');
insert into cond_profissao(cod_profissao,desc_profissao) values (8,'Profissional Liberal');
insert into cond_profissao(cod_profissao,desc_profissao) values (9,'Não Apurado');
insert into cond_profissao(cod_profissao,desc_profissao) values (10,'Outros');

----------------------------------------------------------------------------
create table cond_habilitacao(
cod_habilitacao int4 not null,
desc_habilitacao varchar(15),
constraint condhabilitacao_pk primary key (cod_habilitacao)
);
alter table cond_habilitacao owner to postgres;
--insert
insert into cond_habilitacao(cod_habilitacao,desc_habilitacao) values (1,'Permissão');
insert into cond_habilitacao(cod_habilitacao,desc_habilitacao) values (2,'Habilitado');
insert into cond_habilitacao(cod_habilitacao,desc_habilitacao) values (3,'Vencida');
insert into cond_habilitacao(cod_habilitacao,desc_habilitacao) values (4,'Não Necessita');
insert into cond_habilitacao(cod_habilitacao,desc_habilitacao) values (5,'Não Habilitado');
insert into cond_habilitacao(cod_habilitacao,desc_habilitacao) values (6,'Não Apurado');
--------------------------------------------------------------
CREATE TABLE veic_sentido
(
  cod_sentido int4 NOT NULL,
  desc_sentido character varying(35) NOT NULL,
  CONSTRAINT veicsentido_pk PRIMARY KEY (cod_sentido)
)
WITH (OIDS=FALSE);
ALTER TABLE veic_sentido OWNER TO postgres;
--insercao de dados
insert into veic_sentido(cod_sentido,desc_sentido) values(13,'Via Principal');
insert into veic_sentido(cod_sentido,desc_sentido) values(31,'Via Principal (contra-mão)');
insert into veic_sentido(cod_sentido,desc_sentido) values(24,'Via Secundária');
insert into veic_sentido(cod_sentido,desc_sentido) values(42,'Via Secundária (contra-mão)');
---------------------------------------------------------------
create table veic_tipo
(
cod_tipo int4 not null,
desc_tipo varchar(40),
constraint veictipo_pk primary key(cod_tipo)
);
alter table veic_tipo owner to postgres;
--insert
insert into veic_tipo(cod_tipo,desc_tipo) values (1,'Pedestre');
insert into veic_tipo(cod_tipo,desc_tipo) values (2,'Não Apurado');
insert into veic_tipo(cod_tipo,desc_tipo) values (3,'Bicicleta');
insert into veic_tipo(cod_tipo,desc_tipo) values (4,'Ciclomoto');
insert into veic_tipo(cod_tipo,desc_tipo) values (5,'Motoneta');
insert into veic_tipo(cod_tipo,desc_tipo) values (6,'Motocicleta');
insert into veic_tipo(cod_tipo,desc_tipo) values (7,'Triciclo');
insert into veic_tipo(cod_tipo,desc_tipo) values (8,'Quadriciclo');
insert into veic_tipo(cod_tipo,desc_tipo) values (9,'Automóvel');
insert into veic_tipo(cod_tipo,desc_tipo) values (10,'Micro-ônibus');
insert into veic_tipo(cod_tipo,desc_tipo) values (11,'Ônibus');
insert into veic_tipo(cod_tipo,desc_tipo) values (12,'Reboque');
insert into veic_tipo(cod_tipo,desc_tipo) values (13,'Semi-reboque');
insert into veic_tipo(cod_tipo,desc_tipo) values (14,'Charrete/Carroça');
insert into veic_tipo(cod_tipo,desc_tipo) values (15,'Camioneta');
insert into veic_tipo(cod_tipo,desc_tipo) values (16,'Caminhonete');
insert into veic_tipo(cod_tipo,desc_tipo) values (17,'Caminhão');
insert into veic_tipo(cod_tipo,desc_tipo) values (18,'Carrinho de Mão');
insert into veic_tipo(cod_tipo,desc_tipo) values (19,'C.Trator');
insert into veic_tipo(cod_tipo,desc_tipo) values (20,'Trator de Rodas');
insert into veic_tipo(cod_tipo,desc_tipo) values (21,'Trator de Esteira');
insert into veic_tipo(cod_tipo,desc_tipo) values (22,'Trator Misto');
insert into veic_tipo(cod_tipo,desc_tipo) values (23,'Especial/Ônibus');
insert into veic_tipo(cod_tipo,desc_tipo) values (24,'Experiência');
-------------------------------------------------------------------------------

create table veic_apreendido(
cod_apreendido int4 not null,
desc_apreendido varchar(20),
constraint veicapreendido primary key(cod_apreendido)
);
alter table veic_apreendido owner to postgres;
--insert
insert into veic_apreendido(cod_apreendido,desc_apreendido) values(1,'Sim');
insert into veic_apreendido(cod_apreendido,desc_apreendido) values(2,'Não');
insert into veic_apreendido(cod_apreendido,desc_apreendido) values(3,'Não Apurado');

create table veic_equipamentoseg(
cod_equip int4 not null,
desc_equip varchar(15),
constraint veicequipamentoseg_pk primary key(cod_equip)
);
alter table veic_equipamentoseg owner to postgres;
--insercao
insert into veic_equipamentoseg(cod_equip,desc_equip) values (1,'Sim');
insert into veic_equipamentoseg(cod_equip,desc_equip) values (2,'Não');
insert into veic_equipamentoseg(cod_equip,desc_equip) values (3,'Não Apurado');
insert into veic_equipamentoseg(cod_equip,desc_equip) values (4,'NN');
-----------------------------------------------------------------------
