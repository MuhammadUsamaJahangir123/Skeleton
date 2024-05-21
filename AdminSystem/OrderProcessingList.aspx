<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderProcessingList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 307px; width: 346px" OnSelectedIndexChanged="lstOrderProcessingList_SelectedIndexChanged"></asp:ListBox>
    </form>
</body>
</html>
