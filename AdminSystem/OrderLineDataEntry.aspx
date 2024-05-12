<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderLineId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Order Line ID"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 117px; top: 53px; position: absolute"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="txtOrderLineId" runat="server" style="z-index: 1; left: 119px; top: 14px; position: absolute; height: 17px"></asp:TextBox>
            <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 116px; top: 92px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 13px; top: 57px; position: absolute" Text="Order ID"></asp:Label>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 9px; top: 93px; position: absolute" Text="Product ID"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 13px; top: 142px; position: absolute; right: 1446px; bottom: 713px" Text="Quantity"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 116px; top: 138px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 207px; position: absolute; height: 19px"></asp:Label>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 295px; top: 9px; position: absolute; height: 29px; width: 75px" Text="Find" />
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 70px; top: 280px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 157px; top: 280px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
