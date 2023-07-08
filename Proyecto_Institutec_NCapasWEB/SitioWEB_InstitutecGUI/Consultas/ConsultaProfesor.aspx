<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ConsultaProfesor.aspx.cs" Inherits="SitioWEB_InstitutecGUI.Consultas.ConsultaProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>
    <!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CONSULTA DE PROFESOR - CURSOS</title>

 
</head>

<body>
 
        
    <div class="center-container" >
        <asp:ScriptManager ID="ScriptManager1" 
                               runat="server" />

        <div runat="server" class="container form-container">
            <h2 class="tituloConsul" >Consulta: Profesor - Cursos</h2>
            <div id="profesor-form" >
                <div  class="form-group">
                    <label  class="auto-style1">Ingrese Codigo del Profesor:</label>
                    <asp:TextBox ID="txtCodi" class="form-control" runat  ="server"></asp:TextBox>

                </div>
                
                <asp:Button class="btn btn-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click1" />
                
            </div>
         
            <div id="resultado">
                <h3>Datos del Profesor:</h3>
                <div class="form-group">
                    <label >DNI:</label>
                    <asp:TextBox class="form-control" id="txtDni" runat="server" ReadOnly="True"  ></asp:TextBox> 
                </div>

                <div class="form-group">
                    <label >Nombre y Apellidos:</label>
                    <asp:TextBox class="form-control" id="txtnombreApell" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>


                <div class="form-group">
                    <label >Estado:</label>
                    <asp:TextBox class="form-control" id="txtEstado" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label >Direccion:</label>
                    <asp:TextBox class="form-control" id="txtDirec" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label >Fecha de Ingreso:</label>
                    <asp:TextBox class="form-control" id="txtFechIngr" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label >Correo Institucional:</label>
                    <asp:TextBox class="form-control" id="txtCorreo" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label >Ubigeo:</label>
                    <asp:TextBox class="form-control" id="txtUbigeo" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                

            </div>

            <asp:Button class="btn btn-success" ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            
        </div>
    </div>
    <br />
    

<div class="form-grid">
    <asp:Label ID="lblRegistros" runat="server" class="cantidadCursos"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="grvConsuProfe" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Nombre Curso" HeaderText="Nombre Curso"></asp:BoundField>
            <asp:BoundField DataField="Estado" HeaderText="Estado Curso"></asp:BoundField>
            <asp:BoundField DataField="D&#237;a" HeaderText="Dia"></asp:BoundField>
            <asp:BoundField DataField="Hora Inicio" HeaderText="Hora Inicio">
                <ItemStyle HorizontalAlign="Right"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Hora Fin" HeaderText="Hora Fin">
                <ItemStyle HorizontalAlign="Right"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Centro" HeaderText="Local"></asp:BoundField>
            <asp:BoundField DataField="Aula" HeaderText="Aula"></asp:BoundField>
        </Columns>

        <FooterStyle BackColor="White" ForeColor="#000066"></FooterStyle>

        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White"></HeaderStyle>

        <PagerStyle HorizontalAlign="Left" BackColor="White" ForeColor="#000066"></PagerStyle>

        <RowStyle ForeColor="#000066"></RowStyle>

        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#007DBB"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#00547E"></SortedDescendingHeaderStyle>
    </asp:GridView>

</div>
<%--Este es el modal popup  que contiene los mensajes --%>
       <%--1 Control target (cualquier control)--%>
       <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 
        
        <%--2 el panel que se mostrara en el popup--%>
        <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500">
            <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color: lightskyblue; color: #FFFFFF;">
                <tr>
                    <td align="center">
                        <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" />
                    </td>
                   
                </tr>

            </table>
            <div>
                <br />
            </div>
            <div>
                <asp:Label ID="lblMensajePopup" runat="server" CssClass="labelTitulo" />
            </div>
            <div>
                <br />
            </div>
            <div>
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CausesValidation="False" class="btn btn-primary" />
            </div>
            <div>
                <br />
            </div>
        </asp:Panel> 

        <%--3 el Modal popup que hace referencia al control target  (1) y al panel (2)--%>
        <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje"
        PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" />


</body>
</html>


</asp:Content>
