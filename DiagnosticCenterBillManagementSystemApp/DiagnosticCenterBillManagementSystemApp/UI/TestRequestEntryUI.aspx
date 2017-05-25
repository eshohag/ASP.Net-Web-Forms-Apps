<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestRequestEntryUI.aspx.cs" Inherits="DiagnosticCenterBillManagementSystemApp.TestRequestEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-datepicker.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
        <table>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Name of the Patient"></asp:Label></td>
                    <td><asp:TextBox ID="patientNameTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Date of Birth"></asp:Label></td>
                    <%--<td><input type="text" id="birthDate"/></td>--%>
                    <td><asp:TextBox ID="birthDateTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Mobile"></asp:Label></td>
                    <td><asp:TextBox ID="patientMobileTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Select Test"></asp:Label></td>
                    <td><asp:DropDownList ID="selectTestDropDownList" runat="server" OnSelectedIndexChanged="selectTestDropDownList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Fee"></asp:Label></td>
                     <td><asp:TextBox ID="feeTextBoxTestReqEntryUI" runat="server" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="addButtonTestReqEntryUI" runat="server" Text="ADD" OnClick="addButtonTestReqEntryUI_Click"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="messageLabel" runat="server" ></asp:Label></td>
                </tr>
            </table>
    </fieldset>
    </div>
        <br/>
        <br/>
        <div>
            <asp:GridView ID="testReqEntryGridView" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="Total"></asp:Label></td>
                    <td><asp:TextBox ID="totalAmountTextBox" runat="server" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="saveButton" runat="server" Text="SAVE" OnClick="saveButton_Click"/></td>
                </tr>
            </table>
        </div>
    </form>
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script src="Scripts/bootstrap-datepicker.js"></script>
    <script>
        $(document).ready(function () {
            $('#birthDateTextBox').datepicker({
                format: "dd-mm-yyyy",
                weekStart: 6,
                startView: 2,
                maxViewMode: 3,
                daysOfWeekDisabled: "5",
                autoclose: true,
                todayHighlight: true
            });
        });
    </script>
</body>
</html>
