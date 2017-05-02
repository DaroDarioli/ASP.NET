<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pageCliente.aspx.cs" Inherits="pageCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; border: 1px solid #cccccc">
        <tr>
            <td colspan="3">Clientes</td>
        </tr>
        <tr>
            <td rowspan="5" style="width: 115px">
                <img alt="cliente" longdesc="imagencliente" src="images.jpg" style="width: 188px; height: 172px" /></td>
            <td>Id Cliente</td>
            <td>
                <asp:TextBox ID="txtcliente" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                <asp:DropDownList ID="drpclientes" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceClientes" DataTextField="nombre" DataValueField="idcliente" OnSelectedIndexChanged="drpclientes_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceClientes" runat="server" ConnectionString="<%$ ConnectionStrings:clientesConnectionString %>" SelectCommand="SELECT [idcliente], [nombre] FROM [cliente]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>Nombre</td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Dirección</td>
            <td>
                <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Teléfono</td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblestado" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Height="22px" OnClick="btnEliminar_Click" style="margin-top: 0px" Text="Eliminar" />
            </td>
        </tr>
    </table>
</asp:Content>

