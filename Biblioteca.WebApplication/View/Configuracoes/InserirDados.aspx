<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="InserirDados.aspx.cs" Inherits="Biblioteca.WebApplication.View.Configuracoes.InserirDados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <input type="button" id="btInsAutor" value="Inserir dados teste!" />
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
