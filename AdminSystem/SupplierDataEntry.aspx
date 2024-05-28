<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 278px;
        }
    </style>
</head>
<body style="height: 620px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierId" runat="server" height="19px" style="z-index: 1; left: 10px; top: 38px; position: absolute" Text="Supplier Id" width="140px"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server" height="22px" style="z-index: 1; left: 180px; top: 40px; position: absolute; margin-top: 0px" width="128px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkActivity" runat="server" style="z-index: 1; left: 22px; top: 263px; position: absolute" Text="Active" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 381px; top: 46px; position: absolute" Text="Find" />
        <br />
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 180px; top: 73px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierDate" runat="server" height="19px" style="z-index: 1; left: 10px; top: 118px; position: absolute" Text="Supplier Date" width="140px"></asp:Label>
        <asp:TextBox ID="txtSupplierDAte" runat="server" height="22px" style="z-index: 1; left: 180px; top: 111px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierPostCode" runat="server" height="22px" style="z-index: 1; left: 180px; top: 182px; position: absolute; margin-top: 0px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierContact" runat="server" height="22px" style="z-index: 1; left: 180px; top: 147px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierContact" runat="server" style="z-index: 1; left: 10px; top: 152px; position: absolute; " Text="Supplier Contact" height="19px" width="140px"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 204px; top: 269px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 140px; top: 315px; position: absolute; width: 33px;" Text="OK" />
        </p>
        <asp:Label ID="lblSupplierName" runat="server" height="19px" style="z-index: 1; left: 10px; top: 79px; position: absolute" Text="Supplier Name" width="140px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 258px; top: 314px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblSupplierPostCode" runat="server" height="19px" style="z-index: 1; left: 10px; top: 188px; position: absolute" Text="Supplier Postcode" width="140px"></asp:Label>
        <asp:Label ID="lblSupplierShippingTme" runat="server" style="z-index: 1; left: 10px; top: 227px; position: absolute" Text="Supplier Shipping Time"></asp:Label>
        <asp:TextBox ID="txtSupplierShippingTime" runat="server" height="22px" OnTextChanged="txtSupplierShippingTime_TextChanged" style="z-index: 1; left: 180px; top: 222px; position: absolute; margin-bottom: 0px" width="128px"></asp:TextBox>
    </form>
</body>
</html>