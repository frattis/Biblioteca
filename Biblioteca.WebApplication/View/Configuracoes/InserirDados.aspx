<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="InserirDados.aspx.cs" Inherits="Biblioteca.WebApplication.View.Configuracoes.InserirDados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Auto criar banco de dados</h2>
    <h3>
        cuidado!! todos os dados e tabelas serão apagados</h3>
    <table>
        <tr>
            <td colspan="2">
                <h2>
                    Livros</h2>
            </td>
        </tr>
        <tr>
            <td>
                <h3>
                    Titulo</h3>
            </td>
            <td>
                <h3>
                    Autor</h3>
            </td>
        </tr>
        <tr>
            <td>
                Era uma Vez
            </td>
            <td>
                Mario
            </td>
        </tr>
        <tr>
            <td>
                João e Maria
            </td>
            <td>
                Mario
            </td>
        </tr>
        <tr>
            <td>
                João e o pé de feijão
            </td>
            <td>
                Luis
            </td>
        </tr>
        <tr>
            <td>
                Os três porquinhos
            </td>
            <td>
                Luis
            </td>
        </tr>
    </table>
    <br/>
    <input type="button" id="btInsAutor" value="Criar DB" />
    <script src="././././../../Scripts/jquery-1.6.4.min.js" type="text/javascript"> </script>
    <script type="text/javascript">

        $("#btInsAutor").click(function () {

            var dados = {};

            var request = $.ajax({
                type: "POST",
                url: "InserirDados.aspx?Inserir=1",
                data: dados
            });

            request.done(function (data) {
                $("#divResultado").html(data);
            });

            request.fail(function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            });
        });
    </script>
</asp:Content>
