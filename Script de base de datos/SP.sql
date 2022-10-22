/*STORE PROCEDURE INSERTA UN ALUMNO CON LOS CAMPOS OBLIGATORIOS Y CREA LA
LLAVE PRIMARYA CORRELACIONAL*/
use institutec
go




ALTER PROCEDURE usp_InsertarAlumno
@NamAlu varchar(30),  
@LasAlu varchar(30),
@Ndocum char(8),
@IdFacu char(6),
@Id_Ubi varchar(20),
@Idsexo	bit,
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
	 
insert into TB_Alumno(IdAlum,NamAlu,LasAlu,Ndocum,IdFacu,Id_Ubi,Idsexo,FecNac,CorAlu,TelAlu) values(@IdAlum,@NamAlu,@LasAlu,@Ndocum,@IdFacu,@Id_Ubi,@Idsexo,@FecNac,@CorAlu,@TelAlu)   
GO


/*Esta vista permite ver que carrera facultad pertenece cada carrera*/
 View VW_Facultad_Carrera
as
Select 
Car.CodCar 'Codigo',
Car.DesCar 'Carrera',
Facu.DesFac 'Facultad'
From Tb_Carrera as Car INNER JOIN TB_Facultad as Facu on Facu.IdFacu = Car.IdFacu


/*Esta vista permite ver lso distritos y su ubigeo*/

Create view VW_verDistrito
as
Select Id_ubi, distri from Tb_Ubigeo


/*Vista de facultades del instituto*/

Create View VW_Facultad
as
Select * from TB_Facultad


/*Vista que muestra los sexos*/
Create view VW_sexo
as
Select * from TB_SEXO








--**********************************************************************************************


-- SP de consulta
/*
Este Store procedure retorna los alumnos matriculados del curso 
consultado y con el profesor pide 2 parametros de entrada que
es el id del curso (un char(4)) y id del profesor (char()4),

*/

CREATE OR ALTER PROCEDURE usp_alum_matri_cur
@IdCurso char(4),@IdProfesor char(4)
 
AS
IF (@IdCurso IS NULL)
	BEGIN
		PRINT 'Id del curso no ingresado'
		RETURN 1
	END
IF(@IdProfesor IS NULL)
	BEGIN
		PRINT 'Ide del profesor no fue ingresado'
		RETURN 2
	END
BEGIN TRANSACTION 
Select 
Alu.ApeAlumno,Alu.NomAlumno
From TB_Alumno AS Alu 
INNER JOIN TB_Matricula AS Mat ON Alu.IdAlumno=Mat.IdAlumno
INNER JOIN TB_CursoProgramado AS Cup ON Mat.IdCursoProg=Cup.IdCursoProg
INNER JOIN TB_Profesor AS Prof ON Cup.IdProfesor=Prof.IdProfesor
INNER JOIN TB_Curso AS Cur ON  Cur.IdCurso=Cup.IdCurso
where Cur.IdCurso = @IdCurso AND Prof.IdProfesor =@IdProfesor
ORDER BY Alu.ApeAlumno
IF @@ERROR <> 0
BEGIN
	PRINT 'ERROR'
	ROLLBACK TRANSACTION
	RETURN 2
END
COMMIT TRANSACTION
	RETURN 0 
go

/*Compruebe*/

/*
DECLARE @IdCurso CHAR(4)
SET @IdCurso ='C003'
Execute usp_alum_matri_cur @IdCurso
*/


--Segundo SP de consulta 
/*
Este Store procedure retorna los cursos 
que dicta un profesor pide un parametro de entrada que
es el id del profesor (un char(4)), y 
*/

CREATE OR ALTER PROCEDURE usp_cur_dic_pro
@IdProfesor char(4)
 
AS
IF (@IdProfesor IS NULL)
	BEGIN
		PRINT 'Id del curso no ingresado'
		RETURN 1
	END
BEGIN TRANSACTION 
Select 
Cur.NomCurso,
Cup.Horario
from TB_Curso AS Cur
INNER JOIN TB_CursoProgramado AS Cup ON Cur.IdCurso=Cup.IdCurso
WHERE Cup.IdProfesor = @IdProfesor
IF @@ERROR <> 0
BEGIN
	PRINT 'ERROR'
	ROLLBACK TRANSACTION
	RETURN 2
END
COMMIT TRANSACTION
	RETURN 0 
	go

/*Compruebe*/

/*
DECLARE @IdProfesor CHAR(4)
SET @IdProfesor ='P003'
Execute usp_cur_dic_pro @IdProfesor
*/

/*Este Sp busca matricular un alumno a un curso
valida que no se ingresen valores nulos
que el curso esta programado
que el alumno este registrado
que halla vacantes
que este activo
luego le resta 1 a la vacante 
luego ingresa al alumno
*/


