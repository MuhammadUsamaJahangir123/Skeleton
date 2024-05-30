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
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 371px; position: absolute; width: 61px"></asp:Label>
    </form>
</body>
</html>
