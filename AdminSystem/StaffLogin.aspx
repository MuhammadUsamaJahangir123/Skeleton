<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 461px">
    <form id="form1" runat="server">
        <div style="height: 28px">
            <asp:Label ID="lblLoginPage" runat="server" style="z-index: 1; left: 51px; top: 44px; position: absolute" Text="Staff Login Page"></asp:Label>
        </div>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 104px; top: 167px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 105px; top: 211px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 220px; top: 167px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 220px; top: 211px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 470px; top: 191px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 221px; top: 283px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 307px; top: 283px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
