<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" Inherits="System.Web.Mvc.ViewPage<Teste.Models.SubCategoriaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes Sub-Categoria</h2>

<fieldset>
    <br />
    <div class="display-label">
        <b><%: Html.DisplayNameFor(model => model.Descricao) %></b>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Descricao) %>
    </div>
    <br />
    <div class="display-label">
        <b><%: Html.DisplayNameFor(model => model.Categoria) %></b>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Categoria.Descricao) %>
    </div>
    <br />
    <div class="display-label">
        <b><%: Html.DisplayNameFor(model => model.Campos) %></b>
    </div>
    <table border="1">
        <tr>
            <th>Ordem</th>
            <th>Descrição</th>
            <th>Tipo</th>
        </tr>
        <% for (int i=0;i<Model.Campos.Count;i++)
        { %>
            <tr>
                <td>
                    <%: Html.DisplayFor(model => model.Campos[i].Ordem) %>
                </td>
                <td>
                    <%: Html.DisplayFor(model => model.Campos[i].Descricao) %>
                </td>
                <td>
                    <%: Html.DisplayFor(model => model.Campos[i].Tipo) %>
                </td>
            </tr>
            
            <% if (Model.Campos[i].ListaCampos.Count > 0)
                { %>
                <tr>
                    <th></th>
                    <th colspan="2">Lista</th>
                </tr>
                <% for (int j=0;j<Model.Campos[i].ListaCampos.Count;j++)
                    { %>
                    <tr>
                        <td></td>
                        <td colspan="2"><%: Html.DisplayFor(model => model.Campos[i].ListaCampos[j].Descricao) %></td>
                    </tr>
                <% } %>
            <% } %>
        <% } %>
    </table>
    <br />
</fieldset>
<p>
    <%: Html.ActionLink("Editar", "Edit", new { id=Model.Id }) %> |
    <%: Html.ActionLink("Voltar", "Index") %>
</p>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
