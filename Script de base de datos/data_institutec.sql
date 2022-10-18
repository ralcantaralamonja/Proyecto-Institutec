USE InstituTec
GO
--Creando indices 

--Indice que ordena alfabetimante cada distrito

CREATE NONCLUSTERED INDEX OrdenarPorNombre
	ON Tb_Ubigeo(distri)

--Indice que ordena alfabetimante Alumnos por apellido

CREATE NONCLUSTERED INDEX OrdenarPorApelAlum
	ON TB_Alumno(LasAlu)

-- Fin de indices


--Creando UK

-- Llave unica para documento de alumnos
ALTER TABLE TB_Alumno	
ADD CONSTRAINT DocAlum	
UNIQUE(Ndocum)

-- Llave unica para documento de profesor

ALTER TABLE TB_Profesor 	
ADD CONSTRAINT DocPro	
UNIQUE(Ndocum)

-- Fin de UK

-- Agregar Datos a la Tabla Facultad
-- ===============================

Insert into TB_Facultad (IdFacu, DesFac) values ('Facu01','Facultad de Diseño')
Insert into TB_Facultad (IdFacu, DesFac) values ('Facu02','Facultad de Comunicación')
Insert into TB_Facultad (IdFacu, DesFac) values ('Facu03','Facultad de Marketing')
Insert into TB_Facultad (IdFacu, DesFac) values ('Facu04','Facultad de Negocios')
Insert into TB_Facultad (IdFacu, DesFac) values ('Facu05','Facultad de Tecnología')
Insert into TB_Facultad (IdFacu, DesFac) values ('Facu06','Facultad de Hotelería y Turismo')



-- Agragar Datos a la Tabla Carrera
-- ===============================

Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C001','Facu01','Diseño Gráfico')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C002','Facu01','Diseño de Interiores')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C003','Facu01','Diseño y Desarrollo de Videojuegos')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C004','Facu01','Animación Digital y Diseño 3D')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C005','Facu01','Diseño de Medios Interactivos (UX)')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C006','Facu02','Periodismo Deportivo')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C007','Facu02','Comunicación Audiovisual')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C008','Facu02','Comunicación Integral')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C009','Facu02','Fotografía y Producción de Imagen')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C010','Facu03','Marketing y Gestión de Moda')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C011','Facu03','Marketing')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C012','Facu03','Publicidad y Medios Digitales')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C013','Facu03','Gestión Comercial y Negocios Digitales')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C014','Facu04','Administración de Empresas')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C015','Facu04','Negocios Internacionales')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C016','Facu04','Administración y Finanzas')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C017','Facu04','Recursos Humanos')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C018','Facu04','Administración Bancaria')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C019','Facu04','Gestión Logística Integral')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C020','Facu05','Desarrollo de Software')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C021','Facu05','Redes y Comunicaciones')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C022','Facu05','Sistemas de Información')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C023','Facu06','Hotelería')
Insert into Tb_Carrera(CodCar,IdFacu,DesCar) values ('C024','Facu06','Turismo')


-- Agragar Datos a la Tabla Ciclo
-- ===============================

Insert into TB_Semestre(IdSeme,Descrp,FecInc,FecFin) values('2023-00','Ciclo verano','20230102','20230402')
Insert into TB_Semestre(IdSeme,Descrp,FecInc,FecFin) values('2023-02','Ciclo regular 1 de 2023','20230427','20230824')
Insert into TB_Semestre(IdSeme,Descrp,FecInc,FecFin) values('2023-03','Ciclo regular 2 de 2023','20230827','20231223')

-- Agragar Datos a la Tabla Estado de Matricula
-- ===============================

Insert into TB_Estado_Matricula(EstMat,DesEst) values (1,'Pagada')
Insert into TB_Estado_Matricula(EstMat,DesEst) values (2,'Pendiente de pago')
Insert into TB_Estado_Matricula(EstMat,DesEst) values (3,'Anulada')

