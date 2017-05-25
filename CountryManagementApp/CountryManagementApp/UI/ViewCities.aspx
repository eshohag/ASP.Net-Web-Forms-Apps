<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryManagementApp.ViewCities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Cities</title>
    <link href="../CSS/Style.css" rel="stylesheet" />
</head>
<body>
    <div  class="Align_Center whiteColor">
        <h2 >Country & City Information Management System </h2>
    </div>
    <div class="margin100px">
         <form id="form1" runat="server">
            <fieldset>
            <legend><h3 class="whiteColor">View Cities</h3></legend>
                <div class="city">
                    <fieldset style="width: 696px">
                        <legend><h4 class="whiteColor">Search Criteria</h4></legend>
                        <br/>
                        <div class="citySearce">
                            <asp:RadioButton ID="cityNameRadioButton" runat="server" GroupName="aa" class="whiteColor" Text="City Name"/>
                            <asp:TextBox ID="cityNameTextBox" runat="server" style="margin-left: 48px"></asp:TextBox>
                            <br/>
                            <br/>
                            <asp:RadioButton ID="countryRadioButton" runat="server" GroupName="aa" class="whiteColor" Text="Country Name" />
                            <asp:DropDownList ID="CountryDropDownList" runat="server" Height="25px" style="margin-left: 26px" Width="148px">
                            </asp:DropDownList>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="searchButton" runat="server" Text="Search"  Width="148px" OnClick="searchButton_Click" style="margin-left: 35px" />
                        </div>
                        <asp:Label ID="messageLabel" runat="server" class="whiteColor" Style="font-size: 20px" Text="&nbsp"></asp:Label>
                        <br/>
                    </fieldset>
                </div>
                <br/>
          <div class="city">
             <asp:GridView ID="CountryEntryGridView" runat="server" HorizontalAlign="Center" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="700px" Height="213px" AllowPaging="True" OnPageIndexChanging="CountryEntryGridView_PageIndexChanging" PageSize="5">
                  <Columns>
                     <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>
                            <%#Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City Name">
                        <ItemTemplate>
                            <%#Eval("CityName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                      <asp:TemplateField HeaderText="About">
                        <ItemTemplate>
                            <%#Eval("CityAbout") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="No Of Dwellers">
                        <ItemTemplate>                       
                            <%#Eval("NoOfDwellers") %>
                        </ItemTemplate>
                    </asp:TemplateField>  
                     <asp:TemplateField HeaderText="Location">
                        <ItemTemplate>
                            <%#Eval("Location") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Weather">
                        <ItemTemplate>
                            <%#Eval("Weather") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Country">
                        <ItemTemplate>                       
                            <%#Eval("CountryName") %>
                        </ItemTemplate>
                    </asp:TemplateField>   
                    <asp:TemplateField HeaderText="About Country">
                        <ItemTemplate>
                            <%#Eval("AboutCountry") %>
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
    <p style="float: left"><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="EntryCity.aspx" Font-Underline="False" class="whiteColor">Previous  Page</asp:HyperLink></p> 
     <p style="float: right"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="ViewCountries.aspx" Font-Underline="False" class="whiteColor">Next Page</asp:HyperLink></p> 
    <p>BASIS Institute of Technology & management (BITM) </p>
         <p>Copyright &copy; MATS-2016</p>
     </footer>  
     
</body>
</html>
