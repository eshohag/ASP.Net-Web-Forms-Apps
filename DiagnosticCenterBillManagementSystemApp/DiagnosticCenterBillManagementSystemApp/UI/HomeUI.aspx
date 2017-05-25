<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="DiagnosticCenterBillManagementSystemApp.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Index</legend>
        <br/>
        <asp:HyperLink ID="testTypeSetupUIHyperLink" runat="server" NavigateUrl="TestTypeSetupUI.aspx">Test Type Setup UI</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="testSetupUIHyperLink" runat="server" NavigateUrl="TestSetupUI.aspx">Test Setup UI</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="testRequestEntryUIHyperLink" runat="server" NavigateUrl="TestRequestEntryUI.aspx">Test Request Entry UI</asp:HyperLink>
        <br />
        <asp:HyperLink ID="paymentUIHyperLink" runat="server" NavigateUrl="PaymentUI.aspx">Payment UI</asp:HyperLink>
        <br />
        <asp:HyperLink ID="testWiseReportUIHyperLink" runat="server" NavigateUrl="TestWiseReportUI.aspx">Test Wise Report UI</asp:HyperLink>
        <br />
        <asp:HyperLink ID="typeWiseReportUIHyperLink" runat="server" NavigateUrl="TypeWiseReportUI.aspx">Type Wise Report UI</asp:HyperLink>
        <br />
        <asp:HyperLink ID="unpaidBillReportUIHyperLink" runat="server" NavigateUrl="UnpaidBillReportUI.aspx">Unpaid Bill Report UI</asp:HyperLink>
        <br />
    </fieldset>
    </div>
    </form>
</body>
</html>
