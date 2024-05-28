<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 283px;
        }
    </style>
</head>
<body style="height: 582px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="289px" Width="301px"></asp:ListBox><asp:Button runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"></asp:Button>
                
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 371px; top: 296px; position: absolute" Text="Edit" />
                
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 430px; top: 295px; position: absolute" Text="Delete" />
                
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 483px; position: absolute"></asp:Label>
                
        </p>
        <asp:Label ID="lblInputEmail" runat="server" style="z-index: 1; left: 20px; top: 362px; position: absolute; height: 19px; right: 1403px;" Text="Enter an Email"></asp:Label>
        <asp:TextBox ID="txtEnterEmail" runat="server" style="z-index: 1; left: 186px; top: 359px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 16px; top: 403px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 150px; top: 403px; position: absolute" Text="Clear Filter" />
                
        <asp:Button ID="btnReturnToMainMenu2" runat="server" OnClick="btnReturnToMainMenu2_Click" style="z-index: 1; left: 335px; top: 402px; position: absolute" Text="Return to Main Menu" />
                
    </form>
</body>
</html>
