<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="WebMantCurso.aspx.cs" Inherits="SitioWEB_InstitutecGUI.Mantenimientos.WebMantCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .modal-overlay {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-color: rgba(0, 0, 0, 0.5); /* Opacidad del 50% en el fondo */
            z-index: 1000; /* Ajusta el valor del z-index según sea necesario para que el fondo aparezca por encima del resto del contenido */
        }

        .auto-style1 {
            width: 80%;
        }
        .auto-style2 {
            width: 154px;
        }
        .auto-style3 {
            width: 391px;
        }
        .auto-style4 {
            margin-left: 40px;
        }

        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style11 {
            width: 36%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">

    <div class="center-container">
        <div class="container">
            <h2>
                MATENIMIENTO CURSO
            </h2>

            <asp:Button ID="btnNuevo" class="btn btn-primary" runat="server" Text="NUEVO CURSO" OnClick="btnNuevo_Click" />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="INGRESE CURSO:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtFiltro" runat="server" Width="390px"></asp:TextBox>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnFiltrar" class="btn-success" runat="server" Text="FILTRAR" OnClick="btnFiltrar_Click" />
                    </td>
                </tr>
            </table>

            <br />
            <div class="container">
                <asp:GridView ID="grvCurso" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True" OnPageIndexChanging="grvCurso_PageIndexChanging" OnRowDataBound="grvCurso_RowDataBound" PageSize="15" AutoGenerateColumns="False" OnRowCommand="grvCurso_RowCommand" BorderColor="#333333" BorderStyle="Solid" BorderWidth="2px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Image" CommandName="Editar" Text="Editar" ImageUrl="~/images/Editar.png" />
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="Facultad" HeaderText="FACULTAD" />
                        <asp:BoundField DataField="Carrera" HeaderText="CARRERA" />
                        <asp:BoundField DataField="CodCar" HeaderText="COD CAR" />
                        <asp:BoundField DataField="Curso" HeaderText="CURSO" />
                        <asp:BoundField DataField="Activo" HeaderText="ACTIVO" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#0d6efd" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#0d6efd" ForeColor="White" HorizontalAlign="Left" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>

            <%--Control Target del ModalPopup de Insercion--%>          
            <%--Panel cuyo contenido se mostrara en el ModalPopup de Insercion--%>            
            <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>
            <asp:LinkButton ID="lnkPopup1" runat="server"></asp:LinkButton>
            <%--Panel cuyo contenido se mostrara en el ModalPopup de Insercion--%>
            <asp:Panel ID="PanelMan1" runat="server" align="center" Style="display: table" Width="700">
                                <table style="border: Solid 3px #0d6efd; height: 308px;"
                                cellpadding="0" cellspacing="0" class="auto-style6">
                                    <tr style="background-color: #0d6efd">
                                        <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                                            align="center">Nuevo Curso
                                        </td>
                                    </tr>
                                    <tr style="background-color: white">
                                        <td class="auto-style11">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr style="background-color: white">
                                        <td align="right" class="auto-style11">Ingrese Nuevo Curso:
                                        </td>
                                        <td align="left">
                                            <asp:TextBox ID="txtRS1" runat="server" Width="350px" CssClass="TextBox" />
                                        </td>
                                    </tr>
                                    <tr style="background-color: white">
                                        <td align="right" class="auto-style11">Seleccione Carrera:</td>
                                        <td align="left">
                                            <asp:DropDownList ID="cboCarrera1" runat="server" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="cboCarrera1_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr style="background-color: white">
                                        <td align="right" class="auto-style11">Estado:</td>
                                        <td align="left">
                                            <asp:CheckBox ID="chkEstado1" runat="server" CssClass="labelTitulo" Text="Activo" />
                                        </td>
                                    </tr>
                                    <tr style="background-color: white">
                                        <td colspan="2">
                                            <asp:Label ID="lblMensaje1" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                                        </td>
                                    </tr>

                                    <tr style="background-color: white">
                                        <td class="auto-style11">&nbsp;</td>
                                        <td class="auto-style1">
                                            <asp:Button ID="btnGrabar1" runat="server" Text="Grabar" Width="100px" class="btn btn-primary" OnClick="btnGrabar1_Click" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="btnCerrar1" runat="server" Text="Cancelar" Width="100px" class="btn btn-primary" />
                                        </td>
                                    </tr>
                                </table>


            </asp:Panel>
            <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>
            <ajaxToolkit:ModalPopupExtender ID="PopMan01" TargetControlID="lnkPopup1"
                PopupControlID="PanelMan1" runat="server" BackgroundCssClass="modal-overlay">
            </ajaxToolkit:ModalPopupExtender>


                         <%--Panel cuyo contenido de mostrara en el ModalPopup de Edicion--%>
       <asp:Panel ID="PanelMan2" runat="server" CssClass="CajaDialogo" align="center" Style="display:table" Width="700">
            <br />
            <asp:LinkButton ID="lnkPopup2" runat="server"></asp:LinkButton>
            <ajaxToolkit:ModalPopupExtender ID="PopMan3" runat="server" BackgroundCssClass="FondoAplicacion" PopupControlID="PanelMan2" TargetControlID="lnkPopup2">
            </ajaxToolkit:ModalPopupExtender>
            <table style="border: Solid 3px #0d6efd; height: 308px;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: #0d6efd">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Actualizar Curso
                    </td>
                </tr>
                <tr style="background-color: white">
                    <td align="right" style="width: 45%" class="labelContenido">
                        &nbsp;</td>
                      <td align="left">
                          &nbsp;</td>
                </tr>
                <tr style="background-color: white">
                    <td align="right" class="labelContenido" style="width: 45%">
                        <asp:Label ID="lblEtiquetaCod" runat="server" Text="Codigo:"></asp:Label>
                    </td>
                    <td align="left">
                        <asp:Label ID="lblCod" runat="server" CssClass="labelTitulo"></asp:Label>
                    </td>
                </tr>
               <tr style="background-color: white">
                    <td align="right" class="labelContenido">
                        Nombre del Cursol:
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtRS2" runat="server" Width="350px" CssClass="TextBox" />
                    </td>
                </tr>
                     <tr style="background-color: white">
                         <td align="right" class="labelContenido">Carrera:</td>
                         <td align="left">
                             <asp:DropDownList ID="cboCarrera2" runat="server" Width="300px" AutoPostBack="True">
                             </asp:DropDownList>
                         </td>
                  </tr>
                  <tr style="background-color: white">
                      <td align="right" class="labelContenido">Estado:</td>
                      <td align="left">
                          <asp:CheckBox ID="chkEstado2" runat="server" CssClass="labelTitulo" Text="Activo" />
                      </td>
                  </tr>
                     <tr style="background-color: white">
                         <td colspan="2">
                             <asp:Label ID="lblMensaje2" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                         </td>
                     </tr>
                     <tr style="background-color: white">
                         <td class="auto-style1">
                             &nbsp;</td>
                         <td class="auto-style1">
                             <asp:Button ID="btnGrabar2" runat="server" Text="Grabar" Width="100px" class="btn btn-primary" OnClick="btnGrabar2_Click" />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="btnCerrar2" runat="server"  Text="Cancelar" Width="100px" class="btn btn-primary" />
                         </td>
                     </tr>
              
            </table>
        </asp:Panel>
       <%--Modalpopup extender PopMan02 para el edicion de registros: vease el TargetControl que apunta al linkbutton  lnkPopup2 y el PopupcontrolID que apunta al panel PanelMan2--%> 
             <ajaxToolkit:ModalPopupExtender ID="PopMan02" TargetControlID="lnkPopup2" 
                 PopupControlID="PanelMan2" runat="server" BackgroundCssClass="modal-overlay"></ajaxToolkit:ModalPopupExtender>


            <%--CONFIGURACION DEL MODALPOPUP DE MENSAJES --%>
            <%--Control target para el ModalPopup de mensajes--%>
            <asp:LinkButton ID="lnkMensaje" runat="server"></asp:LinkButton>
            <%-- El panel cuyo contenido se mostrara en el ModalPopup de mensajes--%>
            <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500">
                <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color: #0d6efd; color: #FFFFFF;">
                    <tr>
                        <td align="center">
                            <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" />
                        </td>
                        <td width="12%" class="auto-style1">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;"
                                ImageAlign="Right" />
                        </td>
                    </tr>
                </table>
                <div style="background-color: white;">
                    <asp:Label ID="lblMensajePopup" runat="server" ForeColor="Black" CssClass="labelTitulo" />
                </div>
                <div style="background-color: white;">
                    <br />
                </div>
                <div style="background-color: white;">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn btn-primary" />
                </div>
                <div style="background-color: white;">
                    <br />
                </div>
            </asp:Panel>
            <%--El ModalPopup  PopMensaje que hace referencia al ID del control target  (TargetControlID="lnkMensaje")
                    y al ID al panel (PopupControlID="pnlMensaje")--%>
            <ajaxToolkit:ModalPopupExtender ID="PopMensaje"
                TargetControlID="lnkMensaje"
                PopupControlID="pnlMensaje" runat="server" BackgroundCssClass="modal-overlay">
            </ajaxToolkit:ModalPopupExtender>
        </div>
    </div>
</asp:Content>
