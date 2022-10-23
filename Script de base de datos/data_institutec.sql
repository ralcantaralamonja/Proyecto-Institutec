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

Execute usp_InsertarCarrera 'Facu01','Diseño Gráfico'
Execute usp_InsertarCarrera 'Facu01','Diseño de Interiores'
Execute usp_InsertarCarrera 'Facu01','Diseño y Desarrollo de Videojuegos'
Execute usp_InsertarCarrera 'Facu01','Animación Digital y Diseño 3D'
Execute usp_InsertarCarrera 'Facu01','Diseño de Medios Interactivos (UX)'
Execute usp_InsertarCarrera 'Facu02','Periodismo Deportivo'
Execute usp_InsertarCarrera 'Facu02','Comunicación Audiovisual'
Execute usp_InsertarCarrera 'Facu02','Comunicación Integral'
Execute usp_InsertarCarrera 'Facu02','Fotografía y Producción de Imagen'
Execute usp_InsertarCarrera 'Facu03','Marketing y Gestión de Moda'
Execute usp_InsertarCarrera 'Facu03','Marketing'
Execute usp_InsertarCarrera 'Facu03','Publicidad y Medios Digitales'
Execute usp_InsertarCarrera 'Facu03','Gestión Comercial y Negocios Digitales'
Execute usp_InsertarCarrera 'Facu04','Administración de Empresas'
Execute usp_InsertarCarrera 'Facu04','Negocios Internacionales'
Execute usp_InsertarCarrera 'Facu04','Administración y Finanzas'
Execute usp_InsertarCarrera 'Facu04','Recursos Humanos'
Execute usp_InsertarCarrera 'Facu04','Administración Bancaria'
Execute usp_InsertarCarrera 'Facu04','Gestión Logística Integral'
Execute usp_InsertarCarrera 'Facu05','Desarrollo de Software'
Execute usp_InsertarCarrera 'Facu05','Redes y Comunicaciones'
Execute usp_InsertarCarrera 'Facu05','Sistemas de Información'
Execute usp_InsertarCarrera 'Facu06','Hotelería'
Execute usp_InsertarCarrera 'Facu06','Turismo'
 
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


-- Agregar Datos a la Tabla Local
-- ===============================
insert into TB_local (IdCent,Desloc,Dirloc) values ('SI','Local de San Isidro','Av. Sanchez Carrión 285')
insert into TB_local (IdCent,Desloc,Dirloc) values ('LM','Local de La Molina','Av. La Fontana 955')
insert into TB_local (IdCent,Desloc,Dirloc) values ('MI','Local de Miraflores','Av. Benavides 778')
insert into TB_local (IdCent,Desloc,Dirloc) values ('RM','Local remoto','Aula virtual')
insert into TB_local (IdCent,Desloc,Dirloc) values ('MD','Local de Magdalena','Jr, Jirón Jose Galvez 386')
insert into TB_local (IdCent,Desloc,Dirloc) values ('LN','Local de Lima norte',' Av Industrial 3458, San Martín de Porres 15311')

-- Agregar Datos a la Tabla TB_Espc_Prof
-- ===============================
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(1,'Desarrollo de sistemas')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(2,'Seguridad Informatica')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(3,'Programacion')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(4,'Robotica')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(5,'Base de datos')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(6,'Big data')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(7,'Servidores')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(8,'Iot')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(9,'Desarrollo de aplicacioens en Cloud')
Insert into TB_Espc_Prof (IdEspc,DesEsc) values(10,'Desarrollo movidles')
 
-- Agregar Datos a la Tabla Alumno
-- ===============================
EXECUTE USP_INSERTARALUMNO 'ALEXANDRA JULIETH','LOPEZ','SHAPIAMA','60121975','Facu05','140102','F'
EXECUTE USP_INSERTARALUMNO 'ALEXANDRA CAROLINE','BENDEZU','SEIJAS','70202922','Facu05','140103','F'
EXECUTE USP_INSERTARALUMNO 'PAOLA JACKELINE','GUARDALES','QUEZADA','59842369','Facu05','140125','F'
EXECUTE USP_INSERTARALUMNO 'SUSAN INGRID','MENDO','BEZADA','81840471','Facu05','140104','F'
EXECUTE USP_INSERTARALUMNO 'NICOLE MIRELLA','PLAZA','HIDALGO','92900341','Facu05','140105','F'
EXECUTE USP_INSERTARALUMNO 'GABRIELA MIRANDA','SALAZAR','LEDESMA','94941620','Facu05','140107','F'
EXECUTE USP_INSERTARALUMNO 'FABIO CESAR','SILVA','GONZALES','38160300','Facu05','140108','M'
EXECUTE USP_INSERTARALUMNO 'KAREN LILIANA','REYES','ROMERO','54568430','Facu05','140133','F'
EXECUTE USP_INSERTARALUMNO 'LIZ MARY','TICONA','RAMOS','34184084','Facu05','140133','F'
EXECUTE USP_INSERTARALUMNO 'LESLY LUZMILA','CANALES','GALVEZ','16397541','Facu05','140106','F'
EXECUTE USP_INSERTARALUMNO 'ANDY NESTOR','TUFINO','MALPARTIDA','47622648','Facu05','140135','M'
EXECUTE USP_INSERTARALUMNO 'MARIANA YOSELIN','HUAYNATE','MIRAMIRA','76344220','Facu05','140134','F'
EXECUTE USP_INSERTARALUMNO 'FRANCISCO PABLO','VILLACORTA','PONCE','97614497','Facu05','140110','M'
EXECUTE USP_INSERTARALUMNO 'JULISSA STEFANYA','QUISPE','PEREZ','31607096','Facu05','140109','F'
EXECUTE USP_INSERTARALUMNO 'FERNANDA MADELEIN','RIVERA','GARCÍA','57794067','Facu05','140101','F'
EXECUTE USP_INSERTARALUMNO 'CESAR AUGUSTO','PEREDA','RAMIREZ','84855224','Facu05','140111','M'
EXECUTE USP_INSERTARALUMNO 'MARIA DEL CARMEN','RODRIGUEZ','PALOMINO','83438408','Facu05','140142','F'
EXECUTE USP_INSERTARALUMNO 'JOSE LUIS','DEJO','WONG','44838283','Facu05','140116','M'
EXECUTE USP_INSERTARALUMNO 'ARTURO MARIO','RAMIREZ','SANCHEZ','45142009','Facu05','140114','M'
EXECUTE USP_INSERTARALUMNO 'JORGE LUIS','TORRES','AHEN','27562726','Facu05', '140112','M'
EXECUTE USP_INSERTARALUMNO 'CAMILA','CUEVA','VITERI','78164851','FACU05','140112','F'


