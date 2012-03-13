<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" ClientIDMode="Static" ViewStateMode="Disabled"
    CodeBehind="CriarDados.aspx.cs" Inherits="Biblioteca.WebApplication.View.Configuracoes.CriarDados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        criar dados</h2>
    <table>
        <tr>
            <td colspan="2">
                <h3>
                    Autor</h3>
            </td>
        </tr>
        <tr>
            <td>
                Nome do Autor:
            </td>
            <td>
                <asp:TextBox ID="txbAutor" runat="server"></asp:TextBox>
                <input type="button" id="btInsAutor" value="Salvar" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <h3>
                    Estante</h3>
            </td>
        </tr>
        <tr>
            <td>
                Categoria:
            </td>
            <td>
                <asp:TextBox ID="txbEstante" runat="server"></asp:TextBox>
                <input type="button" id="btInsEstante" value="Salvar" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <h3>
                    Prateleira</h3>
            </td>
        </tr>
        <tr>
            <td>
                Classe:
            </td>
            <td>
                <asp:TextBox ID="txbPrateleira" runat="server"></asp:TextBox>
                <input type="button" id="btInsPrateleira" value="Salvar" />
            </td>
            <tr>
                <td>
                    Estante
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListEstante" runat="server" DataTextField="Categoria"
                        DataValueField="Id" ViewStateMode="Disabled" Height="16px">
                    </asp:DropDownList>
                </td>
            </tr>
        </tr>
    </table>
    <br />
    <script src="././././../../Scripts/jquery-1.6.4.min.js" type="text/javascript"> </script>
    <script type="text/javascript">

        $("#btInsAutor").click(function () {

            var dados = {
                Autor: $("#txbAutor").val()
            };

            var request = $.ajax({
                type: "POST",
                url: "CriarDados.aspx?InserirAutor=1",
                data: dados
            });

            request.done(function (data) {
                $("#divResultado").html(data);
                alert('Salvo com Sucesso!!!');
            });

            request.fail(function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            });
        });

        $("#btInsEstante").click(function () {

            var dados = {
                Categoria: $("#txbEstante").val()
            };

            var request = $.ajax({
                type: "POST",
                url: "CriarDados.aspx?InserirEstante=1",
                data: dados
            });

            request.done(function (data) {
                $("#divResultado").html(data);
                alert('Salvo com Sucesso!!!');
            });

            request.fail(function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            });
        });

        $("#btInsPrateleira").click(function () {

            var dados = {
                Estante: $("#DropDownListEstante").val(),
                Classe: $("#txbPrateleira").val()
            };

            var request = $.ajax({
                type: "POST",
                url: "CriarDados.aspx?InserirPrateleira=1",
                data: dados
            });

            request.done(function (data) {
                $("#divResultado").html(data);
                alert('Salvo com Sucesso!!!');
            });

            request.fail(function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            });
        });
    </script>
</asp:Content>
