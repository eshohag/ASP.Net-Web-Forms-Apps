<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewIndex.aspx.cs" Inherits="CountryManagementApp.UI.NewIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <title>Home</title>
    <link href="../CSS/bootstrap.min.css" rel="stylesheet" />
    <link href="../CSS/FontStyle.css" rel="stylesheet" />
     <!-- Fonts -->
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800" rel="stylesheet" type="text/css"/>
    <link href="http://fonts.googleapis.com/css?family=Josefin+Slab:100,300,400,600,700,100italic,300italic,400italic,600italic,700italic" rel="stylesheet" type="text/css"/>

</head>
<body>
    <form id="form1" runat="server">
    <div>
            <div class="brand">Country & City Management System</div>
        <br/>
        <br/>
        <br/>
    <!-- Navigation -->
    <nav class="navbar navbar-default" role="navigation">
        <div class="container">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <!-- navbar-brand is hidden on larger screens, but visible when the menu is collapsed -->
                <a class="navbar-brand" href="NewIndex.aspx">Countries Management </a>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li>                      
                         <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="EntryCountry.aspx" Font-Underline="False" > Country</asp:HyperLink>
                    
                    </li>
                    <li>                  
                         <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="EntryCity.aspx" Font-Underline="False" > City</asp:HyperLink>
                    
                    </li>
                    <li>
                       <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="ViewCities.aspx" Font-Underline="False" >View Cities</asp:HyperLink>
                    
                    </li>
                    <li>
                         <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="ViewCountries.aspx" Font-Underline="False">View Countries</asp:HyperLink>
                   
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>

    <div class="container">

        <div class="row">
            <div class="box">
                <div class="col-lg-12 text-center">
                    <div id="carousel-example-generic" class="carousel slide">
                        
                    </div>
                    <h2 class="brand-before">
                    </h2>
                        <h1 class="brand-name">Our First Project</h1>
                        <hr class="tagline-divider">
                    <h3>
                       <p>Project Title: Country & City Information Management System</p>
                        <p>Group Name: MATS</p>
                        <p>Batch No: DN-20</p>
                    </h3>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="box">
                <div class="col-lg-12">
                    <h1 class="text-center">MATS Members:</h1>
                    <hr>
                    <h2 class="intro-text text-center">
                        <p>1.Md Shohag Mia</p>
                         <p>2.Tanjil Huda Sany</p>
                         <p>3.Md Sheaik Arif</p>
                         <p>4.Md Mamun Khan</p>
                    </h2>
                    <hr>                   
                    <hr class="visible-xs">			
                </div>
            </div>
        </div>

        <div class="row">
            <div class="box">
                <div class="col-lg-12">
                     <h1 class="text-center">Organized By :</h1>
                    <hr>
                    <h2 class="intro-text text-center">
                        BASIS Institute of Technology & management <strong> (BITM) 
                        </strong>
                    </h2>
                    <hr>
	
                </div>
            </div>
        </div>

    </div>
    <!-- /.container -->

    <footer>
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <p>Copyright &copy;<strong>MATS</strong>-2016</p>
                </div>
            </div>
        </div>
    </footer>

    <!-- jQuery -->
<script src="../Scripts/jquery.js"></script>
    <!-- Bootstrap Core JavaScript -->
        <script src="../Scripts/bootstrap.min.js"></script>

    <!-- Script to Activate the Carousel -->
    <script>
    $('.carousel').carousel({
        interval: 5000 //changes the speed
    })
    </script>

    </div>
    </form>
</body>
</html>
