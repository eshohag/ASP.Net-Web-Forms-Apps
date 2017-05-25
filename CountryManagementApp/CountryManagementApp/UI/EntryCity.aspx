<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntryCity.aspx.cs" Inherits="CountryManagementApp.EntryCity" %>

<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>--%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Entry City</title>
    <link href="../CSS/Style.css" rel="stylesheet" />
</head>
<body>
     <div>
          <h2  class="Align_Center whiteColor">Country & City Information Management System </h2>
     </div>
    <form id="form2" runat="server">
    <div class="city">
        <fieldset>
            <legend><h3 class="whiteColor">City Entry</h3></legend>
            <div class="city">
                <h3>
                   <asp:Label ID="Label1" runat="server" class="whiteColor" Text="Name"></asp:Label>
                    <asp:TextBox ID="nameTextBox" runat="server" Height="21px" Width="137px" style="margin-left: 168px"></asp:TextBox>                                 
                </h3>
              
                 <div style="float: left">
                     <div style="float: left">
                           <h3>
                                <asp:Label ID="Label2" runat="server" class="whiteColor" Text="About    &nbsp;"></asp:Label>   
                           </h3>
                     </div>
                     <div style="float: left">                                              
<%--                           <asp:ScriptManager ID="ScriptManager1" runat="server">
                           </asp:ScriptManager>
                           <asp:TextBox ID="aboutTextBox" runat="server" Height="140px" Width="565px" style="margin-left: 58px"></asp:TextBox>                          
                           <ajaxToolkit:HtmlEditorExtender ID="aboutTextBox_HtmlEditorExtender" runat="server" TargetControlID="aboutTextBox">
                           </ajaxToolkit:HtmlEditorExtender>--%>
                          <CKEditor:CKEditorControl ID="CKEditor1" runat="server"></CKEditor:CKEditorControl>
                     </div>                      
                             
                 </div>
               <div style="clear:both">
                    <h3>
                       <br/>      
                       <asp:Label ID="Label3" runat="server" class="whiteColor" Text="No of dwellers"></asp:Label>
                       <asp:TextBox ID="noOfDwellersTextBox" runat="server" Height="23px" Width="137px" style="margin-left: 100px"></asp:TextBox>
                   </h3> 
                     <h3 >
                       <asp:Label ID="Label4" runat="server" class="whiteColor" Text="Location"></asp:Label>
                       <asp:TextBox ID="locationTextBox" runat="server" Height="23px" Width="137px" style="margin-left: 144px"></asp:TextBox>
                   </h3> 
                     <h3 >
                       <asp:Label ID="Label5" runat="server" class="whiteColor" Text="Weathers"></asp:Label>
                       <asp:TextBox ID="weathersTextBox" runat="server" Height="23px" Width="135px" style="margin-left: 139px"></asp:TextBox>
                   </h3> 
                     <h3>
                       <asp:Label ID="Label6" runat="server" class="whiteColor" Text="Country"></asp:Label>
                         <asp:DropDownList ID="countryDropDownList" runat="server" style="margin-left: 148px" Height="27px" Width="141px"></asp:DropDownList>
                   </h3> 
                </div>
                <asp:Button ID="saveCityButton" runat="server" Text="Save" Width="78px"  style="margin-left: 197px" OnClick="saveCityButton_Click" />
                <asp:Button ID="cancelButton" runat="server" Text="Cancel" Width="78px" style="margin-left: 6px" OnClick="cancelButton_Click"  />
                <br />
                <asp:Label ID="messageLabel" runat="server" class="whiteColor" style="font-size: 20px" Text="&nbsp"></asp:Label>
                <br />
               <br />
            </div>
            <div class="city">
                <asp:GridView ID="CityEntryGridView" runat="server" HorizontalAlign="Center" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="700px" style="margin-left: 0px" AllowPaging="True" OnPageIndexChanging="CityEntryGridView_PageIndexChanging" PageSize="5">                
                  <Columns>
                     <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>
                            <%#Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <%#Eval("CityName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="No Of Dwellers">
                        <ItemTemplate>                       
                            <%#Eval("NoOfDwellers") %>
                        </ItemTemplate>
                    </asp:TemplateField>  
                    <asp:TemplateField HeaderText="Country">
                        <ItemTemplate>                       
                            <%#Eval("Country") %>
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
          </div>
        </fieldset>
    </div>
    </form>
     <%--<script
			  src="https://code.jquery.com/jquery-1.4.1.js"
			  integrity="sha256-ntyfgTeB7KKq1t5474XNvpLuMrsKVnkb5NoPp7Rywdg="
			  crossorigin="anonymous">
           
      </script>
    <script src="../ckeditor/ckeditor.js"></script>
    <script src="../ckeditor/adapters/jquery.js"></script>
        <script type="text/javascript">
            $(function () {
                CKEDITOR.replace('<%=CKEditor1.ClientID %>',
                {
                    filebrowserImageUploadUrl: '/CountryManagementApp/Upload.ashx'
                    // filebrowserImageUploadUrl: '/CKeditorDemo/Upload.ashx'
                });                                                                //path to “Upload.ashx”
            });
        </script>--%>
    <footer style="margin: 0px 200px 0px 200px" class="whiteColor">
    <p style="float: left"><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="EntryCountry.aspx" Font-Underline="False" class="whiteColor">Previous  Page</asp:HyperLink></p> 
     <p style="float: right"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="ViewCities.aspx" Font-Underline="False" class="whiteColor">Next Page</asp:HyperLink></p> 
    <p>BASIS Institute of Technology & management (BITM) </p>
         <p>Copyright &copy; MATS-2016</p>
         </footer>
</body>
</html>
