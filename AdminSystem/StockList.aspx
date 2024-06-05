<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 273px; width: 307px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 323px; position: absolute; width: 59px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" height="26px" OnClick="btnEdit_Click" style="z-index: 1; left: 79px; top: 323px; position: absolute" Text="Edit" width="59px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 568px; position: absolute; width: 61px"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; top: 322px; position: absolute; height: 26px; width: 59px; left: 150px; right: 949px" Text="Delete" />
        <asp:Label ID="lblEnter" runat="server" style="z-index: 1; left: 14px; top: 384px; position: absolute; height: 22px; width: 143px" Text="Enter a Product Name"></asp:Label>
        <asp:TextBox ID="txtBoxEnter" runat="server" style="z-index: 1; left: 161px; top: 384px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 18px; top: 442px; position: absolute; height: 26px; width: 89px" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" height="26px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 125px; top: 442px; position: absolute" Text="Clear Filter" width="89px" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 303px; top: 442px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