-- Agragar Datos a la Tabla TB_Profesor
-- =================================
 
Execute usp_InsertarProfesor 'DAVID ENRIQUE','ALLASI','BARDALES','71493503','dallasib@gmail.com','M','140109'
Execute usp_InsertarProfesor 'NORVIL ANTONIO','ARCE','SÁNCHEZ','13056023','narces@gmail.com','M','140103'
Execute usp_InsertarProfesor 'ITALO DAVID','RAMOS','LING','08421861','italoramos@gmail.com','M','140101'  
Execute usp_InsertarProfesor 'DANIEL FRANCISCO','SAKAMOTO','ORTEGA','56140614','dsakamoto@gmail.com','M','140106'
Execute usp_InsertarProfesor 'ANDRES ALEKSANDAR MILUTIN','VILLAR','BOJOVIC','02902488','avillarb@gmail.com','M','140110'  
Execute usp_InsertarProfesor 'ANDRES JOSE','NUÑEZ','SANCHEZ','57916305','josesanchez@gmail.com','M','140109'  
Execute usp_InsertarProfesor 'AZUCENA PAOLA','QUIROGA', 'FARRO','33962873','paolafarro@gmail.com','F','140111'
Execute usp_InsertarProfesor 'EVELIN DOLORES','VINCES','LOPEZ','68704612','evenlinlopez@gmail.com','F','140112'
Execute usp_InsertarProfesor 'CARLI ESTHER','QUIROZ','PACAYA','07903683','estherquiroz@gmail.com','F','140105'
Execute usp_InsertarProfesor 'PRISCILA CECILIA','RENTERIA','PEREZ','13052847','priscilaperez@gmail.com','F','140114'
Execute usp_InsertarProfesor 'WENDY ROSY','CHUMPITAZ','CHAVEZ','80841236','wendychavez@gmail.com','F','140117'
Execute usp_InsertarProfesor 'ANDREA GABRIELA','EVANGELISTA','ROSAS','20359729','andrearosas@gmail.com','F','140120'
Execute usp_InsertarProfesor 'GILBERTO ALEXIS','DIAZ',' RODRÍGUEZ','20947531','alexisdiaz@gmail.com','M','140102'
Execute usp_InsertarProfesor 'RAUL MANUEL','ARANDA',' VICENTE','70095888','manuelvicente@gmail.com','M','140130'
Execute usp_InsertarProfesor 'TATIANA NAHOMI','LAGOS',' CUSICHI','81729332','nahomilagos@gmail.com','F','140122'
Execute usp_InsertarProfesor 'ERICSSON HANS','CRUZ',' ZAPATA','13877827','hanszapata@gmail.com','M','140140' 	 
Execute usp_InsertarProfesor 'ABIGAIL ANA','RAMIREZ',' CRUZ','02013171','anacruz@gmail.com','F','140143'	 
Execute usp_InsertarProfesor 'HENRY WILLIAN','MILLA',' CHIPANA','93953444','henrymilla@gmail.com','M','140129' 
Execute usp_InsertarProfesor 'LUIGGI','VILLACORTA',' GUZMAN','91030463','luiggiguzman@gmail.com','M','140125' 
Execute usp_InsertarProfesor 'MARIAJOSE','RATTO',' ALVARADO','73448499','mariaalvarado@gmail.com','F','140141'
Execute usp_InsertarProfesor 'RODRIGO GABRIEL','PALMA',' POMA','96608344','rodrigopoma@gmail.com','M','140127' 
Execute usp_InsertarProfesor 'JENIFER','NAJARRO',' JANAMPA','03161596','jenifernajarro@gmail.com','F','140138'
Execute usp_InsertarProfesor 'LESLY DIANA','RODRIGUEZ',' DIAZ','20723655','leslydiaz@gmail.com','F','140126'
Execute usp_InsertarProfesor 'MEYLI ESTEFANIA','ALFARO','ARAOZ','83263318','estefaniaaraoz@gmail.com','F','140113'


 