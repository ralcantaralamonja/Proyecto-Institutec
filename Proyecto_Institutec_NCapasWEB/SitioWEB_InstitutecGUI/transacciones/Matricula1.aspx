<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Matricula1.aspx.cs" Inherits="SitioWEB_InstitutecGUI.transacciones.Matricula1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            width: 150px;
        }
        .auto-style3 {
            width: 1075px;
        }
        .auto-style4 {
            width: 150px;
            height: 26px;
        }
        .auto-style5 {
            width: 1075px;
            height: 26px;
        }

        .auto-style6 {
            width: 150px;
            height: 25px;
        }

        .auto-style7 {
            width: 1075px;
            height: 25px;
        }
    </style>
    <script src="../JS/main.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="center-container">
    <div class="container">
        <h2 class="text-center">MATRICULAR ALUMNO</h2>

        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="table-responsive">
                    <table class="table table-bordered">
                        <tr>
                            <td class="text-right">
                                <asp:Label ID="lblDni" runat="server" Text="Dni :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDni" runat="server" MaxLength="8" oninput="validarNumeros(this)" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="text-right">
                                <asp:Label ID="lblNombre" runat="server" Text="Nombre Completo :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtNombre" runat="server" ReadOnly="True" Width="100%" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="text-right">
                                <asp:Label ID="lblCarrera" runat="server" Text="Carrera :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCarrera" runat="server" Height="24px" ReadOnly="True" Width="100%" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>

                <br />
                <asp:Label ID="lblMensajeError" runat="server" EnableTheming="False"></asp:Label>
                <br />
                <asp:Label ID="lblExito" runat="server"></asp:Label>
                <br />
                <div class="text-center">
                    <asp:Button ID="btnConsulta" runat="server" Text="Consultar" CssClass="btn btn-primary" OnClick="btnDatos_Click" />
                    <asp:Button ID="btnMatricular" runat="server" Text="Ver cursos" CssClass="btn btn-secondary" OnClick="btnMatricular_Click" />
                </div>
                <br />
            </div>
        </div>

        <div class="row justify-content-center">
            <div class="col-md-12">
                <asp:GridView ID="grvCursos" runat="server" CssClass="table table-bordered">
                    <Columns>
                        <asp:BoundField />
                    </Columns>
                </asp:GridView>
                <br />
                <br />
            </div>
        </div>
    </div>
</div>

</asp:Content>

 