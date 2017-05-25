<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="ProductStoreApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <fieldset>
         <legend><h2>Index</h2></legend>
          <h2 style="text-align: center">
             <asp:HyperLink ID="saveHyperLink" runat="server" NavigateUrl="SaveUI.aspx" Font-Underline="False">Save Product</asp:HyperLink>
              <br/>
              <asp:HyperLink ID="displayHyperLink" runat="server" NavigateUrl="Display.aspx" Font-Underline="False">Display Product</asp:HyperLink>
              <br/>
              <br/>
          </h2>
      </fieldset>
    </div>
    </form>
</body>
</html>
