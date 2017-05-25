<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntryCountry.aspx.cs" Inherits="CountryManagementApp.EntryCountry" %>

<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>--%>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Entry Country</title>
    <link href="../CSS/Style.css" rel="stylesheet" />
    
</head>
<body>
   <div>
         <h2 class="Align_Center whiteColor">Country & City Information Management System </h2>
    </div>
    <form id="form1" runat="server">
    <div class="city">
        <fieldset>
            <legend><h3 class="whiteColor">Country Entry</h3></legend>
            <div class="city">
                <h3>
                    <asp:Label ID="Label1" runat="server" Class="whiteColor" Text="Name"></asp:Label>
                    <asp:TextBox ID="nameTextBox" runat="server" Height="21px" Width="137px" style="margin-left: 14px"></asp:TextBox>
                </h3> 
                
                 <div style="float: left">
                     <div style="float: left">
                           <h3>
                                <asp:Label ID="Label3" runat="server" Class="whiteColor" Text="About    &nbsp;"></asp:Label>   
                           </h3>
                     </div>
                     <div style="float: left">
                          <%-- <asp:ScriptManager ID="ScriptManager1" runat="server">
                           </asp:ScriptManager>
                           <asp:TextBox ID="aboutTextBox" runat="server" Height="155px" Width="617px" style="margin-left: 58px"></asp:TextBox>
                           <ajaxToolkit:HtmlEditorExtender ID="aboutTextBox_HtmlEditorExtender" runat="server" TargetControlID="aboutTextBox">
                           </ajaxToolkit:HtmlEditorExtender>--%>
                          <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server"></CKEditor:CKEditorControl>
                     </div>                      
                             
                 </div>                                       
                <div style="clear: both">
                    <br />
                    <asp:Button ID="saveCountryButton" runat="server" Text="Save" Width="78px" OnClick="saveCountryButton_Click"  />
                    <asp:Button ID="cancelButton" runat="server" Text="Cancel" Width="78px" style="margin-left: 34px" OnClick="cancelButton_Click"  />
                    <br />
                    <asp:Label ID="messageLabel" runat="server" Class="whiteColor" style="font-size: 20px" Text="&nbsp;"></asp:Label>
                    <br />
                   <br />
                </div>
            </div>
                   
             <asp:GridView ID="CountryEntryGridView" runat="server" HorizontalAlign="Center" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="879px" Height="177px" AllowPaging="True" OnPageIndexChanging="CountryEntryGridView_PageIndexChanging" PageSize="5">                 
                 <Columns>
                     <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>
                            <%#Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">                      
                        <ItemTemplate>
                            <%#Eval("CountryName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="About">
                        <ItemTemplate>                       
                            <%#Eval("CountryAbout") %>
                        </ItemTemplate>
                    </asp:TemplateField>                      
                </Columns>  

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
            <br /> 
        </fieldset>
       
        
        
        
   
        

    </div>
    </form>
    <footer style="margin: 0px 200px 0px 200px" Class="whiteColor">
    <%--<p style="float: left"><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Home.aspx" Font-Underline="False" Class="whiteColor">Previous  Page</asp:HyperLink></p>--%> 
         <p style="float: left"><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="NewIndex.aspx" Font-Underline="False" Class="whiteColor">Previous  Page</asp:HyperLink></p> 
   
         <p style="float: right"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="EntryCity.aspx" Font-Underline="False" Class="whiteColor">Next Page</asp:HyperLink></p> 
       
        <p >BASIS Institute of Technology & management (BITM) </p>
         <p>Copyright &copy; MATS-2016</p>
   
    </footer>
</body>
</html>
