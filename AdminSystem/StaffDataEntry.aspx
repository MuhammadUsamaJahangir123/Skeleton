<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 428px">
    <form id="form1" runat="server">
        <div style="height: 410px">
            <asp:Label ID="lblStaffID" runat="server" height="44px" style="z-index: 1; left: 19px; top: 50px; position: absolute" Text="Staff ID" width="62px"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 204px; top: 47px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblFIrstName" runat="server" height="44px" style="z-index: 1; left: 22px; top: 105px; position: absolute; width: 94px" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 205px; top: 102px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 21px; top: 156px; position: absolute; width: 95px" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 206px; top: 153px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblJoinedDate" runat="server" height="44px" style="z-index: 1; left: 21px; top: 206px; position: absolute; width: 98px" Text="Joined Date"></asp:Label>
            <asp:TextBox ID="txtJoinedDate" runat="server" style="z-index: 1; left: 206px; top: 202px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" height="44px" style="z-index: 1; left: 22px; top: 248px; position: absolute" Text="Email" width="62px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 206px; top: 246px; position: absolute; right: 550px;" width="168px"></asp:TextBox>
            <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 21px; top: 293px; position: absolute" Text="Phone No"></asp:Label>
            <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 207px; top: 293px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 475px; top: 63px; position: absolute; width: 76px" Text="Find" />
        </div>
        <asp:CheckBox ID="chkAvailability" runat="server" style="z-index: 1; left: 210px; top: 333px; position: absolute" Text="Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 33px; top: 452px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 29px; top: 494px; position: absolute; width: 33px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 107px; top: 494px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 264px; top: 493px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
