<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 15px; top: 36px; position: absolute; height: 357px; width: 412px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 22px; top: 415px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 149px; top: 414px; position: absolute" Text="Edit" />
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 249px; top: 416px; position: absolute" Text="Delete" />
        </p>
        <asp:Label ID="PostCodelbl" runat="server" style="z-index: 1; left: 41px; top: 465px; position: absolute" Text="Enter a Post Code"></asp:Label>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 538px; position: absolute; width: 34px" Text="lblError"></asp:Label>
        </p>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 175px; top: 463px; position: absolute"></asp:TextBox>
        <asp:Button ID="Applybtn" runat="server" OnClick="Applybtn_Click" style="z-index: 1; left: 65px; top: 498px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="Clearbtn" runat="server" OnClick="Clearbtn_Click" style="z-index: 1; left: 221px; top: 497px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnReturnMenu" runat="server" OnClick="btnReturnMenu_Click" style="z-index: 1; left: 360px; top: 413px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
