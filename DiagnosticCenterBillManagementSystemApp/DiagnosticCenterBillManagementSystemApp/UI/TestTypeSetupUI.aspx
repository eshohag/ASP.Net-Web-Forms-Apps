<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestTypeSetupUI.aspx.cs" Inherits="DiagnosticCenterBillManagementSystemApp.TestTypeSetupUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Test Type Setup</legend>
                <table>               
                    <tr>
                        <br />
                        <asp:TextBox ID="typeNameTextBox" runat="server" Height="27px" Width="276px"></asp:TextBox>
                        <br />
                    </tr>
                    <tr>
                        <br />
                        <asp:Button ID="saveButtonTestTypeSetup" runat="server" OnClick="saveButtonTestTypeSetup_Click1" OnClientClick="return Validate()" Text="Save" Width="119px" />
                        <br />
                          <span id="spnError" style="color: Red; display: none">*Valid characters: Alphabets and space.</span>                      
                        <asp:Label ID="messageLabel" runat="server"></asp:Label>
                        <br />
                    </tr>
                </table>
                 <br />

               
                <div>
                    <asp:GridView ID="typeNameGridView" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Width="521px">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        <Columns>
                            <asp:TemplateField HeaderText="SL#">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Type Name">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("TypeName") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                        <SortedAscendingCellStyle BackColor="#FAFAE7" />
                        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                        <SortedDescendingCellStyle BackColor="#E1DB9C" />
                        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                    </asp:GridView>
                </div>
            </fieldset>
        </div>
    </form>

    <script type="text/javascript">
        function Validate() {
            var isValid = false;
            messageLabel.innerHTML = " ";
            var regex = /^[a-zA-Z ]*$/;
            isValid = regex.test(document.getElementById("<%=typeNameTextBox.ClientID %>").value);
            document.getElementById("spnError").style.display = !isValid ? "block" : "none";
            return isValid;
        }
    </script>

</body>
</html>
