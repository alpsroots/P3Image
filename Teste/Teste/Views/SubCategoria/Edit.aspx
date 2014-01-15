<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" Inherits="System.Web.Mvc.ViewPage<Teste.Models.SubCategoriaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Editar Sub-Categoria</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <%: Html.HiddenFor(model => model.Id) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Categoria) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.Categoria.Id, new SelectList(ViewBag.lstCategoria, "Id", "Descricao"), "-- Selecione --") %>
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
        <table border="1">
            <tr>
                <td></td>
                <th>Ordem</th>
                <th>Descrição</th>
                <th>Tipo</th>
            </tr>
            <% for (int i=0;i<Model.Campos.Count;i++)
           { %>
                <tr>
                    <td>
                        <%: Html.HiddenFor(model => model.Campos[i].Id) %>
                        <%: Html.HiddenFor(model => model.Campos[i].IdSubCategoria) %>
                    </td>
                    <td>
                        <%: Html.TextBoxFor(model => model.Campos[i].Ordem) %>
                    </td>
                    <td>
                        <%: Html.TextBoxFor(model => model.Campos[i].Descricao) %>
                    </td>
                    <td>
                        <%: Html.TextBoxFor(model => model.Campos[i].Tipo) %>
                    </td>
                </tr>
            <% } %>
        </table>
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