CREATE OR ALTER PROCEDURE usp_MatriculaAlumno
	@cursoprog char(6), @idalumno CHAR(5)	
AS
	DECLARE @vacantes TINYINT
	DECLARE @activo BIT
IF (@cursoprog IS NULL)		OR 
	(@idalumno IS NULL)	
	BEGIN
		PRINT 'VALOR NULO'
		RETURN 1
	END
IF NOT EXISTS(SELECT idcursoprog FROM Tb_cursoprogramado 
                            WHERE idcursoprog = @cursoprog)
	BEGIN
		PRINT 'ESTE CURSO NO ESTA PROGRAMADO'
		RETURN 2
	END
IF NOT EXISTS(SELECT apealumno + ', ' + nomalumno FROM Tb_alumno 
                            WHERE IDALUMNO = @idalumno)
	BEGIN
		PRINT 'EL ALUMNO NO ESTA REGISTRADO'
		RETURN 3
	END
SELECT @vacantes = vacantes, @activo = activo FROM Tb_cursoprogramado 
                WHERE idcursoprog = @cursoprog
	IF @vacantes = 0
	BEGIN
		PRINT 'YA NO HAY VACANTES PARA ESTE CURSO'
		RETURN 4
	END
	IF @activo = 0
	BEGIN
		PRINT 'EL CURSO YA NO ESTA ACTIVO'
		RETURN 5
	END
	BEGIN TRAN
		UPDATE Tb_CursoProgramado
		SET vacantes = vacantes -1, matriculados = matriculados + 1  
		            WHERE idcursoprog = @cursoprog
		INSERT INTO Tb_matricula (idcursoprog,idalumno,fecmatricula)
		                         VALUES (@cursoprog,@idalumno,GETDATE())
		IF @@ERROR <> 0
		BEGIN
			PRINT ' ERROR EN LA BD'
			ROLLBACK TRAN
			RETURN 6
		END
	COMMIT TRAN
	RETURN 0
	
/*Elimina al alumno del curso pide de parametro 
id de idCursoProg , el id del alumno*/

CREATE OR ALTER PROCEDURE usp_ret_alum
@IdCursoProg char(6),@IdAlumno char(5)
AS
IF (@IdCursoProg IS NULL)
	BEGIN
		PRINT 'Id de matricula no ingresado'
		RETURN 1
	END
IF (@IdAlumno IS NULL)
	BEGIN
		PRINT 'Id de alumno no ingresado'
		RETURN 2
	END
BEGIN TRANSACTION 
Delete TB_Matricula 
where idCursoProg =@IdCursoProg AND IdAlumno=@IdAlumno
UPDATE Tb_CursoProgramado
		SET vacantes = vacantes +1 , matriculados = matriculados-1
		WHERE idcursoprog = @IdCursoProg
IF @@ERROR <> 0
BEGIN
	PRINT 'ERROR'
	ROLLBACK TRANSACTION
	RETURN 3
END
COMMIT TRANSACTION
	RETURN 0 
	go

/*Crea Sp que desabilita un curso pide de 
parametro el id del curso programado*/


CREATE OR ALTER PROCEDURE usp_inabilitarCurso
@IdCursoProg char(6)
AS
IF (@IdCursoProg IS NULL)
	BEGIN
		PRINT 'Id del curso no ingresado'
		RETURN 1
	END
BEGIN TRANSACTION 
UPDATE Tb_CursoProgramado
		SET activo = 0
		WHERE idcursoprog = @IdCursoProg
IF @@ERROR <> 0
BEGIN
	PRINT 'ERROR'
	ROLLBACK TRANSACTION
	RETURN 2
END
COMMIT TRANSACTION
	RETURN 0 
	go
 
/*Crea Sp que habilita un curso pide de 
parametro el id del curso programado*/

 CREATE OR ALTER PROCEDURE usp_HabilitarCurso
@IdCursoProg char(6)
AS
IF (@IdCursoProg IS NULL)
	BEGIN
		PRINT 'Id del curso no ingresado'
		RETURN 1
	END
BEGIN TRANSACTION 
UPDATE Tb_CursoProgramado
		SET activo = 1
		WHERE idcursoprog = @IdCursoProg
IF @@ERROR <> 0
BEGIN
	PRINT 'ERROR'
	ROLLBACK TRANSACTION
	RETURN 2
END
COMMIT TRANSACTION
	RETURN 0 
	go
 
