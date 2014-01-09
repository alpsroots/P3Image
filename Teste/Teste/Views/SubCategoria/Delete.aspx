<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" Inherits="System.Web.Mvc.ViewPage<Teste.Models.SubCategoriaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Excluir Sub-Categoria</h2>

<h4>Tem certeza que deseja excluir essa Sub-Categoria?</h4>

<fieldset>
    <div class="display-label">
        <b><%: Html.DisplayNameFor(model => model.Descricao) %></b>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Descricao) %>
    </div>
    <br />
</fieldset>
<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <p>
        <input type="submit" value="Delete" />
    </p>
<% } %>

<div>
    <%: Html.ActionLink("Voltar", "Index") %>
</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
