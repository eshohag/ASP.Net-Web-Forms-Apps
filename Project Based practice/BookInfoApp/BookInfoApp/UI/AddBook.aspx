<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BookInfoApp.UI.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <fieldset>
      <legend>Add Book</legend>
          <h2 style="text-align: center;" class="auto-style1">
               
                
              <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
              <asp:TextBox ID="nameTextBox" runat="server" Width="241px" style="margin-left: 25px"></asp:TextBox>
               
                
          </h2>
         <h2 style="text-align: center;" class="auto-style1">             
                
             <asp:Label ID="Label2" runat="server" Text="ISBN"></asp:Label>
             <asp:TextBox ID="isbnTextBox" runat="server" Width="245px" style="margin-left: 33px" TabIndex="1"></asp:TextBox>
                
          </h2>
         <h2 style="text-align: center;" class="auto-style1">             
                
             <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
             <asp:TextBox ID="authorTextBox" runat="server" style="margin-left: 17px" Width="248px" TabIndex="2"></asp:TextBox>
                
          </h2>
         <h2 style="text-align: center;">             
                
             <asp:Button ID="saveButton" runat="server" Text="Save" Width="164px" OnClick="saveButton_Click" style="margin-left: 3px" TabIndex="3" />
                
          </h2>
         <p style="text-align: center;">             
                
             <asp:Label ID="messageLabel" runat="server"></asp:Label>
             <br/>
              <asp:Button ID="indexBookButton" runat="server"  Text="&lt;" Width="33px" Title="Home Page" OnClick="indexBookButton_Click" />
           
            <asp:Button ID="showAllBookButton" runat="server"  Text="&gt;" Width="33px" Title="Show All page" OnClick="showAllBookButton_Click"/>
         </p>
     </fieldset>
    </form>
</body>
</html>
