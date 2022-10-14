USE InstituTec
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
--Select * from TB_Curso

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
--Select * from TB_periodo
-- ==============================

Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-01','20230102','20230402')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-02','20230427','20230824')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) 
Values('2023-03','20230827','20231223')

--delete TB_profesor

-- Agragar Datos a la Tabla TB_Profesor
-- =================================
CREATE NONCLUSTERED INDEX AplNomProf
	ON TB_PROFESOR(ApeProfesor,NomProfesor)



Insert Into TB_profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor, EmailProfesor) Values ('P001','ALLASI BARDALES','DAVID ENRIQUE','57914411','La Molina','994258631','DALLASIB@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P002','ARCE SÁNCHEZ','NORVIL ANTONIO','13056023','Breña','997605040','NARCES@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P003','RAMOS LING','ITALO DAVID','08421861','San Miguel','969460717','IRAMOSL@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P004','SAKAMOTO ORTEGA','DANIEL FRANCISCO','56140614','San miguel','965309482','DSAKAMOTOO@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P005','VILLAR BOJOVIC','ANDRES ALEKSANDAR MILUTIN','02902488','Lince','999092126','AVILLARB@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P006','NUÑEZ SANCHEZ','ANDRES JOSE','57916305','Los Olivos','991491526','ANUNEZS@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P007','QUIROGA FARRO','AZUCENA PAOLA','33962873','Puente piedra','912401505','AQUIROGAFARRO@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P008','VINCES LOPEZ','EVELIN DOLORES','68704612','San martin','912401505','EVINCESL@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P009','QUIROZ PACAYA','CARLI ESTHER','07903683','Los Olivos','none','CQUIROZP@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P010','RENTERIA PEREZ','PRISCILA CECILIA','13052847','San Juan del Lurigancho','none','PRENTERIAP@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P011','CHUMPITAZ CHAVEZ','WENDY ROSY','80841236','Villa el Salvador','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P012','EVANGELISTA ROSAS','ANDREA GABRIELA','20359729','Rimac','none','AEVANGELISTAR@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P013','DIAZ RODRÍGUEZ','GILBERTO ALEXIS','20947531','San Juan de Miraflores','none','GDIAZR@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P014','ARANDA VICENTE','RAUL MANUEL','70095888','Jesús Maria','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P015','LAGOS CUSICHI','TATIANA NAHOMI','81729332','Independencia','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P016','CRUZ ZAPATA','ERICSSON HANS','13877827','Villa Maria del Triunfo','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P017','RAMIREZ CRUZ','ABIGAIL ANA','02013171','Miraflores','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P018','MILLA CHIPANA','HENRY WILLIAN','93953444','San Martin de Porres','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P019','VILLACORTA GUZMAN','LUIGGI','91030463','El Agustino','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P020','RATTO ALVARADO','MARIAJOSE','73448499','Carabayllo','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P021','PALMA POMA','RODRIGO GABRIEL','96608344','Rimac','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P022','NAJARRO JANAMPA','JENIFER','03161596','Lima','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P023','RODRIGUEZ DIAZ','LESLY DIANA','20723655','Magdalena','None','@instutuTec.edu.pe')	
Insert Into TB_Profesor(IdProfesor,ApeProfesor,NomProfesor,Ndocum,DisProfesor,TelProfesor,EmailProfesor) Values ('P024','ALFARO ARAOZ','MEYLI ESTEFANIA','83263318','San isidro','None','@instutuTec.edu.pe')
/*
Select COUNT(IdProfesor) from TB_Profesor
X if (x <100) -> p0x else -> P099
P024  POSIBLE STORE PARA INSERT AUTOMATICO
*/


-- Agregar Datos a la Tabla Alumno
-- ===============================

-- delete TB_Alumno

