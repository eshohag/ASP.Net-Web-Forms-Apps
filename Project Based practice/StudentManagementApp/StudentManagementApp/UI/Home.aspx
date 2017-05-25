<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="StudentManagementApp.UI.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2 style="text-align: center">
            
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="ShowAll.aspx" Font-Underline="False" Target="_blank">Show All</asp:HyperLink>
              <br/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="EntryStudent.aspx" Font-Underline="False" Target="_blank">Entry Student</asp:HyperLink>
             <br/>
               
             <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="UpdateWithSearch.aspx" Font-Underline="False" Target="_blank">Update Information With Search</asp:HyperLink>
        </h2>
   </div>
    </form>
</body>
</html>
