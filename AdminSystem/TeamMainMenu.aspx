﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 289px; top: 91px; position: absolute; height: 22px; width: 200px" Text="Hat Haven Main Menu"></asp:Label>
        <asp:Button ID="btnCustomers" runat="server" OnClick="btnCustomers_Click" style="z-index: 1; left: 135px; top: 146px; position: absolute" Text="Customers" height="26px" width="83px" />
        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 432px; top: 215px; position: absolute" Text="Staff" OnClick="btnStaff_Click" height="26px" width="50px" />
        <asp:Button ID="btnOrderProcessing" runat="server" style="z-index: 1; left: 277px; top: 146px; position: absolute" Text="OrderProcessing" OnClick="btnOrderProcessing_Click" />
        <asp:Button ID="btnStock" runat="server" style="z-index: 1; left: 224px; top: 214px; position: absolute" Text="Stock" height="26px" width="50px" OnClick="btnStock_Click" />
        <asp:Button ID="btnSupplier" runat="server" style="z-index: 1; left: 489px; top: 146px; position: absolute; width: 83px;" Text="Supplier" OnClick="btnSupplier_Click" />
    </form>
</body>
</html>
