<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<script runat="server">

</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 410px;
        }
    </style>
</head>
<body style="height: 359px">
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 13px; top: 54px; position: absolute; right: 466px; bottom: 498px;" Text="CustomerID"></asp:Label>
        <p>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 112px; top: 54px; position: absolute" OnTextChanged="txtCustomerID_TextChanged"></asp:TextBox>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 13px; top: 93px; position: absolute; height: 23px" Text="FirstName" width="72px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 111px; top: 90px; position: absolute" OnTextChanged="txtFirstName_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 13px; top: 135px; position: absolute" Text="LastName" width="72px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 113px; top: 136px; position: absolute" OnTextChanged="txtLastName_TextChanged"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 13px; top: 176px; position: absolute; height: 21px; width: 72px" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 113px; top: 176px; position: absolute" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkSubscribe" runat="server" style="z-index: 1; left: 15px; top: 372px; position: absolute" Text="Subscribe" OnCheckedChanged="chkSubscribe_CheckedChanged" />
            <asp:Label ID="lblSubscribe" runat="server" style="z-index: 1; left: 15px; top: 329px; position: absolute" Text="Subscribed?" width="72px"></asp:Label>
            <asp:Label ID="lblJoinedDate" runat="server" style="z-index: 1; left: 13px; top: 220px; position: absolute" Text="JoinedDate" width="72px"></asp:Label>
            <asp:TextBox ID="txtJoinedDate" runat="server" style="z-index: 1; left: 111px; top: 223px; position: absolute" OnTextChanged="txtJoinedDate_TextChanged"></asp:TextBox>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 494px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 76px; top: 496px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 451px; position: absolute; height: 19px;"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 14px; top: 276px; position: absolute" Text="PhoneNo"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server" OnTextChanged="txtPhoneNo_TextChanged" style="z-index: 1; left: 109px; top: 276px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 316px; top: 47px; position: absolute; width: 56px" Text="Find" />
    </form>
</body>
</html>
