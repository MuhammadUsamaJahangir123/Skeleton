<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 17px; position: absolute; height: 426px; width: 379px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 21px; top: 469px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 104px; top: 470px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 625px; position: absolute; width: 65px" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 188px; top: 471px; position: absolute" Text="Delete" />
        <asp:Label ID="lblEnterfirstName" runat="server" style="z-index: 1; left: 23px; top: 527px; position: absolute" Text="Enter a FirstName"></asp:Label>
        <asp:TextBox ID="txtEnterfirstName" runat="server" style="z-index: 1; left: 169px; top: 524px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 25px; top: 575px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 181px; top: 572px; position: absolute; width: 99px" Text="Clear Filter" />
    </form>
</body>
</html>
