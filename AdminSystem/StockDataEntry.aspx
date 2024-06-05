<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 21px; top: 33px; position: absolute; height: 18px" Text="Product ID" width="105px"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 202px; top: 26px; position: absolute; height: 22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 21px; top: 93px; position: absolute; height: 18px; width: 105px" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" height="22px" style="z-index: 1; left: 202px; top: 87px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblProductPrice" runat="server" height="18px" style="z-index: 1; left: 21px; top: 152px; position: absolute; width: 105px" Text="Product Price"></asp:Label>
        <asp:TextBox ID="txtProductPrice" runat="server" height="22px" style="z-index: 1; left: 202px; top: 146px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblStockQuantity" runat="server" height="18px" style="z-index: 1; left: 21px; top: 213px; position: absolute" Text="Stock Quantity" width="105px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" height="22px" style="z-index: 1; left: 202px; top: 207px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" height="18px" style="z-index: 1; left: 21px; top: 280px; position: absolute" Text="Date Added" width="105px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" height="22px" style="z-index: 1; left: 202px; top: 275px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkIsAvailable" runat="server" style="z-index: 1; left: 419px; top: 133px; position: absolute; height: 26px" Text="Available" />
        <asp:CheckBox ID="chkRestock" runat="server" style="z-index: 1; left: 419px; top: 179px; position: absolute; height: 26px" Text="Restock" width="76px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 464px; position: absolute; right: 1405px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" height="27px" OnClick="btnOK_Click" style="z-index: 1; top: 506px; position: absolute; width: 70px; left: 15px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 506px; position: absolute; width: 70px; height: 27px; right: 1135px" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnFind" runat="server" height="22px" OnClick="btnFind_Click" style="z-index: 1; left: 201px; top: 335px; position: absolute; width: 137px" Text="Find" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 199px; top: 506px; position: absolute; height: 27px; width: 183px" Text="Return to Main Menu" />
    </form>
</body>
</html>
