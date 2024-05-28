<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Confirmlbl" runat="server" style="z-index: 1; left: 42px; top: 57px; position: absolute; height: 44px; width: 299px" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <asp:Button ID="Nobtn" runat="server" OnClick="Nobtn_Click" style="z-index: 1; left: 210px; top: 113px; position: absolute; width: 85px" Text="No" />
        <p>
            <asp:Button ID="Yesbtn" runat="server" OnClick="Yesbtn_Click" style="z-index: 1; left: 42px; top: 114px; position: absolute; width: 93px" Text="Yes" />
        </p>
    </form>
</body>
</html>
