USE InstutuTec
GO



-- Agragar Datos a la Tabla Tarifa
-- ===============================

Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) Values('A',300,'Ofimatica - Computacion Basica')
Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) Values('B',350,'Desarrollo de SoftWare - Basico')
Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) Values('C',400,'Desarrollo de SoftWare - Intermedio/Avanzado')
Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) Values('D',450,'Sistemas Operativos - Intermedio/Avanzado')
Insert Into TB_Tarifa(IdTarifa,PreTarifa,Descripcion) Values('E',500,'Administradores de Bases de Datos')


-- Agragar Datos a la Tabla Curso
-- ==============================

Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C001','A','Windows 10')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C002','A','Excel empresarial')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C003','A','Gestión de dispositivos')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C004','B','Diseño y Programación de Base de Datos')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C005','B','Analisis y Diseño de Sistemas')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C006','B','Fundamentos de Programación')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C007','C','Programación Avanzada de Bases de Datos')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C008','C','MS Visual Basic.Net - Componentes')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C009','C','Diseño de Sistemas con UML')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C010','C','Desarrollo de Apliaciones 1')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C011','C','Analitica de sistemas empresariales')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C012','C','POO con C#')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C013','D','Windows Server 1')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C014','D','Windows Server 2')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C015','D','Administración y gestión de servidores Windows Server')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C016','D','Linux Server 1')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C017','D','Linux Server 2')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C018','D','Red hat Enterprise Linux')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C019','D','Virtualización de data centers')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C020','E','Administración y Gestión de Base de Datos')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C021','E','Alta disponibilidad y Redundancia de Base de Datos')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C022','E','Mineria de datos')
Insert Into TB_Curso(IdCurso,IdTarifa,NomCurso) Values('C023','E','Inteligencia de negocios orientada a las Bases de datos')

-- Agragar Datos a la Tabla Ciclo
-- ==============================

Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-01','20230115','20230220')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-02','20230220','20230325')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-03','20230405','20230510')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-04','20230515','20230620')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-05','20230621','20230722')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-06','20230801','20230830')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-07','20230905','20231005')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-08','20231006','20231108')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2023-09','20231110','20231212')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2024-01','20240110','20240215')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2024-02','20130218','20240320')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2024-03','20240322','20240425')
Insert Into TB_Periodo(IdPeriodo,FecInicio,FecTermino) Values('2024-04','20240426','20240528')


-- Agragar Datos a la Tabla TB_Profesor
-- =================================

Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P001','ALLASI BARDALES','DAVID ENRIQUE ','La Molina','994258631','DALLASIB@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P002','ARCE SÁNCHEZ','NORVIL ANTONIO','Breña','997605040','NARCES@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P003','RAMOS LING','ITALO DAVID','San Miguel','969460717','IRAMOSL@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P004','SAKAMOTO ORTEGA','DANIEL FRANCISCO','San miguel','965309482','DSAKAMOTOO@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P005','VILLAR BOJOVIC','ANDRES ALEKSANDAR MILUTIN','Lince','999092126','AVILLARB@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P006','NUÑEZ SANCHEZ','ANDRES JOSE','Los Olivos','991491526','ANUNEZS@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P007','QUIROGA FARRO','AZUCENA PAOLA','Puente piedra','912401505','AQUIROGAFARRO@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P008','VINCES LOPEZ','EVELIN DOLORES','San martin','912401505','EVINCESL@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P009','QUIROZ PACAYA','CARLI ESTHER','Los Olivos','none','CQUIROZP@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P010','RENTERIA PEREZ','PRISCILA CECILIA','San Juan del Lurigancho','none','PRENTERIAP@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P011','CHUMPITAZ CHAVEZ','WENDY ROSY','Villa el Salvador','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P012','EVANGELISTA ROSAS','ANDREA GABRIELA','Rimac','none','AEVANGELISTAR@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P013','DIAZ RODRÍGUEZ','GILBERTO ALEXIS','San Juan de Miraflores','none','GDIAZR@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P014','ARANDA VICENTE','RAUL MANUEL','Jesús Maria','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P015','LAGOS CUSICHI','TATIANA NAHOMI','Independencia','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P016','CRUZ ZAPATA','ERICSSON HANS','Villa Maria del Triunfo','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P017','RAMIREZ CRUZ','ABIGAIL ANA','Miraflores','none','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P018','MILLA CHIPANA','HENRY WILLIAN','San Martin de Porres','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P019','VILLACORTAv GUZMAN','LUIGGI','El Agustino','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P020','RATTO ALVARADO','MARIAJOSE','Carabayllo','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor)	Values ('P021','PALMA POMA','RODRIGO GABRIEL','Rimac','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P022','NAJARRO JANAMPA','JENIFER','Lima','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P023','RODRIGUEZ DIAZ','LESLY DIANA','Magdalena','None','@instutuTec.edu.pe')	
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P024','ALFARO ARAOZ','MEYLI ESTEFANIA','San isidro','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P037','GIRALDO CERNA','CLAUDIA CECILIA','Lima','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P038','BETETA EMANUELE','ERICK OMAR ','Comas','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P039','PALOMINO CHOQUECONZA','SHARON PATRICIA	','Comas','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P040','ALIAGA MACEDO','ESTEFANY CAROLINE','Breña','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P041','SALVADOR MONTAÑEZ','JUDITH TANIA','Rimac','None','@instutuTec.edu.pe')
Insert Into TB_Profesor(Id_Profesor,Ape_Profesor,Nom_Profesor,Dir_Profesor,Tel_Profesor,Email_Profesor) Values ('P042','CISNEROS LAROSA','YERSON JAIME','La Molina','None','@instutuTec.edu.pe')



