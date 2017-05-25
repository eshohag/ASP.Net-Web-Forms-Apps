<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TypeWiseReportUI.aspx.cs" Inherits="DiagnosticCenterBillManagementSystemApp.TypeWiseReportUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <table>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="From Date"></asp:Label></td>
                    <td><asp:TextBox ID="fromDateTextBoxTypeWiseReportUI" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="To date"></asp:Label></td>
                    <td><asp:TextBox ID="toDateTextBoxTypeWiseReportUI" runat="server"></asp:TextBox></td>
                    <td><asp:Button ID="showButtonTypeWiseReportUI" runat="server" Text="Show" OnClick="showButtonTypeWiseReportUI_Click"/></td>
                </tr>
            </table>
        <br/>
        <br/>
                 <asp:GridView ID="typeWiseReportUIGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                     <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField HeaderText="SL#">
                            <ItemTemplate>
                                <%# Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Test Type Name">
                        <ItemTemplate>
                             <asp:Label runat="server" Text='<%#Eval("TypeName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Total no Of Test">
                        <ItemTemplate>
                             <asp:Label ID="totalNoOfTestID" runat="server" Text='<%#Eval("TotalNoOfTest") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField HeaderText="Total Amount">
                        <ItemTemplate>
                             <asp:Label ID="totalAmountID" runat="server" Text='<%#Eval("TotalAmount") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     </Columns>
                     <EditRowStyle BackColor="#999999" />
                     <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                     <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                     <SortedAscendingCellStyle BackColor="#E9E7E2" />
                     <SortedAscendingHeaderStyle BackColor="#506C8C" />
                     <SortedDescendingCellStyle BackColor="#FFFDF8" />
                     <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                  </asp:GridView>
         <br/>
        <br/>
        <table>
                <tr>
                    <td><asp:Button ID="pdfButtonTypeWiseReportUI" runat="server" Text="PDF" /></td>
                    <td><asp:Label ID="Label6" runat="server" Text="Total"></asp:Label></td>
                    <td><asp:TextBox ID="totalTextBoxTypeWiseReportUI" runat="server" BackColor="Red" Font-Bold="True" Font-Size="Large" ForeColor="White" ReadOnly="True" Width="162px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="messageLabel" runat="server" ></asp:Label></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
