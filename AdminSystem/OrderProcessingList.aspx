<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInput" runat="server" style="z-index: 1; left: 13px; top: 425px; position: absolute" Text="Enter a shipping address"></asp:Label>
        </div>
        <asp:ListBox ID="lstOrderProcessingList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 307px; width: 346px; right: 418px;" OnSelectedIndexChanged="lstOrderProcessingList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 11px; top: 367px; position: absolute; right: 726px;" Text="Add" width="55px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 72px; top: 367px; position: absolute" Text="Edit" width="55px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 6px; top: 554px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 138px; top: 367px; position: absolute" Text="Delete" />
        <asp:TextBox ID="txtInput" runat="server" style="z-index: 1; left: 194px; top: 424px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 47px; top: 482px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 194px; top: 482px; position: absolute" Text="Clear Filter" width="100px" />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 360px; top: 482px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
