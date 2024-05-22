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
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 281px; position: absolute"></asp:Label>
                
    </form>
</body>
</html>
