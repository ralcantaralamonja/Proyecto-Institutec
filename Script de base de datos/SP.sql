-- Primer SP de consulta
/*
Este Store procedure pide un parametro de entrada que
es el id del curso (un char(4)), y retorna los alumnos 
matriculados del curso consultado
*/

CREATE OR ALTER PROCEDURE usp_alum_matri_cur
@IdCurso char(4)
 
AS
IF (@IdCurso IS NULL)
	BEGIN
		PRINT 'Id del curso no ingresado'
		RETURN 1
	END
BEGIN TRANSACTION 
Select 
Alu.ApeAlumno,Alu.NomAlumno
From TB_Alumno AS Alu 
INNER JOIN TB_Matricula AS Mat ON Alu.IdAlumno=Mat.IdAlumno
INNER JOIN TB_CursoProgramado AS Cup ON Mat.IdCursoProg=Cup.IdCursoProg
INNER JOIN TB_Curso AS Cur ON  Cur.IdCurso=Cup.IdCurso
where Cur.IdCurso = @IdCurso
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
Este Store procedure pide un parametro de entrada que
es el id del profesor (un char(4)), y retorna los cursos 
que dicta un profesor
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