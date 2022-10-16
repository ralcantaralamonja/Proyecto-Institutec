 USE MASTER 
--Elimando la base de datos por si fue creada
IF EXISTS ( SELECT name FROM sysdatabases WHERE name = 'InstituTec' )
	DROP DATABASE InstituTec
USE MASTER --redirigiendo a la master para crear base de datos
--DROP  DATABASE InstituTec
GO
CREATE DATABASE InstituTec -- creando la base de datos
ON PRIMARY --definiendo archivo main
(	
	NAME             =  TESTEO_MDF, 
	FILENAME     = 'D:\Databases\InstituTec.mdf', 
	SIZE               = 5 MB, 
	MAXSIZE        = 200, 
	FILEGROWTH = 5)
LOG ON --definiendo archivo de logs
(	
	NAME				  = TESTEO_LOGS, 
	FILENAME		  = 'D:\Databases\InstituTec_Log.ldf',
	SIZE				  = 1MB, 
	MAXSIZE		  = 100, 
	FILEGROWTH = 1MB)
GO

USE InstituTec --Usando la base de datos

GO
--Creando tablas

Create Table TB_Profesor(
IdProf char(4) NOT NULL,
Ndocum char(8) NOT NULL,
NomPro varchar(50) NOT NULL,
ApePat varchar(50) NOT NULL,
ApeMat varchar(50) NOT NULL,
CorPer varchar(50) NOT NULL,
CorIns varchar(50),
TelPro char(9) DEFAULT '999999999',
FecNac date ,
SexPro char(1),
FecIng date,
Estado bit DEFAULT 1,
Id_Ubigeo char (12),
IdEspc tinyint NOT NULL
--Especialidad , ¿Si tiene mas de 1 espescialidad?
)

GO

Create Table TB_Espc_Prof(
IdEspc tinyint  NOT NULL,
IdProf char(4) NOT NULL,
DesEsc varchar(60) 
)

GO

Create Table Tb_Seccion(
IdCods char(6) NOT NULL,
IdCurs char(4) NOT NULL,
IdProf char(4) NOT NULL,
Activo bit DEFAULT 1,
Vacant tinyint DEFAULT 30
)

GO

Create Table Tb_Curso(
IdCurs char(4) NOT NULL,
NomCur varchar(50) NOT NULL,
Activo bit default 1,
IdCent char(2) NOT NULL,
CodCar char(4) NOT NULL

)

GO

Create Table Tb_Carrera(
CodCar char(4) NOT NULL,
IdFacu char(6) NOT NULL,
DesCar varchar(50) NOT NULL
)

GO

Create Table TB_Matricula(
IdMatr char(4) NOT NULL,
IdSeme char(7) NOT NULL,
CodCar char(4) NOT NULL,
IdAlum char(4) NOT NULL,

FecMat Date default getdate(),
IdPeri tinyint NOT NULL
)

GO

Create table TB_local(
IdCent char(2) NOT NULL,
Desloc varchar(50),
Dirloc varchar(50)
)

GO

Create table TB_Alumno(
IdAlum char(4) NOT NULL,
Ndocum char(8) NOT NULL,
IdMatr char(4) NOT NULL,
NamAlu varchar(50) NOT NULL,
LasAlu varchar(50) NOT NULL,
TelAlu char(9) NOT NULL,
CorAlu varchar(50),
Estado bit default 1,
SexAlu char(1),
FecNac date,
IdFacu char(6) NOT NULL,
Id_Ubigeo char(12) NOT NULL
)

GO

Create table Tb_Ubigeo(

Id_Ubigeo char(12) NOT NULL,
IdDepa varchar (100),
IdProv varchar (100),
IdDist varchar (100),
Departamento varchar (100),
Provincia varchar (100),
Distrito varchar (100)

)


GO

Create table TB_Aula(
IdAula char(2) NOT NULL,
IdCent char(2) NOT NULL,
AfoAul tinyint DEFAULT 30,
Habita bit default 1,
DesAlu varchar(50),
)

GO

Create Table TB_Facultad(
IdFacu char(6) NOT NULL,
CodCar char(4) NOT NULL,
DesFac varchar(50)
)

GO

Create Table TB_Horario(
IdCods char(6) NOT NULL,
IdCurs char(4) NOT NULL,
Horari char(5)
)

GO

Create Table TB_Semestre(
IdSeme char(7) NOT NULL,
Descrp varchar(50),
FecInc date,
FecFin date 
)

GO
--Creando Primary Key.

ALTER TABLE TB_Semestre 
ADD CONSTRAINT PK_TB_Semestre
PRIMARY KEY (IdSeme)

GO

ALTER TABLE TB_Horario 
ADD CONSTRAINT PK_TB_Horario
PRIMARY KEY (IdCods,Idcurs)

GO

ALTER TABLE TB_Facultad 
ADD CONSTRAINT PK_TB_Facultad
PRIMARY KEY (IdFacu)

GO

ALTER TABLE TB_Aula 
ADD CONSTRAINT PK_TB_Aula
PRIMARY KEY (IdAula)

GO

ALTER TABLE TB_local 
ADD CONSTRAINT PK_TB_local
PRIMARY KEY (IdCent)

GO

ALTER TABLE TB_Matricula 
ADD CONSTRAINT PK_TB_Matricula
PRIMARY KEY (IdMatr)

GO

ALTER TABLE TB_Profesor 
ADD CONSTRAINT PK_TB_Profesor
PRIMARY KEY (IdProf)

GO

ALTER TABLE TB_Espc_Prof 
ADD CONSTRAINT PK_TB_Espc_Prof  
PRIMARY KEY (IdEspc) 

