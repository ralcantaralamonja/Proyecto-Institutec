<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ConsultaAlumno.aspx.cs" Inherits="SitioWEB_InstitutecGUI.Consultas.ConsultaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CONSULTA DE ALUMNO - CURSOS / SEMESTRE </title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">

    <link rel="stylesheet" href="../CSS/style.css">
 
</head>
<body>
  
        
    <div class="center-containerAlumno" >
        <asp:ScriptManager ID="ScriptManager1" 
                               runat="server" />

        <div runat="server" class="container form-container">
            <h2 class="tituloConsul" >Consulta Alumno: Cursos por Semestre </h2>
            <div >
                <div  class="form-group">
                    <label  class="auto-style1">Ingrese Codigo del Alumno:</label>
                    <asp:TextBox ID="txtCod" class="form-control" runat  ="server"  ></asp:TextBox>

                </div>

                <asp:Button class="btn btn-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" OnClientClick="btnBuscar_Click" />

            </div>
            <br />
         
            <div id="resultado">
                <h3>Datos del Alumno:</h3>

                <div class="form-group">
                    <label >DNI:</label>
                    <asp:TextBox class="form-control" id="txtDni" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label >Nombre y Apellidos:</label>
                    <asp:TextBox class="form-control" id="txtnombreApell" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label>Telefono:</label>
                    <asp:TextBox class="form-control" ID="txtTel" runat="server" ReadOnly="True"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label>Correo Institucional:</label>
                    <asp:TextBox class="form-control" ID="txtCorreo" runat="server" ReadOnly="True"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label >Estado:</label>
                    <asp:TextBox class="form-control" id="txtEstado" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label >Ubigeo:</label>
                    <asp:TextBox class="form-control" id="txtUbigeo" runat="server" ReadOnly="True"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label>Carrera:</label>
                    <asp:TextBox class="form-control" ID="txtCarrera" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Facultad:</label>
                    <asp:TextBox class="form-control" ID="txtFacultad" runat="server" ReadOnly="True"></asp:TextBox>
                </div>

                <br />
                <br />

                <div class="form-group">
                    <h6>INGRESE FECHAS DE CONSULTA (* Obligatorios):</h6>
                    
                    <asp:Label ID="Label1" runat="server" Text="Fecha 1: 02/01/2023 al 02/04/2023"></asp:Label><br />
                    <asp:Label ID="Label2" runat="server" Text="Fecha 2: 27/04/2023 al 24/08/2023"></asp:Label><br />
                    <asp:Label ID="Label3" runat="server" Text="Fecha 3: 27/08/2023 al 23/12/2023"></asp:Label>
                </div>
                

                <div class="form-group">
                    <div>Fecha inicio (*):</div>
                    <div>
                        <asp:TextBox ID="txtFecIni" runat="server"  Width="100px"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="txtFecIni_CalendarExtender" runat="server" BehaviorID="txtFecIni_CalendarExtender" TargetControlID="txtFecIni" />
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red"  ControlToValidate="txtFecIni" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </div>
                    <div>Fecha fin (*):</div>
                    <div>
                        <asp:TextBox ID="txtFecFin" runat="server"  Width="100px"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="txtFecFin_CalendarExtender" runat="server" BehaviorID="txtFecFin_CalendarExtender" TargetControlID="txtFecFin" />
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red"  ControlToValidate="txtFecFin" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>

            <asp:Button class="btn btn-success" ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click1" OnClientClick="btnConsultar_Click1" />
            
        </div>
    </div>
    <br />
    

<div class="form-grid">
    <asp:Label ID="lblRegistros" runat="server" class="cantidadCursos"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="grvConsuAlum" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="NomCur" HeaderText="Nombre Curso"></asp:BoundField>
            <asp:BoundField DataField="Activo" HeaderText="Estado Curso"></asp:BoundField>
            <asp:BoundField DataField="DIA" HeaderText="Dia"></asp:BoundField>
            <asp:BoundField DataField="HorIni" HeaderText="Hora Inicio">
                <ItemStyle HorizontalAlign="Right"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="HorFin" HeaderText="Hora Fin">
                <ItemStyle HorizontalAlign="Right"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Desloc" HeaderText="Local"></asp:BoundField>
            <asp:BoundField DataField="IdAula" HeaderText="Aula"></asp:BoundField>
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
