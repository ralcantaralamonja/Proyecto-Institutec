<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="GenerosCarrera.aspx.cs" Inherits="SitioWEB_InstitutecGUI.ConsultasGraficos.GenerosCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .center-grid {
            display: flex;
            justify-content: center;
        }
        .auto-style1 {
            margin-right: 0px;
        }
        .auto-style3 {
            height: 25px;
        }
        .auto-style4 {
            margin-left: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container form-container">
        <h1 class="tituloConsul">Generos por carrera</h1>
        <table class="w-100">
            <tr>
                <td class="auto-style4">

            <asp:GridView ID="gridQuery1" class="form-grid" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AutoGenerateColumns="False" CssClass="auto-style1" Width="732px" Height="52px">
                <Columns>
                    <asp:BoundField DataField="Carrera" HeaderText="Carreras actuales" >
                    <HeaderStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Total" HeaderText="Total de Alumnos">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Hombres" HeaderText="Hombres">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Mujeres" HeaderText="Mujeres">
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
                    </td>
            </tr>
            <tr>
                <br />
                <br />
                <td class="auto-style3">
                        <asp:Chart ID="CantidadHombres" runat="server" Height="317px" Width="969px">
                            <Series>
                                <asp:Series Name="Series1" ChartArea="Hombres">
                                </asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="Hombres">
                                </asp:ChartArea>
                            </ChartAreas>
                            <Titles>
                                <asp:Title BackColor="Silver" Font="Microsoft Sans Serif, 10pt, style=Bold" Name="Title1" Text="Hombres Inscritos ">
                                </asp:Title>
                            </Titles>
                        </asp:Chart>
                    </td>
            </tr>
            <tr>
                <td>
                        <asp:Chart ID="CantidadMujeres" runat="server" Height="317px" Width="971px">
                            <Series>
                                <asp:Series Name="Series1" ChartArea="Hombres">
                                </asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="Hombres">
                                </asp:ChartArea>
                            </ChartAreas>
                            <Titles>
                                <asp:Title BackColor="Silver" Font="Microsoft Sans Serif, 10pt, style=Bold" Name="Title1" Text="Mujeres Inscritas ">
                                </asp:Title>
                            </Titles>
                        </asp:Chart>
                    </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    <br />
    </div>
</asp:Content>
