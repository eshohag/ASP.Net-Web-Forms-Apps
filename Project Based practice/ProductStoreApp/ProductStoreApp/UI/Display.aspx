<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="ProductStoreApp.UI.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 14px;
        }
        .auto-style2 {
            width: 553px;
        }
        .auto-style3 {
            width: 666px;
        }
        .auto-style4 {
            width: 468px;
        }
    </style>
</head>
<body>   
    <form id="form1" runat="server">
     <fieldset>
     <legend><h2>Display </h2></legend>
         <br/>
         <asp:GridView ID="showGridView" runat="server"   CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-left: 1px" Width="422px" Height="108px" AutoGenerateColumns="False">
                <columns>
                     <asp:TemplateField HeaderText="Id">
                        <ItemTemplate>
                            <%#Eval("Id") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Code">
                        <ItemTemplate>
                            <%#Eval("Code") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <%#Eval("Description") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                            <%#Eval("Quantity") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </columns>
             
             
             
              <AlternatingRowStyle BackColor="White" />
         <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
         <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
         <SortedAscendingCellStyle BackColor="#FDF5AC" />
         <SortedAscendingHeaderStyle BackColor="#4D0000" />
         <SortedDescendingCellStyle BackColor="#FCF6C0" />
         <SortedDescendingHeaderStyle BackColor="#820000" />
         </asp:GridView>
        
       
         
         
         
             <table>
                    <tr>
                        <td>
                            <h3 style="text-align: left">
                             <asp:HyperLink ID="homeHyperLink" runat="server" NavigateUrl="~/UI/IndexUI.aspx" Target="_blank" font-Underline="False">Home</asp:HyperLink>
                            </h3>
                        </td>
                        <td>
                            
                        </td>
                         <td class="auto-style3">
                            
                             &nbsp;</td>
                         <td class="auto-style4">
                             <asp:Label ID="Label1" runat="server" Text="Total Quantity"></asp:Label>
                             <asp:TextBox ID="totalQuantityTextBox" runat="server" ReadOnly="True" style="margin-left: 5px" Height="16px"></asp:TextBox>
                        </td>
                         <td>
                            
                        </td>
                         <td class="auto-style2">
                            
                        </td>
                         <td class="auto-style1">
                             <h3 style="text-align: right">
                               <asp:HyperLink ID="rightHyperLink" runat="server" NavigateUrl="~/UI/SaveUI.aspx" Target="_blank" Font-Underline="False">Save</asp:HyperLink>
                             </h3>
                        </td>
                    </tr>
                </table>
      </fieldset>

    </form>
</body>
</html>
