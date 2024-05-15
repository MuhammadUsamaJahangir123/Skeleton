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
    <form id="form1" runat="server"> <div>
        </div>       
        <asp:Label ID="lblSupplierId" runat="server" height="19px" style="z-index: 1; left: 13px; top: 38px; position: absolute" Text="Supplier Id" width="111px"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server" height="22px" style="z-index: 1; left: 127px; top: 40px; position: absolute; margin-top: 0px" width="128px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkActivity" runat="server" style="z-index: 1; left: 29px; top: 195px; position: absolute" Text="Active" />position: absolute" width="128px"></asp:TextBox>ex: 1; left: 11px; top: 146px; 
        <br class="Apple-interchange-newline">
        <p>
            <asp:Label ID=
        <br />
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 128px; top: 73px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierDate" runat="server" height="19px" style="z-index: 1; left: 13px; top: 112px; position: absolute" Text="Supplier Date" width="111px"></asp:Label>
        <asp:TextBox ID="txtSupplierDAte" runat="server" height="22px" style="z-index: 1; left: 127px; top: 111px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierContact" runat="server" height="22px" style="z-indeposition: absolute; right: 1363px" Text="Supplier Contact"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 222px; top: 191px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 42px; top: 238px; position: absolute" Text="OK" />
        </p>
        <asp:Label ID="lblSupplierName" runat="server" height="19px" style="z-index: 1; left: 13px; top: 74px; position: absolute" Text="Supplier Name" width="111px"></asp:Label>
        <asp:Button runat="server" Text="Button" OnClick="btnFind_Click">   </asp:Button>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 225px; top: 232px; position: absolute" Text="Cancel" />"lblSupplierContact" runat="server" style="z-indx: 1; left: 127px; top: 147px; 
    </form>
</body>
</html>
