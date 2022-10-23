--Creando Llave unica UK

-- Llave unica para documento de alumnos

ALTER TABLE TB_Alumno	
ADD CONSTRAINT DocAlum	
UNIQUE(Ndocum)

GO

-- Llave unica para documento de profesor

ALTER TABLE TB_Profesor 	
ADD CONSTRAINT DocPro	
UNIQUE(Ndocum)

GO

--Creando Llave primaria PK

--Llave primaria de TB_Semestre es IdSeme 

ALTER TABLE TB_Semestre 
ADD CONSTRAINT PK_TB_Semestre
PRIMARY KEY (IdSeme)

GO

--Llave primaria de TB_ESTADO_MATRICULA es EstMat 

ALTER TABLE TB_ESTADO_MATRICULA 
ADD CONSTRAINT PK_TB_ESTADO_MATRICULA
PRIMARY KEY (EstMat)

GO

--Llave primaria de TB_Horario es IdCods,Idcurs 

ALTER TABLE TB_Horario 
ADD CONSTRAINT PK_TB_Horario
PRIMARY KEY (IdCods,Idcurs)

GO

--Llave primaria de TB_Facultad es IdFacu

ALTER TABLE TB_Facultad 
ADD CONSTRAINT PK_TB_Facultad
PRIMARY KEY (IdFacu)

GO

--Llave primaria de TB_Aula es IdAula

ALTER TABLE TB_Aula 
ADD CONSTRAINT PK_TB_Aula
PRIMARY KEY (IdAula)

GO

--Llave primaria de TB_local es IdCent

ALTER TABLE TB_local 
ADD CONSTRAINT PK_TB_local
PRIMARY KEY (IdCent)

GO

--Llave primaria de TB_Matricula es NroMat

ALTER TABLE TB_Matricula 
ADD CONSTRAINT PK_TB_Matricula
PRIMARY KEY (NroMat)

GO

--Llave primaria de TB_Profesor es IdProf

ALTER TABLE TB_Profesor 
ADD CONSTRAINT PK_TB_Profesor
PRIMARY KEY (IdProf)

GO

--Llave primaria de TB_Espc_Prof es IdEspc
 
ALTER TABLE TB_Espc_Prof 
ADD CONSTRAINT PK_TB_Espc_Prof  
PRIMARY KEY (IdEspc) 

GO
  
--Llave primaria de TB_Det_Espc es IdEspc
 
ALTER TABLE TB_Det_Espc
ADD CONSTRAINT PK_TB_Espc_Profe 
PRIMARY KEY (IdEspc) 

GO
  
--Llave primaria de Tb_Seccion es IdCodS,IdCurs
 
ALTER TABLE Tb_Seccion 
ADD CONSTRAINT PK_Tb_Seccion  
PRIMARY KEY (IdCodS,IdCurs)

GO
  
--Llave primaria de Tb_Curso es IdCurs
 
ALTER TABLE Tb_Curso 
ADD CONSTRAINT PK_Tb_Curso 
PRIMARY KEY (IdCurs)

GO
  
--Llave primaria de Tb_Carrera es CodCar
 
ALTER TABLE Tb_Carrera 
ADD CONSTRAINT PK_Tb_Carrera 
PRIMARY KEY (CodCar)

GO
  
--Llave primaria de TB_Alumno es IdAlum
 
ALTER TABLE TB_Alumno 
ADD CONSTRAINT PK_TB_Alumno
PRIMARY KEY (IdAlum)

GO
  
--Llave primaria de PK_TB_Ubigeo es Id_Ubi
 
ALTER TABLE TB_Ubigeo
ADD CONSTRAINT PK_TB_Ubigeo
PRIMARY KEY (Id_Ubi)

GO
  
--Llave primaria de TB_Detalle_De_Matricula es NroMat,IdSeme
 
ALTER TABLE TB_Detalle_De_Matricula
ADD CONSTRAINT PK_Detalle_De_Matricula
PRIMARY KEY (NroMat,IdSeme)

GO

--Creando Foreign Key

/*
La tabla TB_Detalle_De_Matricula tiene como campo
NroMat que es llave primaria en la tabla TB_Matricula
*/
ALTER TABLE TB_Detalle_De_Matricula 
ADD CONSTRAINT FK_DetMatNum
FOREIGN KEY (NroMat)  
REFERENCES TB_Matricula

GO
/*
La tabla TB_Detalle_De_Matricula tiene como campo
IdSeme que es llave primaria en la tabla TB_Semestre
*/
ALTER TABLE TB_Detalle_De_Matricula 
ADD CONSTRAINT FK_DetMatSem
FOREIGN KEY (IdSeme)  
REFERENCES TB_Semestre

GO
/*
La tabla TB_Profesor tiene como campo
IdProf que es llave primaria en la tabla TB_Ubigeo_Prof
*/
GO

ALTER TABLE TB_Profesor 
ADD CONSTRAINT FK_ubgProf
FOREIGN KEY (Id_Ubi)  
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
La tabla TB_Espc_Prof tiene como campo
IdEspc que es llave primaria en la tabla TB_Espc_Prof
*/
ALTER TABLE TB_Det_Espc    
ADD CONSTRAINT FK_Esp_Profe
FOREIGN KEY (IdProf)  
REFERENCES  TB_Profesor

GO
/*
La tabla TB_Det_Espc tiene como campo
IdProfesor que es llave primaria en la XXXX
*/

ALTER TABLE  TB_Det_Espc    
ADD CONSTRAINT FK_Det_Espci
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
FOREIGN KEY (Id_Ubi)  
REFERENCES  Tb_Ubigeo

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

GO

/*
La tabla TB_Matricula tiene como campo
EstMat que es llave primaria en la XXXX
*/
ALTER TABLE TB_Matricula 
ADD CONSTRAINT FK_Estado_Pago
FOREIGN KEY (EstMat)  
REFERENCES  TB_ESTADO_MATRICULA

GO

/*
La tabla TB_Matricula tiene como campo
IdAlum que es llave primaria en la TB_Alumno
*/
ALTER TABLE TB_Matricula   
ADD CONSTRAINT FK_Mat_Alu 
FOREIGN KEY (IdAlum)  
REFERENCES  Tb_Alumno


/*
Futuras tablas a implementar

Create Table TB_User(

)
Create Table TB_Auditoria (
)

*/

-- plantilla para crear llave foranea
/*
La tabla XXXX tiene como campo
XXX que es llave primaria en la XXXX

ALTER TABLE      
ADD CONSTRAINT FK_ 
FOREIGN KEY ( )  
REFERENCES  Tb_ 
*/