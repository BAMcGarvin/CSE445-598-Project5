<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="DefaultPage.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>CONTACT PAGE</h3>

    <teamname>
        &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Underline="True" Text="Team"></asp:Label>
    <br />
        CSE 445/598 Team 61 <br />
        ASU Fall 2020 <br />
    </teamname>
    <br />
    <members>
        &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" Text="Team Members"></asp:Label>
    <br />
        Bradley McGarvin <br />
        Gabriel Anderson <br />
        Jessica Wood <br />
    </members>

    <br />
    <br />

    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
