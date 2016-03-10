<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NovaProjectWeb.Pages.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nova Project </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblMensagem"></asp:Label>
        <br />
        Login<asp:TextBox runat="server" ID="login"></asp:TextBox>
        <br />
        Senha<asp:TextBox runat="server" ID="password" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="btnLogar" Text="Logar" OnClick="btnLogar_Click" />
    </div>
    </form>
</body>
</html>
