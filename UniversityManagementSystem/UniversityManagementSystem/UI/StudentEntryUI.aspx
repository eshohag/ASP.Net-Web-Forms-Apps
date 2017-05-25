﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntryUI.aspx.cs" Inherits="UniversityManagementSystem.UI.StudentEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Registration Number"></asp:Label></td>
            <td>
                <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
            <td>
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label></td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Contact Number"></asp:Label></td>
            <td>
                <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label></td>
            <td>
                <asp:DropDownList ID="departmentDropDownList" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="messageLabel" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        <asp:HyperLink ID="homeHyperLink" runat="server" NavigateUrl="HomeUI.aspx">Home</asp:HyperLink>
    </div>
    </form>
</body>
</html>
