<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" ViewStateMode="Disabled" ClientIDMode="Static"
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
                <asp:DropDownList ID="DropDownListAutor" runat="server" DataTextField="Nome" 
                    DataValueField="Id" ViewStateMode="Disabled">
                </asp:DropDownList>
                <asp:Button ID="ButtonCriarAutor" runat="server" Text="Criar" 
                    onclick="ButtonCriarAutor_Click" />
            </td>
        </tr>
         <tr>
            <td>
                Prateleira
            </td>
            <td>
                
                <asp:DropDownList ID="DropDownListPrateleira" runat="server" 
                    DataTextField="Classe" DataValueField="Id" ViewStateMode="Disabled">
                </asp:DropDownList>
                <asp:Button ID="ButtonCriarPrateleira" runat="server" Text="Criar" 
                    onclick="ButtonCriarPrateleira_Click" />
                
            </td>
        </tr>
    </table>
    <br />
    <input type="button" id="btInsAutor" value="Salvar" />
    </asp:Content>
