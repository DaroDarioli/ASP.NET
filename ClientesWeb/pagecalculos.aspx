<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pagecalculos.aspx.cs" Inherits="pagecalculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; border: 1px solid #cccccc">
        <tr>
            <td colspan="4"><h1>Calculo</h1></td>
        </tr>
        <tr>
            <td rowspan="3" style="width: 131px">
                <asp:RadioButtonList ID="rdbcalculos" runat="server">
                    <asp:ListItem Value="1">Suma</asp:ListItem>
                    <asp:ListItem Value="2">Resta</asp:ListItem>
                    <asp:ListItem Value="3">Producto</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>Valor 1:
                <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
            </td>
            <td>Valor 2:
                <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
            </td>
            <td>Resultado:<asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calcular" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

