<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Teste.Models.SubCategoriaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Sub-Categorias</h2>

<p>
    <%: Html.ActionLink("Nova", "Create") %>
</p>
<table border="1">
    <tr>
        <th></th>
        <th>
            <%: Html.DisplayNameFor(model => model.Descricao) %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.Id }) %> |
            <%: Html.ActionLink("Editar", "Edit", new { id=item.Id }) %> |
            <%: Html.ActionLink("Excluir", "Delete", new { id=item.Id }) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Descricao) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
