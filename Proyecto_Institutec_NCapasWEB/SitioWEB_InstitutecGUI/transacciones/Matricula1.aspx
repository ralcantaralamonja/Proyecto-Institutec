<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Matricula1.aspx.cs" Inherits="SitioWEB_InstitutecGUI.transacciones.Matricula1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../JS/main.js"></script>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
            height: 27px;
        }
        .auto-style2 {
            height: 27px;
        }
        .auto-style3 {
            text-align: right;
            height: 31px;
        }
        .auto-style4 {
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="container">
        <h2 class="text-center">MATRICULAR ALUMNO</h2>

        <div class="row">
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
                            <td class="auto-style1">
                                <asp:Label ID="lblNombre" runat="server" Text="Nombre Completo :"></asp:Label>
                            </td>
                            <td class="auto-style2">
                                <asp:TextBox ID="txtNombre" runat="server" ReadOnly="True" Width="100%" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label2" runat="server" Text="Codigo de carrera :"></asp:Label>
                            </td>
                            <td class="auto-style2">
                                <asp:TextBox ID="txtCodCarrera" runat="server" ReadOnly="True" Width="100%" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="text-right">
                                <asp:Label ID="Label1" runat="server" Text="Numero de Matricula :"></asp:Label>
                            </td>
                            <td aria-atomic="True">
                                <asp:TextBox ID="txtMatricula" runat="server" ReadOnly="True" Width="100%" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="lblCarrera" runat="server" Text="Carrera :"></asp:Label>
                            </td>
                            <td class="auto-style4">
                                <asp:TextBox ID="txtCarrera" runat="server" Height="24px" ReadOnly="True" Width="100%" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>

                <asp:Label ID="lblShowNRC" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblShowMAT" runat="server"></asp:Label>
                <br />

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <%-- El panel cuyo contenido se mostrara en el ModalPopup de mensajes--%>           
                <asp:LinkButton ID="lnkMensaje" runat="server"></asp:LinkButton>
                <%-- El panel cuyo contenido se mostrara en el ModalPopup de mensajes--%>
                <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500">
                    <table class="table" style="margin: 0px; padding: 0px; background-color: #0d6efd; color: #0d6efd;" width="500px">
                        <tr>
                            <td align="center" class="auto-style10">
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" />
                                &nbsp; </td>
                            <td class="text-right" style="vertical-align: middle;">
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="Right" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: middle;" />
                            </td>
                        </tr>
                    </table>
                    <div style="background-color: white;">
                        <asp:Label ID="lblMensajeError" runat="server" CssClass="labelTitulo" ForeColor="Black" />
                        <asp:Label ID="lblExito" runat="server" CssClass="labelTitulo" ForeColor="Black" />
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

            <%--Modalpopup extender PopMan01 para nuevos registros :vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%>
                <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" BackgroundCssClass="modal-overlay" PopupControlID="pnlMensaje" TargetControlID="lnkMensaje">
                </ajaxToolkit:ModalPopupExtender>

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
                <asp:GridView ID="grvCursos" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1021px" OnSelectedIndexChanged="grvCursos_SelectedIndexChanged" OnRowCommand="grvCursos_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Image" HeaderText="Matricularme" ImageUrl="~/images/Add Green Button.ico" Text="Botón" />
                        <asp:BoundField DataField="NRC" HeaderText="NRC" />
                        <asp:BoundField DataField="Curso" HeaderText="Curso" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Local" HeaderText="Local" />
                        <asp:BoundField DataField="DIA" HeaderText="Dia" />
                        <asp:BoundField DataField="Inicio" HeaderText="Horario Inicio" />
                        <asp:BoundField DataField="Fin" HeaderText="Horario Fin" />
                        <asp:BoundField DataField="Vacant" HeaderText="Vacante" />
                        <asp:BoundField DataField="Profesor" HeaderText="Profesor" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <br />
                <br />
            </div>
        </div>
    </div>
</div>

</asp:Content>

 