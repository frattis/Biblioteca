<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Estantes.aspx.cs" Inherits="Biblioteca.WebApplication.View.Estante.Estantes"
    ViewStateMode="Disabled" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Estante de Livros</h1>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Inserir dados Teste!" />
    </p>
    <h4>Estantes</h4>
    <asp:GridView ID="grvEstante" runat="server" >
    
    </asp:GridView>
    <br />
     <h4>Prateleiras</h4>
    <asp:GridView ID="grvPrateleira" runat="server">
    </asp:GridView>
    <br />
     <h4>Autores</h4>
    <asp:GridView ID="grvAutores" runat="server">
    </asp:GridView>
    <br />
     <h4>Livros</h4>
    <asp:GridView ID="grvLivros" runat="server">
    </asp:GridView>
    <br />
</asp:Content>
