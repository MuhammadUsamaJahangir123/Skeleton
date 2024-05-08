<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 9px; top: 45px; position: absolute" Text="Order ID"></asp:Label>
        </div>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 88px; top: 43px; position: absolute; bottom: 809px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 8px; top: 77px; position: absolute" Text="Customer ID"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" height="22px" style="z-index: 1; left: 84px; top: 76px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 11px; top: 114px; position: absolute" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" height="22px" style="z-index: 1; left: 84px; top: 115px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 11px; top: 145px; position: absolute" Text="Staff ID"></asp:Label>
        </p>
        <asp:TextBox ID="txtStaffId" runat="server" height="22px" style="z-index: 1; left: 84px; top: 145px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 11px; top: 177px; position: absolute" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" height="22px" style="z-index: 1; left: 84px; top: 175px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkShippingStatus" runat="server" style="z-index: 1; left: 82px; top: 221px; position: absolute" Text="Shipping Status" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 255px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 18px; top: 297px; position: absolute; right: 1110px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 78px; top: 298px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
