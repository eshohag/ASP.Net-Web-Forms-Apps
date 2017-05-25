<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAll.aspx.cs" Inherits="StudentManagementApp.UI.Show_All" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="showAllStudentGridView" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="161px" Width="873px" >
            <Columns>
                 <asp:TemplateField HeaderText="SL#">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <%#Eval("Id") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Registration No">
                    <ItemTemplate>                       
                        <asp:HiddenField ID="idHiddenField" runat="server" Value='<%#Eval("Id") %>'/>
                        <%#Eval("RegNo") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <%#Eval("Name") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="E-mail">
                    <ItemTemplate>
                        <%#Eval("Email") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Contact Number">
                    <ItemTemplate>
                        <%#Eval("ContactNo") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Department Name">
                    <ItemTemplate>
                        <%#Eval("DepartmentId") %>
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField >
                    <ItemTemplate>
                        <asp:LinkButton ID="deleteLinkButton" runat="server" Font-Underline="False" OnClick="deleteLinkButton_Click">Delete</asp:LinkButton>
                           <asp:LinkButton ID="updateLinkButton" runat="server" Font-Underline="False" OnClick="updateLinkButton_Click">Update</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>  
    </div>
        <br />
        <div>
              <asp:GridView ID="GridViewVMStudent" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="161px" Width="873px" >
            <Columns>
                 <asp:TemplateField HeaderText="SL#">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <%#Eval("Id") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Registration No">
                    <ItemTemplate>                       
                      <asp:HiddenField ID="idHiddenField" runat="server" Value='<%#Eval("Id") %>'/>
                        <%#Eval("RegNo") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <%#Eval("Name") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="E-mail">
                    <ItemTemplate>
                        <%#Eval("Email") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Contact Number">
                    <ItemTemplate>
                        <%#Eval("ContactNo") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Department Name">
                    <ItemTemplate>
                        <%#Eval("DepartmentName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField >
                    <ItemTemplate>
                        <asp:LinkButton ID="deleteLinkButton" runat="server" Font-Underline="False" OnClick="deleteLinkButton_Click">Delete</asp:LinkButton>
                           <asp:LinkButton ID="updateLinkButton" runat="server" Font-Underline="False" OnClick="updateLinkButton_Click">Update</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>  
        </div>
    <div style="text-align: Center">
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:HyperLink ID="homeHyperLink" runat="server"  Font-Underline="False" NavigateUrl="Home.aspx" Target="_balnk" >Home</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="EntryHyperLink" runat="server"  Font-Underline="False" NavigateUrl="EntryStudent.aspx" Target="_balnk" >Entry</asp:HyperLink>
    </div>
    
     </form>
    </body>
</html>
