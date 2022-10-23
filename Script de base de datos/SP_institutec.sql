/*STORE PROCEDURE INSERTA UN ALUMNO CON LOS CAMPOS OBLIGATORIOS Y CREA LA
LLAVE PRIMARYA CORRELACIONAL*/

CREATE PROCEDURE usp_InsertarAlumno
@NamAlu varchar(100),  
@ApePat varchar(50),
@ApeMat varchar(50),
@Ndocum char(8),
@IdFacu char(6),
@Id_Ubi varchar(20),
@Sexoal	char(1),
@FecNac	date =NULL, 	
@CorAlu	varchar	(50) = NULL,
@TelAlu	char(9)=NULL
AS  
declare @IdAlum char(4)  
declare @cont int  
set @cont=(Select count(*) from TB_Alumno)  
if @cont=0   
       set @IdAlum ='A001'  
else  
        set @IdAlum=(Select 'A' +Right(Max (Right(IdAlum,3)+ 1001 ),3)   
    From TB_Alumno)  
	 
insert into TB_Alumno(IdAlum,NomAlu,ApePat,ApeMat,Ndocum,IdFacu,Id_Ubi,Sexoal,FecNac,CorAlu,TelAlu) values
			(@IdAlum,@NamAlu,@ApeMat,@ApeMat,@Ndocum,@IdFacu,@Id_Ubi,@Sexoal,@FecNac,@CorAlu,@TelAlu)   
GO

/*STORE PROCEDURE INSERTA UN PROFESOR CON LOS CAMPOS OBLIGATORIOS Y CREA LA
LLAVE PRIMARYA CORRELACIONAL*/
CREATE PROCEDURE usp_InsertarProfesor
@NomPro varchar(100),  
@ApePat varchar(50),
@ApeMat varchar(50),
@Ndocum char(8),
@CorPer varchar(50),
@Sexopr char(1),
@Id_Ubi char(6),
@CorIns	varchar(50) =NULL,
@TelPro	char(9) =NULL,
@FecNac	date =NULL,
@FecIng	date =NULL
AS  
declare @IdProf char(4)  
declare @cont int  
set @cont=(Select count(*) from TB_Profesor)  
if @cont=0   
       set @IdProf ='P001'  
else  
        set @IdProf=(Select 'P' +Right(Max (Right(IdProf,3)+ 1001 ),3)   
    From TB_Profesor)  
	 
insert into TB_Profesor(IdProf,NomPro,ApePat,ApeMat,Ndocum,CorPer,Sexopr,Id_Ubi,CorIns,TelPro,FecNac,FecIng) values(@IdProf,@NomPro,@ApePat,@ApeMat,@Ndocum,@CorPer,@Sexopr,@Id_Ubi,@CorIns,@TelPro,@FecNac,@FecIng) 

GO

/*STORE PROCEDURE INSERTA UNa CARRERA CON LOS CAMPOS OBLIGATORIOS Y CREA LA
LLAVE PRIMARYA CORRELACIONAL*/

CREATE PROCEDURE usp_InsertarCarrera
@IdFacu char(6),
@DesCar varchar(50)
AS  
declare @CodCar char(4)  
declare @cont int  
set @cont=(Select count(*) from TB_Carrera)  
if @cont=0   
       set @CodCar ='CA01'  
else  
        set @CodCar=(Select 'CA' +Right(Max (Right(CodCar,2)+ 1001 ),2)   
    From TB_Carrera)  
	 
insert into Tb_Carrera(CodCar,IdFacu,DesCar) values(@CodCar,@IdFacu,@DesCar)   

GO

/*Esta vista permite ver que carrera facultad pertenece cada carrera*/
Create View VW_Facultad_Carrera
as
Select 
Car.CodCar 'Codigo',
Car.DesCar 'Carrera',
Facu.DesFac 'Facultad'
From Tb_Carrera as Car INNER JOIN TB_Facultad as Facu on Facu.IdFacu = Car.IdFacu

GO

/*Esta vista permite ver lso distritos y su ubigeo*/

Create view VW_verDistrito
as
Select Id_ubi, distri from Tb_Ubigeo

GO

/*Vista de facultades del instituto*/

Create View VW_Facultad
as
Select * from TB_Facultad