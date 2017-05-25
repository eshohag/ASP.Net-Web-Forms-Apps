<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntryStudent.aspx.cs" Inherits="StudentManagementApp.UI.IndexUI" %>

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
      <legend>Add Student Information</legend>
          <h2 style="text-align: center;" class="auto-style1">                             
              <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
              <asp:TextBox ID="nameTextBox" runat="server" Width="241px" style="margin-left: 136px" TabIndex="0"></asp:TextBox>
          </h2>
         
          <h2 style="text-align: center;" class="auto-style1">                            
             <asp:Label ID="Label6" runat="server" Text="RegNo"></asp:Label>
             <asp:TextBox ID="regNoTextBox3" runat="server" Width="245px" style="margin-left: 122px" TabIndex="1"></asp:TextBox>                
          </h2>

         <h2 style="text-align: center;" class="auto-style1">                             
             <asp:Label ID="Label3" runat="server" Text="E-mai:"></asp:Label>
             <asp:TextBox ID="emailTextBox" runat="server" style="margin-left: 127px" Width="248px" TabIndex="2"></asp:TextBox>               
          </h2>

          <h2 style="text-align: center;" class="auto-style1">                            
             <asp:Label ID="Label4" runat="server" Text="Contact Number"></asp:Label>
             <asp:TextBox ID="contactNumberTextBox1" runat="server" Width="245px" style="margin-left: 33px" TabIndex="3"></asp:TextBox>
                
          </h2>
         <h2 style="text-align: center;" class="auto-style1">             
                
             <asp:Label ID="Label5" runat="server" Text="Department Name"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:DropDownList ID="deptDropDownList" runat="server"  style="margin-left: 153px" Width="77px">
             </asp:DropDownList>
                
          </h2>
         <h2 style="text-align: center;">                            
             <asp:Button ID="saveButton" runat="server" Text="Save" Width="164px" OnClick="saveButton_Click" style="margin-left: 3px" TabIndex="5" />
             <asp:Button ID="showAllButton" runat="server" Text="Show All" Width="164px"  style="margin-left: 3px" TabIndex="6" OnClick="showAllButton_Click" />               
          </h2>

         <p style="text-align: center;">                            
             <asp:Label ID="messageLabel" runat="server"></asp:Label>
             <br/>
             <br/>
              <asp:Button ID="homeButton" runat="server"  Text="&lt;" Width="33px" Title="Home Page"   TabIndex="7" OnClick="homeButton_Click" />           
              <asp:Button ID="showAllStudentButton" runat="server"  Text="&gt;" Width="33px" TabIndex="8" Title="Show All page" OnClick="showAllStudentButton_Click" />
         </p>
     </fieldset>
    </form>
</body>
</html>
