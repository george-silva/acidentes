--
-- PostgreSQL database dump
--

-- Started on 2008-09-28 21:29:07

SET client_encoding = 'WIN1252';
SET standard_conforming_strings = off;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET escape_string_warning = off;

SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 3504 (class 1259 OID 176437)
-- Dependencies: 7
-- Name: nomelog; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE nomelog (
    cod_logradouro integer NOT NULL,
    tipo_logradouro character varying(60),
    desc_logradouro character varying(60)
);


ALTER TABLE public.nomelog OWNER TO postgres;

--
-- TOC entry 3820 (class 0 OID 176437)
-- Dependencies: 3504
-- Data for Name: nomelog; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY nomelog (cod_logradouro, tipo_logradouro, desc_logradouro) FROM stdin;
20	Avenida	Belarmino Cotta Pacheco
59	Avenida	Ort�zio Borges
97	Avenida	Segismundo Pereira
133	Avenida	Ana Godoy de Souza
164	Avenida	Dr. Laerte Vieira Gon�alves
190	Rua	Maria Esperan�a
194	Rua	Jo�o Furlaneto
197	Rua	Ant�nio Dias
201	Rua	Alfredo Tormim
204	Rua	Prof. Jo�o Luiz
206	Rua	Joaquina Porelo Dias
212	Rua	Ant�nia Salt�o de Almeida
213	Rua	Francisco Vicente Ferreira
226	Avenida	C�sar Finotti
240	Rua	Marciano Santos
246	Rua	Jo�o Jos� da Silva
257	Rua	Ant�nio J. S. Franqueiro
264	Alameda	Uberaba
272	Rua	Saturnino Pedro dos Santos
276	Rua	Francisco Ant�nio Fernandes
279	Rua	Tomaz Falbo
290	Rua	Iza� Rangel de Mendon�a
301	Rua	Miguel Rocha dos Santos
305	Rua	Izaura Augusta Pereira
309	Rua	Maria Dirce Ribeiro
314	Rua	Cec�lio Jorge
319	Rua	Jo�o Pereira da Silva
325	Rua	Prof. Eueler Cannes Bernardes
330	Rua	Isaac de Oliveira
336	Rua	M�rio Pinto Sobrinho
341	Rua	Juventude
345	Rua	Ensino
348	Rua	Itatiaia
353	Rua	Santa Edivirges
357	Rua	Irm� Dulce
360	Rua	Sirlei Arantes
369	Avenida	Jos� Paes Almeida
384	Rua	Alexandrino Santos Lima
390	Rua	Maria Dora Cunha
395	Rua	Waldomira Rezende
400	Rua	Professora Nilda de S�o Jos�
405	Rua	Arlindo Souza Monteiro
409	Rua	Romeu Margonari
414	Rua	Joaquim Fernades Veloso
418	Rua	Romenos Sim�o
421	Rua	Virg�lio M. Leite
434	Avenida	L�zara Alves Ferreira
450	Rua	Jo�o Velasco Andrade
458	Rua	Nelson de Oliveira
466	Rua	Maria das Dores Dias
474	Rua	Delmira C�ndida Rodrigues da Cunha
484	Rua	Ant�nio Fortunato da Silva
494	Rua	Manoel Camargos da Cruz
495	Rua	Hildebrando Oliva
506	Rua	At�lio Valentini
517	Avenida	Juvenilia F. dos Santos
528	Rua	Nordau Gon�alves de Melo
545	Avenida	Francisco Ribeiro
561	Avenida	Dr. Jaime Ribeiro da Luz
580	Avenida	Dr. Misael Rodrigues de Castro
602	Rua	Jo�o Balbino
622	Avenida	Jos� Rezende Costa
653	Avenida	Salom�o Abra�o
675	Rua	P�ricles Vieira da Mota
685	Rua	Jos� Miguel Saramago
696	Rua	Pedro Jos� Samora
709	Rua	Alberto Alves Cabral
724	Rua	Ant�nio Salviano Rezende
738	Rua	Jorge Martins Pinto
752	Rua	Patrulheiro Osmar Tavares
763	Rua	Sebastian Arantes Fonseca
774	Rua	Jos� Lelis Fran�a
785	Rua	Ant�nio Rezende Chaves
799	Rua	Jos� Carrijo
812	Rua	Jo�o Catanduva
824	Rua	Orozimbo Ribeiro
837	Rua	Ant�nio Marciano de �vila
848	Rua	Manuel Serralha
859	Rua	Jornalista Jo�o de Oliveira
871	Rua	Sebasti�o Rangel
884	Rua	Jos� Rodrigues Queiroz Filho
897	Rua	Armando Tucci
911	Rua	Lycidio Paes
925	Rua	Francisco Ant�nio de Oliveira
940	Rua	Manoel Ascenso Batista
954	Rua	Profa. Maria Alves Castilho
977	Avenida	Anselmo Alves dos Santos
1019	Avenida	Jo�o Naves de �vila
1055	Avenida	Ubiratan Hon�rio de Castro
1065	Rua	Sem Nome
1068	Rua	Planalto
1071	Rua	Izaac Ant�nio Silva
\.


--
-- TOC entry 3823 (class 0 OID 0)
-- Dependencies: 3504
-- Name: nomelog; Type: ACL; Schema: public; Owner: postgres
--

REVOKE ALL ON TABLE nomelog FROM PUBLIC;
REVOKE ALL ON TABLE nomelog FROM postgres;
GRANT ALL ON TABLE nomelog TO postgres;
GRANT SELECT,INSERT,REFERENCES,TRIGGER,UPDATE ON TABLE nomelog TO usuarios;
GRANT ALL ON TABLE nomelog TO administradores WITH GRANT OPTION;
GRANT ALL ON TABLE nomelog TO PUBLIC;
GRANT SELECT,INSERT,REFERENCES,TRIGGER,UPDATE ON TABLE nomelog TO intermediario;


-- Completed on 2008-09-28 21:29:08

--
-- PostgreSQL database dump complete
--

