<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUI.aspx.cs" Inherits="SessionApp.ContactUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="showInformationButton" runat="server" OnClick="showInformationButton_Click" Text="Show All Information" Width="157px" />
        <asp:Button ID="clearSessionButton" runat="server" OnClick="clearSessionButton_Click" Text="Clear Session" />
        <asp:Button ID="goToHomeButton" runat="server" OnClick="goToHomeButton_Click" Text="Go to Home " Width="125px" />
        <br />
        <br />
        <asp:Label ID="nameLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="emaiLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="cellphoneLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
