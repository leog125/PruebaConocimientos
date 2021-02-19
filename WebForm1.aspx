<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PruebaConocimiento.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Id a consultar: "></asp:Label>
            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            <asp:Button ID="btnbuscar" runat="server" Text="Buscar" OnClick="btnbuscar_Click"/>
            <asp:Label ID="lbeconsulta" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <table>
                <tr><td><asp:Label ID="lbnombre" runat="server"></asp:Label></td></tr>
                <tr><td><asp:Label ID="lbapellido" runat="server"></asp:Label></td></tr>
                <tr><td><asp:Label ID="lbtelefono" runat="server"></asp:Label></td></tr>
                <tr><td><asp:Label ID="lbfecha" runat="server"></asp:Label></td></tr>
            </table>
            
        </div>
    </form>
</body>
</html>
