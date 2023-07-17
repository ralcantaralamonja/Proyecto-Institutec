<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mantricula.aspx.cs" Inherits="SitioWEB_InstitutecGUI.transacciones.Mantricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 77;
        }
        .auto-style2 {
            width: 230px;
        }
        .auto-style3 {
            width: 415px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
            width: 979px;
        }
        .auto-style9 {
            height: 26px;
            width: 115px;
        }
        .auto-style10 {
            width: 576px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center-container">
        <div class="container">
            <h2> MATRICULAR ALUMNO </h2>
             <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        DNI:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtFiltro" runat="server" Width="390px" CssClass="auto-style4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        NOMBRE COMPLETO:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtNombre" runat="server" Width="390px" CssClass="auto-style4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        CARRERA:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtCarrera" runat="server" Width="390px" CssClass="auto-style4"></asp:TextBox>
                    </td>
                </tr>
            </table>


            <br />
           <div class="d-flex justify-content-center align-items-center text-center" style="height: 100vh;">
                <asp:GridView ID="grvCarrera" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="90%" AllowPaging="True" PageSize="15" AutoGenerateColumns="False" EnableTheming="False"  BorderStyle="Outset" BorderColor="#333333" BorderWidth="2px">
                    <AlternatingRowStyle BackColor="White" />
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
            <br />
            <table class="w-100">
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">
                             <asp:Button ID="btnCerrar1" class="btn btn-primary" runat="server" Text="Cancelar" Width="100px" />
                        </td>
                    <td class="auto-style5">&nbsp;&nbsp;
                            <asp:Button ID="btnGrabar1" class="btn btn-primary" runat="server" Text="Grabar" Width="100px"   />
                            &nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <%-- El panel cuyo contenido se mostrara en el ModalPopup de mensajes--%>            <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>
            <asp:LinkButton ID="lnkMensaje" runat="server"></asp:LinkButton>
            <%-- El panel cuyo contenido se mostrara en el ModalPopup de mensajes--%>
            <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500">
                <table class="table" style="margin: 0px; padding: 0px; background-color: #0d6efd; color: #0d6efd;" width="500px">
                    <tr>
                        <td align="center" class="auto-style10">
                            <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" />
                            &nbsp;
                        </td>
                        <td class="text-right" style="vertical-align: middle;">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="Right" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: middle;" />
                        </td>
                    </tr>
                </table>
                <div style="background-color: white;">
                    <asp:Label ID="lblMensajePopup" runat="server" CssClass="labelTitulo" ForeColor="Black" />
                </div>
                <div style="background-color: white;">
                    <br />
                </div>
                <div style="background-color: white;">
                    <asp:Button ID="btnAceptar" runat="server" class="btn btn-primary" Text="Aceptar" />
                </div>
                <div style="background-color: white;">
                    <br />
                </div>
            </asp:Panel>

            <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>
            <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" BackgroundCssClass="modal-overlay" PopupControlID="pnlMensaje" TargetControlID="lnkMensaje">
            </ajaxToolkit:ModalPopupExtender>
            <br />


        </div>
    </div>

</asp:Content>
