<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" height="40px" style="z-index: 1; left: 250px; top: 30px; position: absolute" width="252px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="txtProductId" runat="server" style="z-index: 1; left: 8px; top: 29px; position: absolute; right: 1961px;" Text="Product ID" width="208px"></asp:Label>
        </p>
        <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 10px; top: 105px; position: absolute" Text="Product Name" width="208px"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" height="40px" style="z-index: 1; left: 250px; top: 105px; position: absolute" width="252px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 2px; top: 193px; position: absolute; height: 32px; width: 208px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 250px; position: absolute; top: 183px; height: 40px" width="252px"></asp:TextBox>
        <asp:Label ID="lblProductPrice" runat="server" style="z-index: 1; left: 8px; top: 285px; position: absolute; width: 208px; right: 1880px" Text="Product Price"></asp:Label>
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 10px; top: 369px; position: absolute; width: 208px" Text="Stock Quantity"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; left: 250px; top: 367px; position: absolute; width: 252px; height: 40px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtProductPrice" runat="server" OnTextChanged="txtProductPrice_TextChanged" style="z-index: 1; left: 250px; top: 279px; position: absolute; width: 252px; height: 40px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkIsAvailable" runat="server" style="z-index: 1; left: 246px; top: 455px; position: absolute" Text="Is Available" />
        <asp:CheckBox ID="chkRestock" runat="server" style="z-index: 1; left: 244px; top: 523px; position: absolute" Text="Restock" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 805px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 30px; top: 875px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 124px; top: 877px; position: absolute; height: 46px" Text="Cancel" />
    </form>
</body>
</html>