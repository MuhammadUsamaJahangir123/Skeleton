<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 9px; top: 45px; position: absolute" Text="Order ID" width="83px"></asp:Label>
        </div>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 117px; top: 41px; position: absolute; bottom: 607px; width: 130px;" Height="22px" Width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 305px; top: 42px; position: absolute" Text="Find" />
        <p>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 8px; top: 77px; position: absolute" Text="Customer ID" width="83px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" height="22px" style="z-index: 1; left: 118px; top: 73px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 11px; top: 114px; position: absolute" Text="Order Date" width="83px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" height="22px" style="z-index: 1; left: 118px; top: 104px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 11px; top: 145px; position: absolute" Text="Staff ID" width="83px"></asp:Label>
        </p>
        <asp:TextBox ID="txtStaffId" runat="server" height="22px" style="z-index: 1; left: 118px; top: 140px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 11px; top: 177px; position: absolute" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" height="22px" style="z-index: 1; left: 118px; top: 174px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkShippingStatus" runat="server" style="z-index: 1; left: 82px; top: 221px; position: absolute" Text="Shipping Status" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 255px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 18px; top: 297px; position: absolute; " Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 78px; top: 298px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
