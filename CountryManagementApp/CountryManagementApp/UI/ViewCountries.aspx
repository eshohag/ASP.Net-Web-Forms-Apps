<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCountries.aspx.cs" Inherits="CountryManagementApp.ViewCountries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Countries</title>
    <link href="../CSS/Style.css" rel="stylesheet" />
</head>
<body>
    <div  class="Align_Center whiteColor">
        <h2 >Country & City Information Management System </h2>
    </div>
    <div class="city">
         <form id="form1" runat="server">
            <fieldset>
            <legend>
                <h3 class="whiteColor">View Countries</h3>
            </legend>              
                    <fieldset class="city">
                        <legend><h4 class="whiteColor">Search Criteria</h4></legend>
                        <br/>
                        <div  class="Align_Center whiteColor">  
                            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                            <asp:TextBox ID="countryNameTextBox" runat="server" style="margin-left: 14px" Height="25px"></asp:TextBox>
                            <asp:Button ID="searchButton" runat="server" Text="Search" style="margin-left: 19px" OnClick="searchButton_Click" Height="30px" />
                            <br/>                      
                        </div>                                         
                         <p class="Align_Center whiteColor"><asp:Label ID="messageLabel" runat="server" Text="&nbsp;"></asp:Label></p>                  
                    </fieldset>              
     <div>
               <br />
             <asp:GridView ID="ViewCountriesGridView" runat="server" HorizontalAlign="Center" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="721px" Height="213px" AllowPaging="True" OnPageIndexChanging="ViewCountriesGridView_PageIndexChanging" PageSize="5">
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
                     <%--<asp:TemplateField HeaderText="No Of Cities">--%>
                     <asp:TemplateField HeaderText="Total City">
                        <ItemTemplate>                       
                            <%#Eval("TotalCity") %>
                        </ItemTemplate>
                    </asp:TemplateField>  
                     <asp:TemplateField HeaderText="No of City Dwellers">
                        <ItemTemplate>
                            <%#Eval("TotalDwellers") %>
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
             </div>
        </fieldset>
    </form>
   </div> 
    <footer style="margin: 0px 200px 0px 200px" class="whiteColor">
    <p style="float: left"><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="ViewCities.aspx" Font-Underline="False" class="whiteColor">Previous  Page</asp:HyperLink></p> 
     <%--<p style="float: right"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Home.aspx" Font-Underline="False" class="whiteColor">Home Page</asp:HyperLink></p>--%> 
      <p style="float: right"><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="NewIndex.aspx" Font-Underline="False" class="whiteColor">Home Page</asp:HyperLink></p> 
    
        <p>BASIS Institute of Technology & management (BITM) </p>
         <p>Copyright &copy; MATS-2016</p>
         </footer>  
</body>
</html>