/*Retorna todos los cursos en los que un alumno esta matriculados
pide de parametro el id del alumno*/
CREATE procedure usp_Ver_CurMat_Alum
@IdAlumno char(6)
AS
Select 
Cur.NomCurso 'Curso',
Prof.ApeProfesor+' '+Prof.NomProfesor 'Profesor',
Curp.Horario
From TB_Alumno AS Alum
INNER JOIN TB_Matricula AS Mat ON Alum.IdAlumno = Mat.IdAlumno
INNER JOIN TB_CursoProgramado AS Curp ON Curp.IdCursoProg = Mat.IdCursoProg
INNER JOIN TB_Profesor AS Prof ON Prof.IdProfesor = Curp.IdProfesor
INNER JOIN TB_Curso AS Cur ON Cur.IdCurso= Curp.IdCurso
where Alum.IdAlumno =@IdAlumno3


/*Crea curso programado con insert*/
CREATE PROCEDURE usp_crearCurso
(
 
@IdCurso char(4) ,
@IdPeriodo char(7), 
@IdProfesor char(4), 
@PreCursoProg money ,
@Horario varchar (24),
@IdCursoProg char(6)='MAT000'
	)
AS
Insert Into TB_CursoProgramado
(IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario,IdCursoProg) 
VALUES
(@IdCurso,@IdPeriodo,@IdProfesor,@PreCursoProg,@Horario,@IdCursoProg)



--Beta crea un correconial de id
CREATE TRIGGER TR_ins_Matricula 
ON Tb_CursoProgramado 
AFTER INSERT  
AS 
BEGIN 
declare @captura varchar(2)
declare @verd char(6) 
declare @IdCursoProg char(6) 
declare @IdCurso char(4) 
declare @IdPeriodo char(7) 
declare @IdProfesor char(4) 
declare @PreCursoProg money 
declare @Horario varchar (24) 
select @captura = (count(*)+1) from TB_CursoProgramado 
SET @captura = convert (char(6),@captura) SET @IdCursoProg  ='MAT00'+@captura 
select @verd =  IdCursoProg FROM inserted 
IF (@verd) = '' 
begin 
Insert Into TB_CursoProgramado (IdCursoProg,IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario) values(@IdCursoProg,@IdCurso,@IdPeriodo,@IdProfesor,@PreCursoProg,@Horario)  end  
end  

--beta 
CREATE TRIGGER TR_ins_Matricula 
ON Tb_CursoProgramado 
AFTER INSERT  
AS 
BEGIN 
declare @captura varchar(2)
declare @verd char(6) 
declare @IdCursoProg char(6) 
declare @IdCurso char(4) 
declare @IdPeriodo char(7) 
declare @IdProfesor char(4) 
declare @PreCursoProg money 
declare @Horario varchar (24) 
select @captura = (count(*)+1) from TB_CursoProgramado
SET @IdCursoProg  =CAST('MAT00'+@captura AS char(6))
select @verd =  IdCursoProg FROM inserted 
IF (@verd) = null
begin 
Insert Into TB_CursoProgramado (IdCursoProg,IdCurso,IdPeriodo,IdProfesor,PreCursoProg,Horario) values(@IdCursoProg,@IdCurso,@IdPeriodo,@IdProfesor,@PreCursoProg,@Horario)  end  
end  
go

-/*Se crea vista que ayuda a saber que profesor dicta un curso*/

Create view VW_CursoDictadoPorProfesor
AS
Select 
prof.ApeProfesor +' '+prof.NomProfesor 'Profesor',
Cur.NomCurso 'Curso',
Curp.Horario,Curp.IdPeriodo 'Periodo',Curp.IdCursoProg 'Id Curso'
from 
TB_Profesor as prof 
INNER JOIN TB_CursoProgramado AS Curp ON Curp.IdProfesor = prof.IdProfesor
INNER JOIN TB_Curso AS Cur ON Curp.IdCurso = Cur.IdCurso
go

-/*Se crea vista que ayuda a saber que curso lleva cada Alumno*/
 Create View VW_VerCursoMatriculadoAlumnos
 AS
 Select 
 Alum.ApeAlumno + ' '+Alum.ApeAlumno  'Alumno',
 Curp.Horario
 From TB_Alumno AS Alum
 INNER JOIN TB_Matricula AS Mat ON Mat.IdAlumno = Alum.IdAlumno
 INNER JOIN TB_CursoProgramado AS Curp ON Curp.IdCursoProg = Mat.IdCursoProg
 
 
/*Se crea vista que muestra costo de cada curso*/
Create VIEW VW_Ver_CostoPorCurso
as
Select  
Cur.IdCurso,Cur.NomCurso,Cur.IdTarifa,
Tarf.PreTarifa
From  TB_Curso AS Cur 
INNER JOIN TB_Tarifa Tarf ON Tarf.IdTarifa = Cur.IdTarifa

/*Se crea vista para ver el nombre del alumno y id*/

Create View VW_VerAlumno
as
Select 
IdAlumno 'ID',ApeAlumno+' '+NomAlumno 'Alumno' 
from TB_Alumno


