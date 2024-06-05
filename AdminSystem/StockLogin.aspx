<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 11px; top: 48px; position: absolute; height: 24px; width: 138px" Text="Stock Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" height="19px" style="z-index: 1; left: 175px; top: 147px; position: absolute; width: 82px" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" height="19px" style="z-index: 1; left: 175px; top: 187px; position: absolute; width: 82px" Text="Password:"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" height="26px" OnClick="btnLogin_Click" style="z-index: 1; left: 279px; top: 255px; position: absolute; width: 60px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 363px; top: 255px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 263px; top: 187px; position: absolute; width: 185px" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtUserName" runat="server" height="22px" style="z-index: 1; left: 265px; top: 146px; position: absolute" width="185px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 490px; top: 170px; position: absolute; height: 19px"></asp:Label>
    </form>
</body>
</html>
