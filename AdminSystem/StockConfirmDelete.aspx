<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYesDelete" runat="server" OnClick="btnYesDelete_Click" style="z-index: 1; left: 98px; top: 187px; position: absolute; width: 66px; " Text="Yes" />
        <asp:Button ID="btnNoDelete" runat="server" height="26px" OnClick="btnNoDelete_Click" style="z-index: 1; left: 197px; top: 187px; position: absolute" Text="No" width="66px" />
        <asp:Label ID="lblDeleteSure" runat="server" style="z-index: 1; left: 34px; top: 100px; position: absolute; width: 303px" Text="Are you sure you want to delete this record?"></asp:Label>
    </form>
</body>
</html>