-- Agregar Datos a la Tabla Alumno
-- ===============================


Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0001','GUERRERO HUAMAN','ALEXIS SALVADOR','48932571')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0002','LOPEZ SHAPIAMA','ALEXANDRA JULIETH','27815432')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0003','BENDEZU SEIJAS','ALEXANDRA CAROLINE','55577203')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0004','GUARDALES QUEZADA','PAOLA JACKELINE','36994054')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0005','MENDO BEZADA','SUSAN INGRID','77696438')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0006','PLAZA HIDALGO','NICOLE MIRELLA','37724589')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0007','SALAZAR LEDESMA','GABRIELA','80676519')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0008','SILVA GONZALES','FABIO CESAR','80670097')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0009','REYES ROMERO','KAREN LILIANA','27261800')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0010','TICONA RAMOS','LIZ MARY','49725839')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0011','CANALES GALVEZ','LESLY LUZMILA','61267099')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0012','TUFINO MALPARTIDA','ANDY NESTOR','96144263')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0013','HUAYNATE MIRAMIRA','MARIANA YOSELIN','22268980')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0014','VILLACORTA PONCE','FRANCISCO PABLO','72853148')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0015','QUISPE PEREZ','JULISSA','74690198')
Insert Into TB_Alumno(IdAlumno,ApeAlumno,NomAlumno,ndocum) Values('A0016','RIVERA GARCÍA','FERNANDA','43815147')


-- Agregar Datos a la Tabla TB_CursoProgramado
-- ========================================

-- Ciclo: 2022-01

Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C001','P003','Lu y Mi 19-22 Horas',10,10,1,200)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C002','P002','Mi y Vi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C003','P005','Ma y Ju 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C004','P001','Ju y Sa 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C005','P001','Lu y Mi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C006','P002','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C007','P004','Mi y Vi 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C008','P004','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C009','P002','Lu y Mi 19-22 Horas',20,0,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C010','P002','Ju y Sa 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-01','C011','P002','Lu y Mi 19-22 Horas',20,0,1,300)


-- Ciclo: 2022-02
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C001','P003','Lu y Mi 19-22 Horas',10,10,1,200)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C002','P002','Mi y Vi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C003','P005','Ma y Ju 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C004','P001','Ju y Sa 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C005','P001','Lu y Mi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C006','P002','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C007','P004','Mi y Vi 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C008','P004','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C009','P002','Lu y Mi 19-22 Horas',20,0,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C010','P002','Ju y Sa 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C011','P002','Lu y Mi 19-22 Horas',20,0,1,300)



-- Ciclo: 2022-03
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C001','P003','Lu y Mi 19-22 Horas',10,10,1,200)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C002','P002','Mi y Vi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C003','P005','Ma y Ju 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C004','P001','Ju y Sa 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C005','P001','Lu y Mi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C006','P002','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C007','P004','Mi y Vi 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C008','P004','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C009','P002','Lu y Mi 19-22 Horas',20,0,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C010','P002','Ju y Sa 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C011','P002','Lu y Mi 19-22 Horas',20,0,1,300)

-- Ciclo: 2022-04

Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C001','P003','Lu y Mi 19-22 Horas',10,10,1,200)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C002','P002','Mi y Vi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C003','P005','Ma y Ju 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C004','P001','Ju y Sa 19-22 Horas',10,10,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C005','P001','Lu y Mi 19-22 Horas',10,10,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C006','P002','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C007','P004','Mi y Vi 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C008','P004','Ma y Ju 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C009','P002','Lu y Mi 19-22 Horas',20,0,1,250)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C010','P002','Ju y Sa 19-22 Horas',20,0,1,300)
Insert Into TB_CursoProgramado( IdPeriodo,IdCurso,Id_Profesor,Horario,Vacantes,Matriculados,Activo,PreCursoProg ) Values( '2012-02','C011','P002','Lu y Mi 19-22 Horas',20,0,1,300)



