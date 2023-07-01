<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaProfesor.aspx.cs" Inherits="SitioWEB_InstitutecGUI.Consultas.ConsultaProfesor" %>

<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario de Profesor</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">

    <link rel="stylesheet" href="../CSS/style.css">
 
</head>

<body>
    <div class="center-container">
        <div class="container form-container">
            <h2>Formulario de Profesor</h2>
            <form id="profesor-form">
                <div class="form-group">
                    <label for="dni" class="auto-style1">DNI:</label>
                    <input type="text" class="form-control" id="dni" placeholder="Ingrese el DNI del profesor">
                </div>
                <button type="submit" class="btn btn-primary" aria-atomic="True">Buscar</button>
            </form>

            <div id="resultado" style="display: none;">
                <h3>Datos del Profesor:</h3>
                <div class="form-group">
                    <label for="nombre">Nombre:</label>
                    <input type="text" class="form-control" id="nombre" disabled>
                </div>
                <div class="form-group">
                    <label for="edad">Edad:</label>
                    <input type="text" class="form-control" id="edad" disabled>
                </div>
                <div class="form-group">
                    <label for="email">Email:</label>
                    <input type="text" class="form-control" id="email" disabled>
                </div>
                <h3>Horarios:</h3>
                <div class="table-responsive">
                    <table class="table">
                        <thead>
                            <tr>
                                <th>Curso</th>
                                <th>Día</th>
                                <th>Hora de inicio</th>
                                <th>Hora de fin</th>
                            </tr>
                        </thead>
                        <tbody id="horarios-body"></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>

</body>
<script src="../JS/main.js"></script>
</html>
