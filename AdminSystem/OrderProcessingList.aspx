<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderProcessingList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 307px; width: 346px" OnSelectedIndexChanged="lstOrderProcessingList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 11px; top: 367px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 72px; top: 367px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 422px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 138px; top: 368px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
