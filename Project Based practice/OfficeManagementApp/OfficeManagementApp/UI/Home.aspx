<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OfficeManagementApp.UI.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
        <div>
            <div>
                <h1 style="color: gray;">Employee Details Information for Our Company  </h1>
            </div>
        </div>
        <form id="form1" runat="server">
            <div>
                <h2>
                     <asp:HyperLink ID="entryHyperLink" runat="server" NavigateUrl="EntryEmploy.aspx" Font-Underline="false" target="_blank"  style=" color: blueviolet;">Entry Empolyee</asp:HyperLink>
                    <br />
                      <asp:HyperLink ID="showHyperLink" runat="server" NavigateUrl="ShowAllEmployee.aspx" Font-Underline="false" target="_blank"  style=" color: blueviolet;">Show List Empolyee</asp:HyperLink>
                    <br />
                      <asp:HyperLink ID="updateHyperLink" runat="server" NavigateUrl="UpdateEmploy.aspx" Font-Underline="false" target="_blank"  style=" color: blueviolet;">Update Empolyee</asp:HyperLink>
                    <br />
                </h2>
            </div>       
        </form>
    </body>
</html>
 