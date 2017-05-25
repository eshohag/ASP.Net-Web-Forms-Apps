<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentUI.aspx.cs" Inherits="DiagnosticCenterBillManagementSystemApp.PaymentUI" %>

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
                        <td><asp:Label ID="Label3" runat="server" Text="BillNo"></asp:Label></td>
                        <td><asp:TextBox ID="billNoTextBoxPaymentUI" runat="server" ></asp:TextBox></td>
                        <td><asp:Label ID="Label4" runat="server" Text="Or"></asp:Label></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label5" runat="server" Text="Mobile No"></asp:Label></td>
                        <td><asp:TextBox ID="mobileNoTextBoxPaymentUI" runat="server" ></asp:TextBox></td>
                        <td><asp:Button ID="searchButtonPaymentUI" runat="server" Text="Search" OnClick="searchButtonPaymentUI_Click" /></td>
                    </tr>
                </table>
            </fieldset>
            <fieldset>
                <table>
                    <tr>
                        <td><asp:Label ID="Label1" runat="server" Text="Amount"></asp:Label></td>
                        <td><asp:TextBox ID="amountTextBoxPaymentUI" runat="server"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label2" runat="server" Text="Due Date"></asp:Label></td>
                        <td><asp:TextBox ID="dueDateTextBoxPaymentUI" runat="server"></asp:TextBox></td>
                        <td><asp:Button ID="payButtonPaymentUI" runat="server" Text="Pay" OnClick="payButtonPaymentUI_Click" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="messageLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </fieldset>
    </div>
    </form>
</body>
</html>
