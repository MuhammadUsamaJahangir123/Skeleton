<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 95px; top: 141px; position: absolute; " Text="Yes" Width="30px" />
        </p>
        <asp:Label ID="lblConfirmation" runat="server" style="z-index: 1; left: 47px; top: 90px; position: absolute; height: 18px" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 186px; top: 141px; position: absolute" Text="No" />
    </form>
</body>
</html>
