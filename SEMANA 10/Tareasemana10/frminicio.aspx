<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frminicio.aspx.cs" Inherits="Tareasemana10.frminicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="ButtonCargar" runat="server" Height="33px" Text="CARGAR ARCHIVO" OnClick="ButtonCargar_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="SQL"></asp:Label>
        </p>
        <p>
        <asp:Button ID="ButtonNombre" runat="server" Text="NOMBRE" OnClick="ButtonNombre_Click" />
        <asp:TextBox ID="TextBoxNB" runat="server" Width="191px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBoxNB2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonCorrelativo" runat="server" Text="CORRELATIVO" OnClick="ButtonCorrelativo_Click" />
            <asp:TextBox ID="TextBoxCR" runat="server"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBoxCR2" runat="server" Width="303px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="MYSQL"></asp:Label>
        </p>
        <asp:Button ID="ButtonNombreM" runat="server" OnClick="ButtonNombreM_Click" Text="NOMBRE" />
        <asp:TextBox ID="TextBoxNB3" runat="server" Width="190px"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBoxNB4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonCorrelativoM" runat="server" OnClick="ButtonCorrelativoM_Click" Text="CORRELATIVO" />
            <asp:TextBox ID="TextBoxCR3" runat="server"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBoxCR4" runat="server" Width="311px"></asp:TextBox>
    </form>
</body>
</html>