-- Agragar Datos a la Tabla Ubigeo
-- ===============================

Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140101','14',	'01','01','Lima','Lima','Lima')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140102','14',	'02','02','Lima','Lima','Ancon')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140103','14',	'03','03','Lima','Lima','Ate')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140104','14',	'04','04','Lima','Lima','Breña')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140105','14',	'05','05','Lima','Lima','Carabayllo')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140106','14',	'06','06','Lima','Lima','Comas')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140107','14',	'07','07','Lima','Lima','Chaclacayo')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140108','14',	'08','08','Lima','Lima','Chorrillos')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140109','14',	'09','09','Lima','Lima','La Victoria')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140110','14',	'10','10','Lima','Lima','La Molina')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140111','14',	'11','11','Lima','Lima','Lince')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140112','14',	'12','12','Lima','Lima','Lurigancho')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140113','14',	'13','13','Lima','Lima','Lurin')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140114','14',	'14','14','Lima','Lima','Magdalena del Mar')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140115','14',	'15','15','Lima','Lima','Miraflores')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140116','14',	'16','16','Lima','Lima','Pachacamac')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140117','14',	'17','17','Lima','Lima','Pueblo Libre')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140118','14',	'18','18','Lima','Lima','Pucusana')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140119','14',	'19','19','Lima','Lima','Puente Piedra')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140120','14',	'20','20','Lima','Lima','Punta Hermosa')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140121','14',	'21','21','Lima','Lima','Punta Negra')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140122','14',	'22','22','Lima','Lima','Rimac')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140123','14',	'23','23','Lima','Lima','San Bartolo')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140124','14',	'24','24','Lima','Lima','San Isidro')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140125','14',	'25','25','Lima','Lima','Barranco')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140126','14',	'26','26','Lima','Lima','San Martin de Porres')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140127','14',	'27','27','Lima','Lima','San Miguel')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140128','14',	'28','28','Lima','Lima','Santa Maria del Mar')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140129','14',	'29','29','Lima','Lima','Santa Rosa')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140130','14',	'30','30','Lima','Lima','Santiago de Surco')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140131','14',	'31','31','Lima','Lima','Surquillo')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140132','14',	'32','32','Lima','Lima','Villa Maria del Triunfo')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140133','14',	'33','33','Lima','Lima','Jesus Maria')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140134','14',	'34','34','Lima','Lima','Independencia')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140135','14',	'35','35','Lima','Lima','El Agustino')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140136','14',	'36','36','Lima','Lima','San Juan de Miraflores')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140137','14',	'37','37','Lima','Lima','San Juan de Lurigancho')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140138','14',	'38','38','Lima','Lima','San Luis')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140139','14',	'39','39','Lima','Lima','Cieneguilla')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140140','14',	'40','40','Lima','Lima','San Borja')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140141','14',	'41','41','Lima','Lima','Villa El Salvador')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140142','14',	'42','42','Lima','Lima','Los Olivos')
Insert into Tb_Ubigeo (Id_Ubi,IdDepa,IdProv,IdDist,Depart,Provin,Distri) values ('140143','14',	'43','43','Lima','Lima','Santa Anita')

-- Agregar Datos a la Tabla Alumno
-- ===============================
EXECUTE USP_INSERTARALUMNO 'ALEXIS SALVADOR','GUERRERO HUAMAN','09000228','Facu05','140140'
EXECUTE USP_INSERTARALUMNO 'ALEXANDRA JULIETH','LOPEZ SHAPIAMA','60121975','Facu05','140102'
EXECUTE USP_INSERTARALUMNO 'ALEXANDRA CAROLINE','BENDEZU SEIJAS','70202922','Facu05','140103'
EXECUTE USP_INSERTARALUMNO 'PAOLA JACKELINE','GUARDALES QUEZADA','59842369','Facu05','140125'
EXECUTE USP_INSERTARALUMNO 'SUSAN INGRID','MENDO BEZADA','81840471','Facu05','140104'
EXECUTE USP_INSERTARALUMNO 'NICOLE MIRELLA','PLAZA HIDALGO','92900341','Facu05','140105'
EXECUTE USP_INSERTARALUMNO 'GABRIELA MIRANDA','SALAZAR LEDESMA','94941620','Facu05','140107'
EXECUTE USP_INSERTARALUMNO 'FABIO CESAR','SILVA GONZALES','38160300','Facu05','140108'
EXECUTE USP_INSERTARALUMNO 'KAREN LILIANA','REYES ROMERO','54568430','Facu05','140133'
EXECUTE USP_INSERTARALUMNO 'LIZ MARY','TICONA RAMOS','34184084','Facu05','140133'
EXECUTE USP_INSERTARALUMNO 'LESLY LUZMILA','CANALES GALVEZ','16397541','Facu05','140106'
EXECUTE USP_INSERTARALUMNO 'ANDY NESTOR','TUFINO MALPARTIDA','47622648','Facu05','140135'
EXECUTE USP_INSERTARALUMNO 'MARIANA YOSELIN','HUAYNATE MIRAMIRA','76344220','Facu05','140134'
EXECUTE USP_INSERTARALUMNO 'FRANCISCO PABLO','VILLACORTA PONCE','97614497','Facu05','140110'
EXECUTE USP_INSERTARALUMNO 'JULISSA STEFANYA','QUISPE PEREZ','31607096','Facu05','140109'
EXECUTE USP_INSERTARALUMNO 'FERNANDA MADELEIN','RIVERA GARCÍA','57794067','Facu05','140101'
EXECUTE USP_INSERTARALUMNO 'CESAR AUGUSTO','PEREDA RAMIREZ','84855224','Facu05','140111'
EXECUTE USP_INSERTARALUMNO 'MARIA DEL CARMEN','RODRIGUEZ PALOMINO','83438408','Facu05','140142'
EXECUTE USP_INSERTARALUMNO 'JOSE LUIS','DEJO WONG','44838283','Facu05','140116'
EXECUTE USP_INSERTARALUMNO 'ARTURO MARIO','RAMIREZ SANCHEZ','45142009','Facu05','140114'
EXECUTE USP_INSERTARALUMNO 'JORGE LUIS','TORRES AHEN','27562726','Facu05', '140112'
EXECUTE USP_INSERTARALUMNO 'GLADYS EMILIA','CUEVA VITERI','78164851','FACU05','140112'

--Hasta aca
--------------------------------------------------------------------------------------------------------------------

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



--delete TB_profesor

-- Agragar Datos a la Tabla TB_Profesor
-- =================================
 



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




-- delete TB_Alumno



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

 


 