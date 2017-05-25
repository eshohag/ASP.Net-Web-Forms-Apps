<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CountryManagementApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="../CSS/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="MarginBody">
            <h1 class="Align_Center">Country & City Information Management System </h1>
            <h3 class="Align_Center">Presented By - MATS</h3>
            <fieldset class="whiteFieldset">
                <legend>
                    <h3>Entry Section</h3>
                </legend>
                <h2 class="Align_Center">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="EntryCountry.aspx" Font-Underline="False" >Entry Country</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="EntryCity.aspx" Font-Underline="False" >Entry City</asp:HyperLink>
                    <br />
                    <br />
                </h2>
            </fieldset>
            <br />
            <fieldset class="whiteFieldset">
                <legend>
                    <h3>Display Section</h3>
                </legend>
                <h2 class="Align_Center">
                    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="ViewCities.aspx" Font-Underline="False" >View Cities</asp:HyperLink>
                    <br />
                    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="ViewCountries.aspx" Font-Underline="False">View Countries</asp:HyperLink>
                    <br />
                    <br />
                </h2>
            </fieldset>
        </div>
    </form>
    <br/>
    <div class="Align_Left">
        <table >
            <tr>
                <th>Project No: 01</th>
            </tr>
             <tr>
                <th>Project Title: Country & City Information Management System </th>
            </tr>
             <tr>
                <th>Group Name: MATS</th>
            </tr>
             <tr>
                <th>Batch No: DN-20 </th>
            </tr>          
        </table>


    </div>
    <br/>
    <br/>
    <footer>
        <p>BASIS Institute of Technology & management (BITM) </p>
         <p>Copyright &copy; MATS-2016</p>
    </footer>
</body>
</html>
