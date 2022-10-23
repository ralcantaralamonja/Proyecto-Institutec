USE MASTER 
--Elimando la base de datos por si fue creada
IF EXISTS ( SELECT name FROM sysdatabases WHERE name = 'InstituTec' )
	DROP DATABASE InstituTec
GO

CREATE DATABASE InstituTec -- creando la base de datos
ON PRIMARY --definiendo archivo main
(	
	NAME             =  InstituTec_MDF, 
	FILENAME     = 'TU RUTA\InstituTec.mdf', 
	SIZE               = 5 MB, 
	MAXSIZE        = 200, 
	FILEGROWTH = 5)
LOG ON --definiendo archivo de logs
(	
	NAME				  = InstituTec_LOGS, 
	FILENAME		  = 'TU RUTA\InstituTec_Log.ldf',
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
NomPro varchar(100) NOT NULL,
ApePat varchar(50) NOT NULL,
ApeMat varchar(50) NOT NULL,
CorPer varchar(50) NOT NULL,
CorIns varchar(50),
TelPro char(9) DEFAULT '999999999',
FecNac date ,
Sexopr char (1) NOT NULL,
FecIng date,
Estado bit DEFAULT 1,
Id_Ubi char (6) NOT NULL
)

GO

Create table TB_Alumno(
IdAlum char(4) NOT NULL,
Ndocum char(8) NOT NULL,
IdFacu char(6) NOT NULL,
NomAlu varchar(100) NOT NULL,
ApePat varchar(50) NOT NULL,
ApeMat varchar(50) NOT NULL,
TelAlu char(9) DEFAULT '999999999',
CorAlu varchar(50),
Estado bit default 1,
Sexoal char(1) NOT NULL,
FecNac date,
Id_Ubi char(6) NOT NULL
)


GO

Create Table TB_Espc_Prof(
IdEspc tinyint NOT NULL, 
DesEsc varchar(60)  
)

GO

Create Table TB_Det_Espc(
IdEspc tinyint NOT NULL,   
IdProf char(4) 

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
NroMat char(7) NOT NULL,
IdSeme char(7) NOT NULL,
EstMat tinyint NOT NULL,
CodCar char(4) NOT NULL,
IdAlum char(4) NOT NULL,
FecMat Date default getdate()
)

GO

Create Table TB_Estado_Matricula(
EstMat tinyint NOT NULL,
DesEst varchar (50)
)

GO

Create table TB_local(
IdCent char(2) NOT NULL,
Desloc varchar(50),
Dirloc varchar(50)
)

GO

Create table Tb_Ubigeo(

Id_Ubi char(6) NOT NULL,
IdDepa varchar (2),
IdProv varchar (2),
IdDist varchar (2),
Depart varchar (100),
Provin varchar (100),
Distri varchar (100)

)

GO

Create Table TB_Detalle_De_Matricula(
NroMat char(7) NOT NULL,
IdSeme char(7) NOT NULL,
IdAlum char(4) NOT NULL

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

