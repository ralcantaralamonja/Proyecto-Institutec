USE MASTER
GO
-- DROP DATABASE InstutuTec
--Elimando la base de datos por si fue creada
IF EXISTS ( SELECT name FROM sysdatabases WHERE name = 'InstutuTec' )
	DROP DATABASE InstutuTec
go
--creando la base de datos
CREATE DATABASE InstutuTec
ON PRIMARY
(NAME =  EduTec_Dat, FILENAME='path\InstituTec.mdf', 
 SIZE = 5MB, MAXSIZE = 200, FILEGROWTH = 1 )
LOG ON
(NAME = EduTec_Log, FILENAME ='path\InstituTec.ldf',
 SIZE = 1MB, MAXSIZE = 200, FILEGROWTH= 1MB)
GO
--usando la base de datos creada
USE InstutuTec



-- Creación de las Tablas  
-- -----------------------------------------


CREATE TABLE TB_Alumno (
       IdAlumno             char(5) NOT NULL,
       NomAlumno            varchar(30) NOT NULL,
       ApeAlumno            varchar(30) NOT NULL,
       DisAlumno            varchar(50) NULL,
       TelAlumno            char(12) NULL,
       EmailAlumno          varchar(50) NULL
)
go


CREATE TABLE TB_Periodo(
       IdPeriodo            char(7) NOT NULL,
       FecInicio            datetime NULL,
       FecTermino           datetime NULL
)
go


CREATE TABLE TB_Curso (
       IdCurso             char(4) NOT NULL,
       IdTarifa            char(1) NOT NULL,
       NomCurso            varchar(50) NOT NULL,
	   IdLocal             char(1) NOT NULL
)
go


CREATE TABLE TB_CursoProgramado (
       IdCursoProg          int NOT NULL,
       IdCurso              char(4) NOT NULL,
       IdPeriodo              char(7) NOT NULL,
       IdProfesor           char(4) NULL,
       Vacantes             tinyint NOT NULL DEFAULT 20,
       PreCursoProg         money NOT NULL,
       Horario              varchar(24) NOT NULL,
       Activo               bit DEFAULT 1,
       Matriculados         tinyint NOT NULL DEFAULT 0
)
go


CREATE TABLE TB_Matricula (
       IdCursoProg          int NOT NULL,
       IdAlumno             char(5) NOT NULL,
       FecMatricula         datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
)

go


CREATE TABLE TB_Profesor (
       IdProfesor           char(4) NOT NULL,
       NomProfesor          varchar(30) NOT NULL,
       ApeProfesor          varchar(30) NOT NULL,
       DisProfesor          varchar(50) NULL,
       TelProfesor          varchar(12) NULL,
       EmailProfesor        varchar(50) NULL
)
go


CREATE TABLE TB_Tarifa (
       IdTarifa             char(1) NOT NULL,
       PreTarifa            money NOT NULL,
       Descripcion          varchar(50) NULL
)
go

CREATE TABLE TB_Local (
       IdLocal             char(1) NOT NULL,
       DirLocal           varchar (150) NOT NULL,
       DisLocal            bit DEFAULT 1
)
go

--Creando claves Primarias


ALTER TABLE TB_Alumno 
		ADD CONSTRAINT PK_Alumno 
		PRIMARY KEY(IdAlumno)
 go


ALTER TABLE TB_Periodo
       ADD CONSTRAINT PK_Periodo
	   PRIMARY KEY (IdPeriodo)
go


ALTER TABLE TB_Curso
       ADD CONSTRAINT PK_Curso
	   PRIMARY KEY (IdCurso)
go


ALTER TABLE TB_Tarifa
       ADD CONSTRAINT PK_Tarifa
	   PRIMARY KEY (IdTarifa)
go


ALTER TABLE TB_CursoProgramado
       ADD CONSTRAINT PK_CursoProgramado
	   PRIMARY KEY (IdCursoProg)
go


ALTER TABLE TB_Profesor
       ADD CONSTRAINT PK_Profesor
	   PRIMARY KEY (IdProfesor)
go


ALTER TABLE TB_Matricula
       ADD CONSTRAINT PK_Matricula
	   PRIMARY KEY (IdCursoProg, IdAlumno)
go


ALTER TABLE  TB_Local
		 ADD CONSTRAINT PK_Local
		 PRIMARY KEY (IdLocal)
go


-- Creando Claves Foráneas
-- ---------------------------

ALTER TABLE TB_Curso 
	  ADD CONSTRAINT FK_Curso_Tarifa FOREIGN KEY(IdTarifa) 
							  REFERENCES TB_Tarifa(IdTarifa)
go


ALTER TABLE TB_Curso 
	  ADD CONSTRAINT FK_Curso_Local FOREIGN KEY(IdLocal) 
							  REFERENCES TB_Local(IdLocal)

go


ALTER TABLE TB_CursoProgramado
        ADD CONSTRAINT FK_CursoProgramado_Periodo FOREIGN KEY (IdPeriodo)
                             REFERENCES TB_Periodo(IdPeriodo)
go


ALTER TABLE TB_CursoProgramado
	   ADD CONSTRAINT FK_CursoProgramado_Curso FOREIGN KEY (IdCurso)
                             REFERENCES TB_Curso(IdCurso)
go


ALTER TABLE TB_CursoProgramado
	   ADD CONSTRAINT FK_CursoProgramado_Profesor FOREIGN KEY (IdProfesor)
                             REFERENCES TB_Profesor(IdProfesor)
  
go


ALTER TABLE TB_Matricula
       ADD CONSTRAINT FK_Matricula_CursoProgramado FOREIGN KEY (IdCursoProg)
                             REFERENCES TB_CursoProgramado (IdCursoProg)
go


ALTER TABLE TB_Matricula
   ADD CONSTRAINT FK_Matricula_Alumno FOREIGN KEY (IdAlumno)
                             REFERENCES TB_Alumno (IdAlumno)
      
go



