USE InstutuTec
GO

-- Agregar Datos a la Tabla Local
-- ===============================


insert into TB_Local (idLocal, DirLocal, DisLocal)
values(1, 'Av. Alfredo Benavides 778', 1)
insert into TB_Local (idLocal, DirLocal, DisLocal)
values(2, 'Av. Faustino Sánchez Carrión 285', 1)
insert into TB_Local (idLocal, DirLocal, DisLocal)
values(3, 'Av. la Fontana 955', 1)


-- Agragar Datos a la Tabla Tarifa
-- ===============================

Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) 
Values('A',300,'Ofimatica - Computacion Basica')
Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) 
Values('B',350,'Desarrollo de SoftWare - Basico')
Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) 
Values('C',400,'Desarrollo de SoftWare - Intermedio/Avanzado')
Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) 
Values('D',450,'Sistemas Operativos - Intermedio/Avanzado')
Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) 
Values('E',500,'Administradores de Bases de Datos')


-- Agragar Datos a la Tabla Curso
-- ==============================


Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C001','A','Windows 10',1)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C002','A','Excel empresarial',1)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C003','A','Gestión de dispositivos',2)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C004','B','Diseño y Programación de Base de Datos',2)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C005','B','Analisis y Diseño de Sistemas',1)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C006','B','Fundamentos de Programación',3)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C007','C','Programación Avanzada de Bases de Datos',3)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C008','C','MS Visual Basic.Net - Componentes',1)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C009','C','Diseño de Sistemas con UML',2)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C010','C','Desarrollo de Apliaciones 1',2)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C011','C','Analitica de sistemas empresariales',3)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C012','C','POO con C#', 3)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C013','D','Windows Server 1', 1)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C014','D','Windows Server 2', 3)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C015','D','Administración y gestión de servidores Windows Server',2)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C016','D','Linux Server 1', 2)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C017','D','Linux Server 2', 1)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C018','D','Red hat Enterprise Linux', 1)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C019','D','Virtualización de data centers',2)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C020','E','Administración y Gestión de Base de Datos',3)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C021','E','Alta disponibilidad y Redundancia de Base de Datos',1)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal)  
Values('C022','E','Mineria de datos',3)
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso,IdLocal) 
Values('C023','E','Inteligencia de negocios orientada a las Bases de datos',1)

-- Agragar Datos a la Tabla Ciclo
-- ==============================

Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-01','20230115','20230220')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-02','20230220','20230325')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-03','20230405','20230510')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-04','20230515','20230620')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-05','20230621','20230722')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-06','20230801','20230830')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-07','20230905','20231005')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-08','20231006','20231108')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-09','20231110','20231212')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2024-01','20240110','20240215')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2024-02','20240218','20240320')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2024-03','20240322','20240425')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino)
Values('2024-04','20240426','20240528')


-- Agragar Datos a la Tabla TB_Profesor
-- =================================


