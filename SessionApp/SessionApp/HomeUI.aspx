<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="SessionApp.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>
        <asp:TextBox ID="emailNumberTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Cell Phone No"></asp:Label>
            <asp:TextBox ID="cellNumberTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="saveButton" runat="server" BackColor="#996600" ForeColor="White" OnClick="saveButton_Click" Text="Save" Width="215px" />
        </p>
        <p>
            <asp:Button ID="goToNextPageButton" runat="server" OnClick="goToNextPageButton_Click" Text="Go to Next Page" Width="210px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
