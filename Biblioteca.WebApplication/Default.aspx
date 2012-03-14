<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Biblioteca.WebApplication._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            font-size: small;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h1>
        Biblioteca .NET
    </h1>
    <h3>Utilizando as Seguinte Tecnologias</h3>
    <ul>
        <li><h3>NHibernate 3</h3></li>
        <li><h3>Castle Windsor - IoC</h3>
        </li><li><h3>Ajax</h3></li>
        <li><h3>Jquery</h3></li>
    </ul>
    <pre class="style1">Developed by : Fabio Rattis and Yuri Feitosa </pre>

</asp:Content>