Insert Into TB_profesor(IdProfesor, NomProfesor, ApeProfesor, DirProfesor, TelProfesor, EmailProfesor) 
Values ('P001','DAVID ENRIQUE ','ALLASI BARDALES','La Molina','994258631','DALLASIB@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P002','ARCE SÁNCHEZ','NORVIL ANTONIO','Breña','997605040','NARCES@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P003','RAMOS LING','ITALO DAVID','San Miguel','969460717','IRAMOSL@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P004','SAKAMOTO ORTEGA','DANIEL FRANCISCO','San miguel','965309482','DSAKAMOTOO@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P005','VILLAR BOJOVIC','ANDRES ALEKSANDAR MILUTIN','Lince','999092126','AVILLARB@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P006','NUÑEZ SANCHEZ','ANDRES JOSE','Los Olivos','991491526','ANUNEZS@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P007','QUIROGA FARRO','AZUCENA PAOLA','Puente piedra','912401505','AQUIROGAFARRO@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P008','VINCES LOPEZ','EVELIN DOLORES','San martin','912401505','EVINCESL@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P009','QUIROZ PACAYA','CARLI ESTHER','Los Olivos','none','CQUIROZP@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P010','RENTERIA PEREZ','PRISCILA CECILIA','San Juan del Lurigancho','none','PRENTERIAP@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P011','CHUMPITAZ CHAVEZ','WENDY ROSY','Villa el Salvador','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P012','EVANGELISTA ROSAS','ANDREA GABRIELA','Rimac','none','AEVANGELISTAR@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P013','DIAZ RODRÍGUEZ','GILBERTO ALEXIS','San Juan de Miraflores','none','GDIAZR@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P014','ARANDA VICENTE','RAUL MANUEL','Jesús Maria','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P015','LAGOS CUSICHI','TATIANA NAHOMI','Independencia','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P016','CRUZ ZAPATA','ERICSSON HANS','Villa Maria del Triunfo','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P017','RAMIREZ CRUZ','ABIGAIL ANA','Miraflores','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P018','MILLA CHIPANA','HENRY WILLIAN','San Martin de Porres','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P019','VILLACORTAv GUZMAN','LUIGGI','El Agustino','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P020','RATTO ALVARADO','MARIAJOSE','Carabayllo','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P021','PALMA POMA','RODRIGO GABRIEL','Rimac','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P022','NAJARRO JANAMPA','JENIFER','Lima','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P023','RODRIGUEZ DIAZ','LESLY DIANA','Magdalena','None','@instutuTec.edu.pe')	
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,DirProfesor,TelProfesor,EmailProfesor)
Values ('P024','ALFARO ARAOZ','MEYLI ESTEFANIA','San isidro','None','@instutuTec.edu.pe')




-- Agregar Datos a la Tabla Alumno
-- ===============================


Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0001','ALEXIS SALVADOR','GUERRERO HUAMAN','SAN BORJA','48932571','alexis_guerrero_huaman@instututec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0002','ALEXANDRA JULIETH','LOPEZ SHAPIAMA','SURCO','27815432', 'alexandra_lopez@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0003','ALEXANDRA CAROLINE','BENDEZU SEIJAS','LA MOLINA','55577203', 'alexandra_bendezu_seijas@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0004','PAOLA JACKELINE','GUARDALES QUEZADA','SURCO','36994054','paola_guardale_quezada@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0005','SUSAN INGRID','MENDO BEZADA','SAN JUAN DE LURIGANCHO','77696438', 'susan_mendo_bezada@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0006','NICOLE MIRELLA','PLAZA HIDALGO','EL AGUSTINO','37724589', 'nicole_plaza_hidalgo@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0007','GABRIELA','SALAZAR LEDESMA','MIRAFLORES','80676519','gabriela_salazar_ledesma@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0008','FABIO CESAR','SILVA GONZALES','MAGDALENA DEL MAR','80670097', 'fabio_silva_gonzales@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0009','KAREN LILIANA','REYES ROMERO','SAN ISIDRO','27261800', 'karen_reyes_romero@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0010','LIZ MARY','TICONA RAMOS','SANTA ANITA','49725839', 'liz_ticona_ramos@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0011','LESLY LUZMILA','CANALES GALVEZ','SANTIAGO DE SURCO','61267099', 'lesly_canales_galves@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0012','ANDY NESTOR','TUFINO MALPARTIDA','LA MOLINA','96144263','andy_tufino_malpartida@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0013','MARIANA YOSELIN','HUAYNATE MIRAMIRA','CERCADO DE LIMA','22268980', 'mariana_huaynate_miramira@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0014','FRANCISCO PABLO','VILLACORTA PONCE','PUEBLO LIBRE','72853148', 'francisco_villacorta_ponce@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0015','JULISSA','QUISPE PEREZ','SAN BORJA','74690198', 'julissa_quispe_perez@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
Values('A0016','FERNANDA','RIVERA GARCÍA','CHORRILLOS','43815147','fernanda_rivera_garcia@instutec.com')

Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0017','CESAR','PEREDA RAMIREZ','SAN BORJA','98765432','cesar_pereda_ramirez@instutec.com')

Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0018','MARIA','RODRIGUEZ PALOMINO','ATE','96548732','maria_rodriguez_palomino@instutec.com')

Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0019','JOSE','DEJO WONG','LA MOLINA','971853461','jose_dejo_wong@instutec.com')

Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0020','ARTURO','RAMIREZ SANCHEZ','BARRANCO','945633321','arturo_ramirez_sanchez@instutec.com')

Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0021','JORGE','TORRES AHEN','SURQUILLO','96060341', 'jorge_torres_ahen@instutec.com')

Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0022','GLADYS','CONCHA LEON','COMAS','974356164','gladys_concha_leon@instutec.com')

Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0023','Claudia','Quispe','COMAS','974356164','gladys_concha_leon@instutec.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0024','Beatriz','Perez','noche','977445512','beatriz_perez@colegio.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0025','Ernesto','Veliz','Tarde','931426787','ernesto_veliz@colegio.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0026','Felix','Panduro','SAN BORJA','98732145','felix_panduro@colegio.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0027','Camila','Razo','SAN ISIDRO','965432198','camilia_razo@colegio.com')

insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0028','Renzo','Echegoyen','SURQUILLO','958647167','renzo_echegoyen@colegio.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0029','Alejandra','Barrionuevo','SAN BARTOLO','902455556','alejandra_barrionuevo@colegio.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0030','Pedro','Castillo','CHOSICA','945319542','pedro_castillo@colegio.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0031','Alan','Garcia','LA MOLINA','966604223','alan_garcia@colegio.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0032','Luis','Quilca','PUEBLO LIBRE','951363592','luis_quilca@colegio.com')


insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0033','Ricardo','Nue','LINCE','960960971','ricardo_nue@colegio.com')

insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0034','REMO','OLAYA GARCIA','LINCE','960960971','remo_olaya_ garcia@instutec.com')

insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0035','ALONSO','PEREZ GARCIA','SANTIAGO DE SURCO','965600971','alonso_perez_garcia@instutec.com')

insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0036','DIEGO','VIVANCO ANAYA','LINCE','950960971','diego_vivanco_anaya@instutec.com')

insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0037','IVANNA','LOPEZ GARCIA','LINCE','950967971','ivanna_lopez_garcia@instutec.com')

insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0038','LAURA','ILLARRAMENDI LUYO','SAN BORJA','950960321','laura_illaramendi_luyo@instutec.com')

insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0039','ANDREA','POZA GOMEZ','SAN ISIDRO','950900271','andrea_poza_gomez@instutec.com')

insert into TB_Alumno (IdAlumno,NomAlumno,ApeAlumno,DisAlumno, TelAlumno, EmailAlumno) 
values ('A0040','ANDY','MENDEZ AMPUERO','ATE','950960900','andy_mendez_ampuero@instutec.com')


-- Agregar Datos a la Tabla TB_CursoProgramado
-- ========================================

-- Ciclo: 2023-01


Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 1,'2023-01','C001','P003','Lu y Mi 19-22 Horas',10,10,1,200)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 2,'2023-01','C002','P002','Mi y Vi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 3,'2023-01','C003','P005','Ma y Ju 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 4,'2023-01','C004','P001','Ju y Sa 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 5,'2023-01','C005','P001','Lu y Mi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 6,'2023-01','C006','P002','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 7,'2023-01','C007','P004','Mi y Vi 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 8,'2023-01','C008','P004','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 9,'2023-01','C009','P002','Lu y Mi 19-22 Horas',20,0,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 10,'2023-01','C010','P002','Ju y Sa 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 11,'2023-01','C011','P002','Lu y Mi 19-22 Horas',20,0,1,300)


-- Ciclo: 2023-02
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 12,'2023-02','C001','P003','Lu y Mi 19-22 Horas',10,10,1,200)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 13,'2023-02','C002','P002','Mi y Vi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 14,'2023-02','C003','P005','Ma y Ju 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 15,'2023-02','C004','P001','Ju y Sa 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 16,'2023-02','C005','P001','Lu y Mi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 17,'2023-02','C006','P002','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 18,'2023-02','C007','P004','Mi y Vi 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 19,'2023-02','C008','P004','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 20,'2023-02','C009','P002','Lu y Mi 19-22 Horas',20,0,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 21,'2023-02','C010','P002','Ju y Sa 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 22,'2023-02','C011','P002','Lu y Mi 19-22 Horas',20,0,1,300)



