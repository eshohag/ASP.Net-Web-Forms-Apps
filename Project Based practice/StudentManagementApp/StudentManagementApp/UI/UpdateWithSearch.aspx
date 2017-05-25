<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateWithSearch.aspx.cs" Inherits="StudentManagementApp.UI.UpdateWithSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                 <asp:Label ID="Label1" runat="server" Text="RegNo"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="regNoTextBox" runat="server" ></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:HiddenField ID="idHiddenField" runat="server" />
            </td>
            <td>
                 <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Contact No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        
          <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Dept Name"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
          <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
            </td>
        </tr>


    </table>
       
       
    
    </div>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
