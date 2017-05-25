<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowBook.aspx.cs" Inherits="BookInfoApp.UI.ShowBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <fieldset>
      <legend>Show Book</legend>
        <div style="text-align: center;">
            <h2>
             <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>         
             <asp:TextBox ID="searchTextBox" runat="server" Height="24px" style="margin-left: 22px" Width="130px"></asp:TextBox>
             <asp:Button ID="searchButton" runat="server" Text="search" OnClick="searchButton_Click" Height="28px" style="margin-left: 13px" Width="73px" /> 
               <br />
             </h2>
                
            <h3>
                 <asp:Label ID="messageLabel" runat="server" Text=" "></asp:Label>
            </h3>
          
                      
            
            <asp:GridView ID="showGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" HorizontalAlign="Center" Width="400px" >
                <Columns>
                    <asp:TemplateField HeaderText=" SL#">
                        <ItemTemplate>                           
                       <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                      <asp:TemplateField HeaderText=" ISBN">
                        <ItemTemplate>                           
                            <asp:Label runat="server" Text='<%#Eval("ISBN") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Author">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Author") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                  
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
            <br />
            <asp:Button ID="addBookButton" runat="server" OnClick="addBookButton_Click" Text="&lt;" Width="33px" Title="Add Page"/>
            <asp:Button ID="againShowButton" runat="server" OnClick="againShowButton_Click" Text="Show All" Width="94px" />
            <asp:Button ID="homeButton" runat="server" OnClick="homeButton_Click" Text="&gt;" Width="32px" Title="Home Page"/>
         </div> 
     </fieldset>
    </form>
           
</body>
</html>
