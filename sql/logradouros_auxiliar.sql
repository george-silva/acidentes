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
59	Avenida	Ortízio Borges
97	Avenida	Segismundo Pereira
133	Avenida	Ana Godoy de Souza
164	Avenida	Dr. Laerte Vieira Gonçalves
190	Rua	Maria Esperança
194	Rua	João Furlaneto
197	Rua	Antônio Dias
201	Rua	Alfredo Tormim
204	Rua	Prof. João Luiz
206	Rua	Joaquina Porelo Dias
212	Rua	Antônia Saltão de Almeida
213	Rua	Francisco Vicente Ferreira
226	Avenida	César Finotti
240	Rua	Marciano Santos
246	Rua	João José da Silva
257	Rua	Antônio J. S. Franqueiro
264	Alameda	Uberaba
272	Rua	Saturnino Pedro dos Santos
276	Rua	Francisco Antônio Fernandes
279	Rua	Tomaz Falbo
290	Rua	Izaú Rangel de Mendonça
301	Rua	Miguel Rocha dos Santos
305	Rua	Izaura Augusta Pereira
309	Rua	Maria Dirce Ribeiro
314	Rua	Cecílio Jorge
319	Rua	João Pereira da Silva
325	Rua	Prof. Eueler Cannes Bernardes
330	Rua	Isaac de Oliveira
336	Rua	Mário Pinto Sobrinho
341	Rua	Juventude
345	Rua	Ensino
348	Rua	Itatiaia
353	Rua	Santa Edivirges
357	Rua	Irmã Dulce
360	Rua	Sirlei Arantes
369	Avenida	José Paes Almeida
384	Rua	Alexandrino Santos Lima
390	Rua	Maria Dora Cunha
395	Rua	Waldomira Rezende
400	Rua	Professora Nilda de São José
405	Rua	Arlindo Souza Monteiro
409	Rua	Romeu Margonari
414	Rua	Joaquim Fernades Veloso
418	Rua	Romenos Simão
421	Rua	Virgílio M. Leite
434	Avenida	Lázara Alves Ferreira
450	Rua	João Velasco Andrade
458	Rua	Nelson de Oliveira
466	Rua	Maria das Dores Dias
474	Rua	Delmira Cândida Rodrigues da Cunha
484	Rua	Antônio Fortunato da Silva
494	Rua	Manoel Camargos da Cruz
495	Rua	Hildebrando Oliva
506	Rua	Atílio Valentini
517	Avenida	Juvenilia F. dos Santos
528	Rua	Nordau Gonçalves de Melo
545	Avenida	Francisco Ribeiro
561	Avenida	Dr. Jaime Ribeiro da Luz
580	Avenida	Dr. Misael Rodrigues de Castro
602	Rua	João Balbino
622	Avenida	José Rezende Costa
653	Avenida	Salomão Abraão
675	Rua	Péricles Vieira da Mota
685	Rua	José Miguel Saramago
696	Rua	Pedro José Samora
709	Rua	Alberto Alves Cabral
724	Rua	Antônio Salviano Rezende
738	Rua	Jorge Martins Pinto
752	Rua	Patrulheiro Osmar Tavares
763	Rua	Sebastian Arantes Fonseca
774	Rua	José Lelis França
785	Rua	Antônio Rezende Chaves
799	Rua	José Carrijo
812	Rua	João Catanduva
824	Rua	Orozimbo Ribeiro
837	Rua	Antônio Marciano de Ávila
848	Rua	Manuel Serralha
859	Rua	Jornalista João de Oliveira
871	Rua	Sebastião Rangel
884	Rua	José Rodrigues Queiroz Filho
897	Rua	Armando Tucci
911	Rua	Lycidio Paes
925	Rua	Francisco Antônio de Oliveira
940	Rua	Manoel Ascenso Batista
954	Rua	Profa. Maria Alves Castilho
977	Avenida	Anselmo Alves dos Santos
1019	Avenida	João Naves de Ávila
1055	Avenida	Ubiratan Honório de Castro
1065	Rua	Sem Nome
1068	Rua	Planalto
1071	Rua	Izaac Antônio Silva
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