CREATE NONCLUSTERED INDEX AplNomAlum
	ON TB_Alumno(ApeAlumno,NomAlumno)

Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0001','ALEXIS SALVADOR','GUERRERO HUAMAN','09000228','SAN BORJA','48932571','alexis_guerrero_huaman@instututec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0002','ALEXANDRA JULIETH','LOPEZ SHAPIAMA','60121975','SURCO','27815432', 'alexandra_lopez@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0003','ALEXANDRA CAROLINE','BENDEZU SEIJAS','70202922','LA MOLINA','55577203', 'alexandra_bendezu_seijas@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0004','PAOLA JACKELINE','GUARDALES QUEZADA','59842369','SURCO','36994054','paola_guardale_quezada@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0005','SUSAN INGRID','MENDO BEZADA','81840471','SAN JUAN DE LURIGANCHO','77696438', 'susan_mendo_bezada@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0006','NICOLE MIRELLA','PLAZA HIDALGO','92900341','EL AGUSTINO','37724589', 'nicole_plaza_hidalgo@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0007','GABRIELA','SALAZAR LEDESMA','94941620','MIRAFLORES','80676519','gabriela_salazar_ledesma@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0008','FABIO CESAR','SILVA GONZALES','38160300','MAGDALENA DEL MAR','80670097', 'fabio_silva_gonzales@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0009','KAREN LILIANA','REYES ROMERO','54568430','SAN ISIDRO','27261800', 'karen_reyes_romero@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0010','LIZ MARY','TICONA RAMOS','34184084','SANTA ANITA','49725839', 'liz_ticona_ramos@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0011','LESLY LUZMILA','CANALES GALVEZ','16397541','SANTIAGO DE SURCO','61267099', 'lesly_canales_galves@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0012','ANDY NESTOR','TUFINO MALPARTIDA','47622648','LA MOLINA','96144263','andy_tufino_malpartida@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0013','MARIANA YOSELIN','HUAYNATE MIRAMIRA','76344220','CERCADO DE LIMA','22268980', 'mariana_huaynate_miramira@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0014','FRANCISCO PABLO','VILLACORTA PONCE','97614497','PUEBLO LIBRE','72853148', 'francisco_villacorta_ponce@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0015','JULISSA','QUISPE PEREZ','31607096','SAN BORJA','74690198', 'julissa_quispe_perez@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) Values ('A0016','FERNANDA','RIVERA GARCÍA','57794067','CHORRILLOS','43815147','fernanda_rivera_garcia@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0017','CESAR','PEREDA RAMIREZ','84855224','SAN BORJA','98765432','cesar_pereda_ramirez@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0018','MARIA','RODRIGUEZ PALOMINO','83438408','ATE','96548732','maria_rodriguez_palomino@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0019','JOSE','DEJO WONG','44838283','LA MOLINA','971853461','jose_dejo_wong@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0020','ARTURO','RAMIREZ SANCHEZ','45142009','BARRANCO','945633321','arturo_ramirez_sanchez@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0021','JORGE','TORRES AHEN','27562726','SURQUILLO','96060341', 'jorge_torres_ahen@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0022','GLADYS','CONCHA LEON','78164851','COMAS','974356164','gladys_concha_leon@instutec.com')
Insert Into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0023','Claudia','Quispe','53970612','COMAS','974356164','gladys_concha_leon@instutec.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0024','Beatriz','Perez','86688197','SANTA ANITA','977445512','beatriz_perez@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0025','Ernesto','Veliz','71057347','CHOSICA','931426787','ernesto_veliz@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0026','Felix','Panduro','57502112','SAN BORJA','98732145','felix_panduro@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0027','Camila','Razo','29707291','SAN ISIDRO','965432198','camilia_razo@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0028','Renzo','Echegoyen','04805949','SURQUILLO','958647167','renzo_echegoyen@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0029','Alejandra','Barrionuevo','92278833','SAN BARTOLO','902455556','alejandra_barrionuevo@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0030','Pedro','Castillo','98949426','CHOSICA','945319542','pedro_castillo@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0031','Alan','Garcia','65523636','LA MOLINA','966604223','alan_garcia@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0032','Luis','Quilca','24086043','PUEBLO LIBRE','951363592','luis_quilca@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0033','Ricardo','Nue','69213215','LINCE','960960971','ricardo_nue@colegio.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0034','REMO','OLAYA GARCIA','93128609','LINCE','960960971','remo_olaya_ garcia@instutec.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0035','ALONSO','PEREZ GARCIA','57379547','SANTIAGO DE SURCO','965600971','alonso_perez_garcia@instutec.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0036','DIEGO','VIVANCO ANAYA','14089492','LINCE','950960971','diego_vivanco_anaya@instutec.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0037','IVANNA','LOPEZ GARCIA','36591776','LINCE','950967971','ivanna_lopez_garcia@instutec.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0038','LAURA','ILLARRAMENDI LUYO','91030242','SAN BORJA','950960321','laura_illaramendi_luyo@instutec.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0039','ANDREA','POZA GOMEZ','58883702','SAN ISIDRO','950900271','andrea_poza_gomez@instutec.com')
insert into TB_Alumno(IdAlumno,NomAlumno,ApeAlumno,ndocum,DisAlumno, TelAlumno, EmailAlumno) values ('A0040','ANDY','MENDEZ AMPUERO','97272848','ATE','950960900','andy_mendez_ampuero@instutec.com')

--Hasta aqui

-- Agregar Datos a la Tabla TB_CursoProgramado
-- ========================================

-- Ciclo: 2023-01

Insert Into TB_CursoProgramado(IdCursoProg,IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario) values('MAT001','C003','2023-01','P003',300,'Jue 19-22')
Insert Into TB_CursoProgramado(IdCursoProg,IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario) values('MAT002','C003','2023-01','P004',300,'Mie 19-22')
Insert Into TB_CursoProgramado(IdCursoProg,IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario) values('MAT003','C004','2023-01','P002',350,'Vie 19-22')
Insert Into TB_CursoProgramado(IdCursoProg,IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario) values('MAT004','C004','2023-01','P005',350,'Mar 19-22')
Insert Into TB_CursoProgramado(IdCursoProg,IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario) values('MAT005','C006','2023-01','P002',350,'Lun 19-22')
Insert Into TB_CursoProgramado(IdCursoProg,IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario) values('MAT006','C006','2023-01','P005',350,'Sab 19-22')
-- Agregar Datos a la Tabla TB_Matricula
-- ==================================

 


 