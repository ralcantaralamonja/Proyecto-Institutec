<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="SitioWEB_InstitutecGUI.inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/5.3.0/css/bootstrap.min.css">
    <style>
        body {
            background-color: #f8f9fa;
            display: flex;
            flex-direction: column;
            min-height: 100vh;
            margin: 0;
        }

        .navbar {
            background-color: #007bff;
            color: #fff;
        }

        .content {
            flex: 1;
            padding-bottom: 60px; /* Agregamos un padding inferior para dejar espacio para el footer */
        }

        .footer {
            background-color: #6c757d;
            color: #fff;
            text-align: center;
            padding: 10px 0;
            position: fixed;
            bottom: 0;
            width: 100%;
        }

        .btn-primary,
        .btn-secondary {
            margin-bottom: 10px;
        }

        .sub-buttons {
            display: none;
        }

        input[type="checkbox"]:checked + .sub-buttons {
            display: flex;
            flex-direction: column;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg navbar-dark">
        <div class="container">
            <a class="navbar-brand mx-auto" href="#">INSTITUTEC</a>
        </div>
    </nav>

    <!-- Contenido principal -->
    <div class="d-flex flex-column flex-grow-1">
        <main class="container mt-4">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <table class="table table-bordered">
                        <tbody>
                            <tr>
                                <td>Consultas</td>
                                <td>
                                    <asp:Button ID="bntConsultaAlumno" runat="server" Text="Consulta Alumnos" CssClass="btn btn-primary btn-block" OnClick="bntConsultaAlumno_Click" />
                                    <asp:Button ID="btnConsultaProfesor" runat="server" Text="Consulta Profesores" CssClass="btn btn-primary btn-block" OnClick="btnConsultaProfesor_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td>Consultas Gráficas</td>
                                <td>
                                    <asp:Button ID="btnConsultaGrafGeneros" runat="server" Text="Géneros por Carrera" CssClass="btn btn-primary btn-block" OnClick="btnConsultaGrafGeneros_Click" />
                                    <asp:Button ID="btnConsultaGrafSeccion" runat="server" Text="Matriculados por Sección" CssClass="btn btn-primary btn-block" OnClick="btnConsultaGrafSeccion_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td>Mantenimientos</td>
                                <td>
                                    <asp:Button ID="btnMantCarrera" runat="server" Text="Matenmiento Carrera" CssClass="btn btn-primary btn-block" OnClick="btnMantCarrera_Click" />
                                    <asp:Button ID="btnMantCurso" runat="server" Text="Matenimiento Curso" CssClass="btn btn-primary btn-block" OnClick="btnMantCurso_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td>Matricular</td>
                                <td>
                                    <asp:Button ID="btnMatricular" runat="server" Text="Matricular Alumno" CssClass="btn btn-primary btn-block" OnClick="btnMatricular_Click" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </main>

        <!-- Footer -->
        <footer class="footer">
            <div class="container">
                Elaborado por: <br />
                -Alcantara Ricardo <br />
                -Fernandez Ambar <br />
                -Gonzales Orlando
            </div>
        </footer>
    </div>

    <!-- Bootstrap JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
</asp:Content>
