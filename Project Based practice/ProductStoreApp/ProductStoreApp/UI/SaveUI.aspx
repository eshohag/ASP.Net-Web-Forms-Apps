<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveUI.aspx.cs" Inherits="ProductStoreApp.UI.SaveUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 596px;
        }
        .auto-style2 {
            width: 639px;
        }
        .auto-style4 {
            width: 608px;
        }
        .auto-style5 {
            width: 1302px;
        }
        .auto-style6 {
            width: 456px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
        <legend><h2>Save</h2></legend>
            <div style="text-align: center">          
                <br />
                <asp:Label ID="Label1" runat="server" Text="Product Code"></asp:Label>
                <asp:TextBox ID="codeTextBox" runat="server" Width="237px" style="margin-left: 26px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
                <asp:TextBox ID="descriptionTextBox" runat="server" Width="237px" style="margin-left: 42px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
                <asp:TextBox ID="quantityTextBox" runat="server" Width="237px" style="margin-left: 58px"></asp:TextBox>
                <br />
                 <br />
                <asp:Button ID="saveButton" runat="server" style="margin-left: 218px" Text="Save" Width="134px" OnClick="saveButton_Click" />
                <br />
                <br />

              
                
                <table>
                    <tr>
                        <td>
                            <h3 style="text-align: left">
                             <asp:HyperLink ID="homeHyperLink" runat="server" NavigateUrl="~/UI/IndexUI.aspx" Target="_blank" font-Underline="False">Home</asp:HyperLink>
                            </h3>
                        </td>
                        <td class="auto-style6">
                            
                        </td>
                         <td class="auto-style5">
                            
                        </td>
                         <td class="auto-style4">
                             <asp:Label ID="messageLabel" runat="server"></asp:Label>
                        </td>
                         <td>
                            
                        </td>
                         <td class="auto-style2">
                            
                        </td>
                         <td class="auto-style1">
                             <h3 style="text-align: right">
                               <asp:HyperLink ID="rightHyperLink" runat="server" NavigateUrl="Display.aspx" Target="_blank" Font-Underline="False">Display</asp:HyperLink>
                             </h3>
                        </td>
                    </tr>
                </table>
           </div>
      </fieldset>   
    </div>
    </form>
</body>
</html>