GO

ALTER TABLE Tb_Seccion 
ADD CONSTRAINT PK_Tb_Seccion  
PRIMARY KEY (IdCodS,IdCurs)

GO

ALTER TABLE Tb_Curso 
ADD CONSTRAINT PK_Tb_Curso 
PRIMARY KEY (IdCurs)

GO

ALTER TABLE Tb_Carrera 
ADD CONSTRAINT PK_Tb_Carrera 
PRIMARY KEY (CodCar)

GO

ALTER TABLE TB_Alumno 
ADD CONSTRAINT PK_TB_Alumno
PRIMARY KEY (IdAlum)

GO

ALTER TABLE TB_Ubigeo
ADD CONSTRAINT PK_TB_Ubigeo
PRIMARY KEY (Id_Ubigeo)

--Creando Foreign Key

/*
La tabla TB_Profesor tiene como campo
IdProf que es llave primaria en la tabla TB_Ubigeo_Prof
*/

ALTER TABLE TB_Profesor 
ADD CONSTRAINT FK_ubgProf
FOREIGN KEY (Id_Ubigeo)  
REFERENCES TB_Ubigeo

GO
/*
La tabla Tb_Seccion tiene como campo
IdProf que es llave primaria en la tabla TB_Profesor
*/
ALTER TABLE Tb_Seccion 
ADD CONSTRAINT FK_SecProf
FOREIGN KEY (IdProf)  
REFERENCES TB_Profesor 

GO
/*
La tabla TB_Profesor tiene como campo
IdEspc que es llave primaria en la tabla TB_Espc_Prof
*/
ALTER TABLE TB_Profesor    
ADD CONSTRAINT FK_Esp_Prof
FOREIGN KEY (IdEspc)  
REFERENCES  TB_Espc_Prof

GO
/*
La tabla TB_Seccion tiene como campo
idcurs que es llave primaria en la tabla tb_curso
*/
ALTER TABLE TB_Seccion    
ADD CONSTRAINT FK_Cur_Sec
FOREIGN KEY (IdCurs)  
REFERENCES  Tb_Curso
 
GO
/*
La tabla Tb_Curso tiene como campo
CodCar que es llave primaria en la tabla Tb_Carrera
*/
ALTER TABLE Tb_Curso
ADD CONSTRAINT FK_Asi_Car
FOREIGN KEY (CodCar)  
REFERENCES  Tb_Carrera

GO
/*
La tabla TB_Matricula tiene como campo
CodCar que es llave primaria en la Tb_Carrera
*/
ALTER TABLE TB_Matricula    
ADD CONSTRAINT FK_Mat_Car
FOREIGN KEY (CodCar)  
REFERENCES  Tb_Carrera

GO
/*
La tabla TB_Curso tiene como campo
IdCent que es llave primaria en la XXXX
*/
ALTER TABLE TB_Curso     
ADD CONSTRAINT FK_LocCur
FOREIGN KEY (IdCent)  
REFERENCES  Tb_Local 

GO
/*
La tabla TB_Alumno tiene como campo
IdAlum que es llave primaria en la Tb_Ubigeo_Alum
*/
ALTER TABLE TB_Alumno   
ADD CONSTRAINT FK_UbgAlu
FOREIGN KEY (Id_Ubigeo)  
REFERENCES  Tb_Ubigeo

GO

/*
La tabla TB_Alumno tiene como campo
XXX que es llave primaria en la XXXX
*/
ALTER TABLE  TB_Alumno    
ADD CONSTRAINT FK_Alum_Matri 
FOREIGN KEY (IdMatr)  
REFERENCES  TB_Matricula

GO

/*
La tabla TB_Alumno tiene como campo
CodCar que es llave primaria en la Tb_Carrera
*/
ALTER TABLE TB_Alumno  
ADD CONSTRAINT FK_Car_Alum 
FOREIGN KEY (IdFacu)  
REFERENCES  Tb_Facultad 

GO

/*
La tabla TB_Aula tiene como campo
IdCent que es llave primaria en la Tb_Local
*/
ALTER TABLE TB_Aula   
ADD CONSTRAINT FK_Loc_Aula 
FOREIGN KEY (IdCent)  
REFERENCES  Tb_Local 

GO

/*
La tabla TB_Horario tiene como campo
IdCods que es llave primaria en la Tb_Seccion
*/
ALTER TABLE TB_Horario     
ADD CONSTRAINT FK_Hor_Sec
FOREIGN KEY (IdCods,Idcurs)  
REFERENCES  Tb_Seccion

GO

/*
La tabla TB_Carrera tiene como campo
IdFacu que es llave primaria en la TB_Facultad

*/

ALTER TABLE TB_Carrera    
ADD CONSTRAINT FK_Fac_Car 
FOREIGN KEY (IdFacu)  
REFERENCES  TB_Facultad 

GO

/*
La tabla TB_Matricula tiene como campo
IdSeme que es llave primaria en la XXXX
*/
ALTER TABLE   TB_Matricula   
ADD CONSTRAINT FK_Mat_Sem
FOREIGN KEY (IdSeme)  
REFERENCES TB_Semestre


-- plantilla
/*
La tabla XXXX tiene como campo
XXX que es llave primaria en la XXXX

ALTER TABLE      
ADD CONSTRAINT FK_ 
FOREIGN KEY ( )  
REFERENCES  Tb_ 
*/

 

/*


Create Table TB_Pago(
)
Create Table TB_Detalle_De_Matricula(
IdSeme char(7) NOT NULL,
)
Create Table TB_User(
)
Create Table TB_Auditoria (
)
*/