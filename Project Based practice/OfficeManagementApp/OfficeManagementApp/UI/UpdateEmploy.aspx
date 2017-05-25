<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateEmploy.aspx.cs" Inherits="OfficeManagementApp.UI.UpdateEmploy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h1>Please Search your Employee Details </h1>
        <br/>
        <br/>
        <table>
             <tr>
                <td>
                     <asp:Label ID="Label5" runat="server" Text="Employee ID"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="idTextBox" runat="server"></asp:TextBox>
                </td>             
            </tr>
              <tr>
                <td>
                    
                </td>
                 <td>
                     <asp:Button ID="searchButton" runat="server" Text="Search" Width="127px" OnClick="searchButton_Click" />
                </td>             
            </tr>
            
            <tr>
                <td>
                     <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                </td>             
            </tr>

              <tr>
                <td>
                     <asp:Label ID="Label2" runat="server" Text="Position"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="positionTextBox" runat="server"></asp:TextBox>
                </td>             
            </tr>
             <tr>
                <td>
                     <asp:Label ID="Label3" runat="server" Text="Salary"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="salaryTextBox" runat="server"></asp:TextBox>
                </td>             
            </tr>
              <tr>
                <td>
                     <asp:Label ID="Label4" runat="server" Text="Joining Date"></asp:Label>
                </td>
                 <td>
                     <asp:TextBox ID="joiningdateTextBox" runat="server"></asp:TextBox>
                </td>             
            </tr>
             <tr>
                <td>
                     
                </td>
                 <td>
                     <asp:Button ID="updateButton" runat="server" Text="Update" ForeColor="Red" font-size="20px" Height="33px" OnClick="saveButton_Click" Width="127px" />
                </td>             
            </tr>

        </table>
    </div>
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
