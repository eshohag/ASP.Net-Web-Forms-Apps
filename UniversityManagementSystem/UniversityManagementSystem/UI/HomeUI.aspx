<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="UniversityManagementSystem.UI.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="entryHyperLink" runat="server" NavigateUrl="StudentEntryUI.aspx">Entry</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="showAllHyperLink" runat="server" NavigateUrl="ShowAllStudentsUI.aspx">View All</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="updateHyperLink" runat="server" NavigateUrl="StudentUpdateUI.aspx">Update</asp:HyperLink>
    </div>
    </form>
</body>
</html>