-- Agregar Datos a la Tabla TB_Matricula
-- ==================================

-- Ciclo: 2012-01     Curso: C001

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0001','20120103',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0002','20120103',10,14,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0003','20120103',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0004','20120103',09,11,10 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0005','20120103',15,19,17 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0006','20120104',11,13,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0007','20120104',07,09,08 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0008','20120104',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0009','20120104',17,19,18 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0010','20120104',12,16,14 )


-- Ciclo: 2012-01     Curso: C002


Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0001','20120103',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0002','20120103',10,14,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0003','20120103',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0004','20120103',09,11,10 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0005','20120103',15,19,17 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0006','20120104',11,13,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0007','20120104',07,09,08 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0008','20120104',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0009','20120104',17,19,18 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) Values( 1,'A0010','20120104',12,16,14 )

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0011','20120103',14,16,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0012','20120103',12,14,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0013','20120103',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0014','20120103',09,11,10 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0015','20120103',08,10,09 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0016','20120104',12,16,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0017','20120104',11,13,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0018','20120104',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0019','20120104',14,16,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 2,'A0020','20120104',13,15,14 )


-- Ciclo: 2012-01     Curso: C003

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0021','20120103',09,11,10 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0022','20120103',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0023','20120103',11,13,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0024','20120103',10,16,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0025','20120103',05,17,11 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0026','20120104',09,15,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0027','20120104',14,16,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0028','20120104',13,17,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0029','20120104',15,19,17 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 3,'A0030','20120104',18,14,16 )


-- Ciclo: 2012-01     Curso: C004

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0001','20120103',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0003','20120103',10,16,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0005','20120103',16,12,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0007','20120103',14,12,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0009','20120103',18,12,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0011','20120104',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0013','20120104',12,16,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0015','20120104',10,16,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0017','20120104',11,15,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 4,'A0019','20120104',09,15,12 )


-- Ciclo: 2012-01     Curso: C005

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0002','20120103',12,14,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0004','20120103',15,13,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0006','20120103',12,16,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0008','20120103',08,14,11 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0010','20120103',11,15,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0012','20120104',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0014','20120104',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0016','20120104',17,19,18 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0018','20120104',13,11,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 5,'A0020','20120104',12,16,14 )


-- Ciclo: 2012-02     Curso: C001

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) 
	Values( 12,'A0001','20120103',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 12,'A0002','20120103',10,14,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 12,'A0003','20120103',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 12,'A0004','20120103',09,11,10 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 12,'A0005','20120103',15,19,17 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 12,'A0006','20120104',11,13,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio ) 
	Values( 12,'A0007','20120104',07,09,08 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 12,'A0008','20120104',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 12,'A0009','20120104',17,19,18 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 12,'A0010','20120104',12,16,14 )


-- Ciclo: 2012-02     Curso: C002

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0011','20120103',14,16,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0012','20120103',12,14,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0013','20120103',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0014','20120103',09,11,10 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0015','20120103',08,10,09 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0016','20120104',12,16,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0017','20120104',11,13,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0018','20120104',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0019','20120104',14,16,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 13,'A0020','20120104',13,15,14 )


-- Ciclo: 2012-02     Curso: C003

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0021','20120103',09,11,10 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0022','20120103',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0023','20120103',11,13,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0024','20120103',10,16,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0025','20120103',05,17,11 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0026','20120104',09,15,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0027','20120104',14,16,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0028','20120104',13,17,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0029','20120104',15,19,17 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 14,'A0030','20120104',18,14,16 )


-- Ciclo: 2012-02     Curso: C004

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0001','20120103',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0003','20120103',10,16,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0005','20120103',16,12,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0007','20120103',14,12,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0009','20120103',18,12,15 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0011','20120104',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0013','20120104',12,16,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0015','20120104',10,16,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0017','20120104',11,15,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 15,'A0019','20120104',09,15,12 )


-- Ciclo: 2012-02     Curso: C005

Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0002','20120103',12,14,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0004','20120103',15,13,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0006','20120103',12,16,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0008','20120103',08,14,11 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0010','20120103',11,15,13 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0012','20120104',13,15,14 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0014','20120104',15,17,16 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0016','20120104',17,19,18 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0018','20120104',13,11,12 )
Insert Into TB_Matricula( IdCursoProg,IdAlumno,FecMatricula,ExaParcial,ExaFinal,Promedio )
	Values( 16,'A0020','20120104',12,16,14 )

