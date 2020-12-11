<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DefaultPage._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div style="margin-left: auto; margin-right: auto; text-align: center;" class="jumbotron" >
        <h1>CSE 445/598 - Project 5 - Team61</h1>
        <p>Bradley McGarvin, Gabriel Anderson, Jessica Wood</p>
        <p class="lead">The Home Page of our Service-Oriented Web Application offers an area for Members, or Staff, to access corresponding pages. In order to access our Member Page to use our Services you must register. If already logged in, you will not be required to do so again. Our Web Services, for now, allow our Members to search any US Zip Code and retrieve Weather Data and and Earthquake Index related to that area. As a Staff Member, not only will staff have access to all Member Services, but on their Staff Page they will be able to add new Staff Members along with Search for Members and Staff. By clicking the Service Directory button, you can access our service directory on the Home Page.</p>
        
    </div>

    <body style="background-color:maroon">



     
        <div style="margin-left: auto; margin-right: auto; text-align: center; height: 143px; width: 833px; background-color: #FFC72A;">

            <asp:Panel ID="Panel1" runat="server" Height="151px" background-color="#FFC72A">
                <table class="nav-justified" style="height: 170px; width: 832px; position: relative; z-index: auto; background-color: #FFC72A; left: 0px; top: -22px;" contenteditable="false">
                    <tr>
                        <td style="width: auto">
                            <asp:Button ID="mLoginBtn" RunAt="server" Font-Bold="True" OnClick="mLoginBtn_Click" Text="Member Login" BackColor="#8C1D40" ForeColor="White" />
                        </td>
                        <td style="width: auto">
                            <asp:Button ID="sLoginBtn" RunAt="server" Font-Bold="True" OnClick="sLoginBtn_Click" Text="Staff Login" BackColor="#8C1D40" ForeColor="White" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: auto">
                            <asp:Button ID="mHomePageBtn" RunAt="server" Font-Bold="True" OnClick="mHomePageBtn_Click" Text="Member Home Page" Width="175px" BackColor="#8C1D40" ForeColor="White" />
                        </td>
                        <td style="width:auto">
                            <asp:Button ID="sHomePageBtn" RunAt="server" Font-Bold="True" OnClick="sHomePageBtn_Click" Text="Staff Home Page" Width="175px" BackColor="#8C1D40" ForeColor="White" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>

        </div>

        <div style="margin-left: auto; margin-right: auto; text-align: center;  height: 116px; width: 833px; background-color: #FFC72A;">                     
            
            <asp:Panel ID="Panel2" runat="server" BackColor="#FFC72A" Height="117px">
                <br />
                <table class="nav-justified" style="height: 53px">
                    <tr>
                        <td>
                            <asp:Button ID="btnServDirectory" runat="server" BackColor="#8C1D40" BorderColor="Silver" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="btnServDirectory_Click" Text="Service Directory" Width="251px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>                     
            
        </div>


        <div style="margin-left: auto; margin-right: auto; text-align: center; height: 390px; width: 833px;">

            <asp:Panel ID="serviceDirectoryPanel" runat="server" BackColor="#FFC72A" Height="386px">
                

            </asp:Panel>

        </div>

    </body>

</asp:Content>