-- Ciclo: 2023-03
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 23,'2023-02','C001','P003','Lu y Mi 19-22 Horas',10,10,1,200)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 24,'2023-02','C002','P002','Mi y Vi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 25,'2023-02','C003','P005','Ma y Ju 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 26,'2023-02','C004','P001','Ju y Sa 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 27,'2023-02','C005','P001','Lu y Mi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 28,'2023-02','C006','P002','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 29,'2023-02','C007','P004','Mi y Vi 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 30,'2023-02','C008','P004','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 31,'2023-02','C009','P002','Lu y Mi 19-22 Horas',20,0,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 32,'2023-02','C010','P002','Ju y Sa 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 33,'2023-02','C011','P002','Lu y Mi 19-22 Horas',20,0,1,300)

-- Ciclo: 2023-04

Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 34,'2023-02','C001','P003','Lu y Mi 19-22 Horas',10,10,1,200)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 35,'2023-02','C002','P002','Mi y Vi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 36,'2023-02','C003','P005','Ma y Ju 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 37,'2023-02','C004','P001','Ju y Sa 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 38,'2023-02','C005','P001','Lu y Mi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 39,'2023-02','C006','P002','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 40,'2023-02','C007','P004','Mi y Vi 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 41,'2023-02','C008','P004','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 42,'2023-02','C009','P002','Lu y Mi 19-22 Horas',20,0,1,250)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 43,'2023-02','C010','P002','Ju y Sa 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado (IdCursoProg,IdPeriodo,IdCurso,IdProfesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( 44,'2023-02','C011','P002','Lu y Mi 19-22 Horas',20,0,1,300)



-- Agregar Datos a la Tabla TB_Matricula
-- ==================================

-- Ciclo: 2023-01     Curso: C001

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0001','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0002','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0003','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0004','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0005','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0006','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0007','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0008','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0009','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula) Values( 1,'A0010','20230104')


-- Ciclo: 2023-01     Curso: C002


Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values(2,'A0001','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0002','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0003','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0004','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0005','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0006','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0007','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0008','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0009','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0010','20230104')

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0011','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0012','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0013','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0014','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0015','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0016','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0017','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0018','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0019','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 2,'A0020','20230104')


-- Ciclo: 2023-01     Curso: C003

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0021','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0022','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0023','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0024','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0025','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0026','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0027','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0028','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0029','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 3,'A0030','20230104')


-- Ciclo: 2023-01     Curso: C004

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0001','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0003','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0005','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0007','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0009','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0011','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0013','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0015','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0017','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 4,'A0019','20230104')


-- Ciclo: 2023-01     Curso: C005

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0002','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0004','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0006','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0008','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0010','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0012','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0014','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0016','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0018','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 5,'A0020','20230104')


-- Ciclo: 2023-02     Curso: C001

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0001','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0002','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0003','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0004','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0005','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0006','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0007','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0008','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0009','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 12,'A0010','20230104')


-- Ciclo: 2023-02     Curso: C002

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0011','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0012','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0013','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0014','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0015','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0016','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0017','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0018','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0019','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 13,'A0020','20230104')


-- Ciclo: 2023-02     Curso: C003

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0021','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0022','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0023','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0024','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0025','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0026','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0027','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0028','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0029','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 14,'A0030','20230104')


-- Ciclo: 2023-02     Curso: C004

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0001','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0003','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0005','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0007','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0009','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0011','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0013','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0015','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0017','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 15,'A0019','20230104')


-- Ciclo: 2023-02     Curso: C005

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0002','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0004','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0006','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0008','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0010','20230103')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0012','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0014','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0016','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0018','20230104')
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula ) Values( 16,'A0020','20230104')

