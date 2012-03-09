<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Autores.aspx.cs" Inherits="Biblioteca.WebApplication.View.Autor.Autores"
    ViewStateMode="Disabled" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p class="style1">
        Autores</p>
    <p class="style1">
        <asp:GridView ID="GridView1" runat="server" style="font-size: small">
        </asp:GridView>
    </p>
</asp:Content>
