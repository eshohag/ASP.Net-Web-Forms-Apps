<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="BookInfoApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form>
     <fieldset>
      <legend>Index</legend>
          <h2 style="text-align: center;">
                <asp:HyperLink ID="addBookHyperLink" runat="server" NavigateUrl="AddBook.aspx" Target="_blank" Font-underline="False">Add Book</asp:HyperLink>                 
          </h2>
         <h2 style="text-align: center;">             
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="ShowBook.aspx" Target="_blank" Font-underline="False">Show Book</asp:HyperLink> 
          </h2>
     </fieldset>
    </form>
</body>
</html>
