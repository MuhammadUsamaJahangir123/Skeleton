<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 309px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            &nbsp;<div>
                <asp:Label ID="lblConfirmation" runat="server" style="z-index: 1; left: 22px; top: 73px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 58px; top: 116px; position: absolute; width: 64px; right: 740px" Text="Yes" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 152px; top: 117px; position: absolute; width: 70px" Text="No" />
        </div>
    </form>
</body>
</html>
