<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoCriarDB.aspx.cs" Inherits="Biblioteca.WebApplication.View.Configuracoes.AutoCriarDB" ViewStateMode="Disabled" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Auto criar banco de dados</h2>
    <h3>
        cuidado!! todos os dados e tabelas serão apagados</h3>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Criar DB" 
            onclick="Button1_Click" />
    </p>
</asp:Content>
