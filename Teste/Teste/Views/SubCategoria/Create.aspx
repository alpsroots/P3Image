<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" Inherits="System.Web.Mvc.ViewPage<Teste.Models.SubCategoriaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Nova Sub-Categoria</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Categoria) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.Categoria.Id, new SelectList(ViewBag.lstCategoria , "Id", "Descricao"), "-- Selecione --") %>
            <%: Html.ValidationMessageFor(model => model.Categoria) %>
        </div>
        <br />
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Descricao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Descricao) %>
            <%: Html.ValidationMessageFor(model => model.Descricao) %>
        </div>
        <br />
        <p>
            <input type="submit" value="Salvar" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Voltar", "Index") %>
</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
