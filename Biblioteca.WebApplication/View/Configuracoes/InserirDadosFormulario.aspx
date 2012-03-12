<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="InserirDadosFormulario.aspx.cs" Inherits="Biblioteca.WebApplication.View.Configuracoes.InserirDadosFormulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        criar dados</h2>
    <table>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td>
                Nome do Livro
            </td>
            <td>
                <asp:TextBox ID="txbLivro" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Autor
            </td>
            <td>
                <asp:TextBox ID="txbAutor" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Salvar" onclick="Button1_Click" />
</asp:Content>
