<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MatriculadosSeccion.aspx.cs" Inherits="SitioWEB_InstitutecGUI.ConsultasGraficos.MatriculadosSeccion" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container form-container">
    <h1 class="tituloConsul">Alumnos Matriculados por NRC</h1>
         <br />
         <br />
    <asp:GridView ID="grvQuery2" runat="server" AutoGenerateColumns="False" Width="607px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <Columns>
            <asp:BoundField DataField="NRC" HeaderText="NRC" />
            <asp:BoundField DataField="Curso" HeaderText="Curso" />
            <asp:BoundField DataField="Alumnos" HeaderText="Alumnos Matriculados">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>
         <br />
         <br />
    <asp:Chart ID="CantidadMatriculados" runat="server" Width="795px">
        <series>
            <asp:Series Name="Series1">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </chartareas>
        <Titles>
            <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 12pt, style=Bold" Name="Title1" Text="Alumos Matriculados">
            </asp:Title>
        </Titles>
    </asp:Chart>
    <br />
         </div>
</asp:Content>
