<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestSetupUI.aspx.cs" Inherits="DiagnosticCenterBillManagementSystemApp.TestSetupUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <fieldset>
            <table>
                <tr>
                    <td><asp:Label ID="Label11" runat="server" Text="Test Name"></asp:Label></td>
                    <td><asp:TextBox ID="testNameTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label12" runat="server" Text="Fee"></asp:Label></td>
                    <td><asp:TextBox ID="feeTextBox" runat="server" TextMode="Number"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Type Name"></asp:Label></td>
                    <td><asp:DropDownList ID="typeNameDropDownList" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="saveButtonTestSetup" runat="server" Text="Save" OnClick="saveButtonTestSetup_Click"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="messageLabel" runat="server" ></asp:Label></td>
                </tr>
            </table>
        </fieldset>
        <br/>
        <br/>
        <div>
            <asp:GridView ID="testNameGridView" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Test Name">
                        <ItemTemplate>
                             <asp:Label runat="server" Text='<%#Eval("TestName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fee">
                        <ItemTemplate>
                             <asp:Label runat="server" Text='<%#Eval("Fee") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Type Name">
                        <ItemTemplate>
                             <asp:Label runat="server" Text='<%#Eval("TypeName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </fieldset>
    </div>
    </form>
</body>
</html>
