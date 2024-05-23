<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 177px; top: 65px; position: absolute; height: 22px; width: 149px" Text="Hat Haven Main Menu"></asp:Label>
        <asp:Button ID="btnCustomers" runat="server" OnClick="btnCustomers_Click" style="z-index: 1; left: 206px; top: 187px; position: absolute" Text="Customers" />
        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 229px; top: 332px; position: absolute" Text="Staff" />
        <asp:Button ID="btnOrderProcessing" runat="server" style="z-index: 1; left: 184px; top: 139px; position: absolute" Text="OrderProcessing" />
        <asp:Button ID="btnStock" runat="server" style="z-index: 1; left: 222px; top: 280px; position: absolute" Text="Stock" />
        <asp:Button ID="btnSupplier" runat="server" style="z-index: 1; left: 216px; top: 232px; position: absolute" Text="Supplier" />
    </form>
</body>
</html>
