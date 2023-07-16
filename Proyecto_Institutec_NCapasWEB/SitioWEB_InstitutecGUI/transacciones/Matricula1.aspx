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
    <h1> MATRICULAR ALUMNO </h1>
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblDni" runat="server" Text="Dni :" ></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDni" runat="server" MaxLength="8" oninput="validarNumeros(this)"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre Completo :"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtNombre" runat="server" ReadOnly="True" Width="355px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblCarrera" runat="server" Text="Carrera :"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCarrera" runat="server" Height="24px" ReadOnly="True" Width="355px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblMensajeError" runat="server" EnableTheming="False"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblExito" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnConsulta" runat="server" Text="Consultar" class="btn-primary" OnClick="btnDatos_Click"/>
    <asp:Button ID="btnMatricular" runat="server" Text="Ver cursos" class="btn-secondary" />
    <br />
    <br />
</asp:Content>

 