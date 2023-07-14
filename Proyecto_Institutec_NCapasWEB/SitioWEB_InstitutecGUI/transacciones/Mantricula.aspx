<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mantricula.aspx.cs" Inherits="SitioWEB_InstitutecGUI.transacciones.Mantricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="Text-center">Matricula de Alumnos Institutec</h1>
    
    <asp:GridView ID="grvCursosDisponibles" runat="server"></asp:GridView>

</asp:Content>
