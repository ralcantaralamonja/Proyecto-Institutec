<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="WebMantCarrera.aspx.cs" Inherits="SitioWEB_InstitutecGUI.Matenimientos.WebMantCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            width: 199px;
        }

        .auto-style3 {
            width: 391px;
        }

        .auto-style5 {
            margin-left: 0px;
            margin-top: 0px;
        }
        .auto-style6 {
            height: 73px;
        }
        .auto-style7 {
            height: 8px;
        }
        .auto-style8 {
            height: 12%;
        }
        .auto-style9 {
            height: 8px;
            width: 68%;
        }
        .auto-style10 {
            width: 68%
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center-container">
        <div class="container">
            <h2> MATENIMIENTO CARRERA </h2>
            <asp:Button ID="btnNuevo" class="btn btn-primary" runat="server" Text="NUEVA CARRERA" OnClick="btnNuevo_Click" />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="INGRESE CARRERA:"></asp:Label>
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
                <asp:GridView ID="grvCarrera" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True" PageSize="15" AutoGenerateColumns="False" OnPageIndexChanging="grvCarrera_PageIndexChanging" OnRowCommand="grvCarrera_RowCommand" EnableTheming="False" OnRowDataBound="grvCarrera_RowDataBound" BorderStyle="Outset" BorderColor="#333333" BorderWidth="2px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Image" CommandName="Editar" Text="Editar" ImageUrl="~/images/Editar.png" />
                        <asp:BoundField DataField="CodCar" HeaderText="ID" />
                        <asp:BoundField DataField="DesCar" HeaderText="CARRERA" />
                        <asp:BoundField DataField="DesFac" HeaderText="FACULTAD" />
                        <asp:BoundField DataField="Est_carr" HeaderText="ESTADO" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#0d6efd" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#0d6efd" Font-Bold="True" ForeColor="White" BorderColor="#0D6EFD" BorderStyle="Solid" />
                    <PagerStyle BackColor="#0d6efd" ForeColor="White" HorizontalAlign="Left" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>            <%--Panel cuyo contenido se mostrara en el ModalPopup de Insercion--%>            <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>
            <asp:LinkButton ID="lnkPopup1" runat="server"></asp:LinkButton>
            <%--Panel cuyo contenido de mostrara en el ModalPopup de Edicion--%>
            <asp:Panel ID="PanelMan1" runat="server" align="center" Style="display: table" Width="700">
                <table style="border: Solid 3px #0d6efd; height: 308px;"
                    cellpadding="0" cellspacing="0" class="auto-style6">
                    <tr style="background-color: #0d6efd">
                        <td colspan="2" style="color: White; font-weight: bold; font-size: larger"
                            align="center" class="auto-style8">Nueva Carrera</td>
                    </tr>
                    <tr style="background-color: white">
                        <td class="auto-style7"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        <td class="auto-style7"></td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="center" class="">Ingrese Nueva Carrera:
                        </td>
                        <td align="center" class="">
                            <asp:TextBox ID="txtRS1" runat="server" Width="350px" CssClass="TextBox" />
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="center" class="auto-style11">Seleccione Facultad:</td>
                        <td align="center">
                            <asp:DropDownList ID="cboFacultad1" runat="server" Width="350px" AutoPostBack="True" OnSelectedIndexChanged="cboFacultad1_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="center" class="auto-style11">Estado:</td>
                        <td align="center">
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
                            <asp:Button ID="btnGrabar1" class="btn btn-primary" runat="server" Text="Grabar" Width="100px" OnClick="btnGrabar1_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="btnCerrar1" class="btn btn-primary" runat="server" Text="Cancelar" Width="100px" />
                        </td>
                    </tr>
                </table>

            </asp:Panel>
            <%--Modalpopup extender PopMan01 para el edicion de registros: vease el TargetControl que apunta al linkbutton  lnkPopup2 y el PopupcontrolID que apunta al panel PanelMan2--%>
            <ajaxToolkit:ModalPopupExtender ID="PopMan01" TargetControlID="lnkPopup1"
                PopupControlID="PanelMan1" runat="server" BackgroundCssClass="modal-overlay">
            </ajaxToolkit:ModalPopupExtender>


            <%--Panel cuyo contenido de mostrara en el ModalPopup de Edicion--%>
            <asp:Panel ID="PanelMan2" runat="server" align="center" CssClass="CajaDialogo" Style="display: table" Width="700">
                <br />
                <asp:LinkButton ID="lnkPopup2" runat="server"></asp:LinkButton>
                <ajaxToolkit:ModalPopupExtender ID="PopMan3" runat="server" BackgroundCssClass="FondoAplicacion" PopupControlID="PanelMan2" TargetControlID="lnkPopup2">
                </ajaxToolkit:ModalPopupExtender>
                <table cellpadding="0" cellspacing="0" style="border: Solid 3px #0d6efd; height: 308px;">
                    <tr style="background-color: #0d6efd">
                        <td align="center" colspan="2" style="height: 12%; color: White; font-weight: bold; font-size: larger">Actualizar Carrera </td>
                    </tr>
                    <tr style="background-color: white">
                        <td class="auto-style9"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        <td class="auto-style7"></td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="center" class="auto-style10" colspan="1">
                            <asp:Label ID="lblEtiquetaCod" runat="server" Text="Codigo:"></asp:Label>
                        </td>
                        <td align="center">
                            <asp:Label ID="lblCod" runat="server" CssClass="labelTitulo"></asp:Label>
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="center" class="auto-style10">Nombre Carrera: </td>
                        <td align="center">
                            <asp:TextBox ID="txtRS2" runat="server" CssClass="TextBox" Width="350px" />
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="center" class="auto-style10">Facultad :</td>
                        <td align="center">
                            <asp:DropDownList ID="cboFacultad2" runat="server" AutoPostBack="True" Width="300px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td align="center" class="auto-style10">Estado:</td>
                        <td align="lefcentert">
                            <asp:CheckBox ID="chkEstado2" runat="server" CssClass="labelTitulo" Text="Activo" />
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td colspan="2">
                            <asp:Label ID="lblMensaje2" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                        </td>
                    </tr>
                    <tr style="background-color: white">
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style1">
                            <asp:Button ID="btnGrabar2" runat="server" class="btn btn-primary" Text="Grabar" Width="100px" OnClick="btnGrabar2_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnCerrar2" runat="server" class="btn btn-primary" Text="Cancelar" Width="100px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>

           <%--Modalpopup extender PopMan02 para el edicion de registros: vease el TargetControl que apunta al linkbutton  lnkPopup2 y el PopupcontrolID que apunta al panel PanelMan2--%> 
             <ajaxToolkit:ModalPopupExtender ID="PopMan02" TargetControlID="lnkPopup2" 
                 PopupControlID="PanelMan2" runat="server" BackgroundCssClass="modal-overlay"></ajaxToolkit:ModalPopupExtender>

            <%-- El panel cuyo contenido se mostrara en el ModalPopup de mensajes--%>            <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>
            <asp:LinkButton ID="lnkMensaje" runat="server"></asp:LinkButton>
            <%-- El panel cuyo contenido se mostrara en el ModalPopup de mensajes--%>
            <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500">
                <table border="0" style="margin: 0px; padding: 0px; background-color: #0d6efd; color: #0d6efd;" width="500px">
                    <tr>
                        <td align="center">
                            <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" />
                        </td>
                        <td class="auto-style1" width="12%">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="Right" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" />
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

            <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>
            <ajaxToolkit:ModalPopupExtender ID="PopMensaje" TargetControlID="lnkMensaje"
                PopupControlID="pnlMensaje" runat="server" BackgroundCssClass="modal-overlay">
            </ajaxToolkit:ModalPopupExtender>

        </div>
    </div>
</asp:Content>
