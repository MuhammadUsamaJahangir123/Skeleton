<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 445px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="215px" Width="236px"></asp:ListBox><asp:Button runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"></asp:Button>
                
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 321px; top: 223px; position: absolute" Text="Edit" />
                
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 383px; top: 221px; position: absolute" Text="Delete" />
                
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 35px; top: 410px; position: absolute"></asp:Label>
                
        </p>
        <asp:Label ID="lblInputLastName" runat="server" style="z-index: 1; left: 20px; top: 313px; position: absolute; height: 19px" Text="Enter a Last Name"></asp:Label>
        <asp:TextBox ID="txtEnterLastName" runat="server" style="z-index: 1; left: 148px; top: 312px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 23px; top: 353px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 151px; top: 353px; position: absolute" Text="Clear Filter" />
                
    </form>
</body>
</html>
