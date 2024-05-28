<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 6px; top: 32px; position: absolute" Text="Order ID" width="107px"></asp:Label>
        </div>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 138px; top: 26px; position: absolute; bottom: 622px; width: 130px;" Height="22px" Width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 305px; top: 42px; position: absolute" Text="Find" />
        <p>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 6px; top: 75px; position: absolute" Text="Customer ID" width="107px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" height="22px" style="z-index: 1; left: 139px; top: 68px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 6px; top: 114px; position: absolute" Text="Order Date" width="107px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" height="22px" style="z-index: 1; left: 139px; top: 102px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 6px; top: 145px; position: absolute" Text="Staff ID" width="107px"></asp:Label>
        </p>
        <asp:TextBox ID="txtStaffId" runat="server" height="22px" style="z-index: 1; left: 139px; top: 142px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 6px; top: 186px; position: absolute" Text="Total Amount" width="107px"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" height="22px" style="z-index: 1; left: 139px; top: 182px; position: absolute; bottom: 466px;" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkShippingStatus" runat="server" style="z-index: 1; left: 85px; top: 261px; position: absolute" Text="Shipping Status" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 296px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 89px; top: 344px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 19px; top: 344px; position: absolute; " Text="OK" width="60px" />
        </p>
        <asp:Label ID="lblShippingAddress" runat="server" style="z-index: 1; left: 6px; top: 228px; position: absolute" Text="Shipping Address"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server" Height="22px" style="z-index: 1; left: 139px; top: 220px; position: absolute" Width="128px"></asp:TextBox>
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 179px; top: 344px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
