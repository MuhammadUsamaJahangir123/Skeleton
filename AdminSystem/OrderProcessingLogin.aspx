<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingLogin.aspx.cs" Inherits="OrderProcessingLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblHeading" runat="server" style="z-index: 1; left: 13px; top: 44px; position: absolute" Text="Order Processing Login Page"></asp:Label>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 88px; top: 112px; position: absolute" Text="UserName:"></asp:Label>
        </p>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 165px; top: 113px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 91px; top: 157px; position: absolute; height: 19px" Text="Password:"></asp:Label>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 165px; top: 156px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" height="26px" OnClick="btnCancel_Click" style="z-index: 1; left: 247px; top: 217px; position: absolute" Text="Cancel" width="55px" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 342px; top: 132px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnLogin" runat="server" height="26px" OnClick="btnLogin_Click" style="z-index: 1; left: 175px; top: 217px; position: absolute; right: 462px" Text="Login" Width="55px" />
        </p>
    </form>
</body>
</html>
