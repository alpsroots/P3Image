<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" Inherits="System.Web.Mvc.ViewPage<Teste.Models.FormModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<%: Scripts.Render("~/bundles/jquery") %>

<script type="text/jscript">
    $(function () {          
        $('#CategoriasID').change(function () {
            $.getJSON('/Form/SubCategoriasList?idCategoria=' + $('#CategoriasID').val(), function (data) {
                var items = '<option>-- Selecione --</option>';
                $.each(data, function (i, subcategoria) {
                    items += "<option value='" + subcategoria.Value + "'>" + subcategoria.Text + "</option>";
                });
                $('#SubCategoriasID').html(items);
            });
        });
    });
</script>

<h2>Gerar Formulário</h2>
<% using (Html.BeginForm("Index", "Form", FormMethod.Post))
   { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset> 
        <table>
            <tr>
                <td>
                    <%: Html.Label("Categorias") %>
                </td>
                <td>
                    <%: Html.DropDownList("CategoriasID", new SelectList(ViewBag.Categorias , "Id", "Descricao"), "-- Selecione --", new { id = "CategoriasID" }) %>
                </td>
            </tr>
            <tr>

                <td>
                    <%: Html.Label("Sub-Categorias") %>
                </td>
                <td>
                    <select id="SubCategoriasID" name="SubCategoriasID"></select>
                </td>
            </tr>
        </table>       
        <p>
            <input type="submit" value="Visualizar" id="SubmitID" />
        </p>
        <br/>
        <% if (Model == null) return; %>

        <% for (int i=0;i<Model.Controles.Count;i++) { %>

            <% switch (Model.Controles[i].Type)
            {
                case "textbox":
                    %>    
                    <%: Html.Label(Model.Controles[i].Label) %>
                    <%: Html.TextBox(Model.Controles[i].Name) %>
                    <br /><br />
                    <% break;
                case "textarea":
                    %>
                    <%: Html.Label(Model.Controles[i].Label) %>
                    <%: Html.TextArea(Model.Controles[i].Name) %>      
                    <br /><br />
                    <% break;
                case "checkbox":
                    %>
                    <%: Html.Label(Model.Controles[i].Label) %>
                    <% foreach (var x in Model.Controles[i].Values.Items)
                       { %> 
                            <%: Html.CheckBox(((Teste.Models.ListaCamposModel)(x)).Descricao) %>
                    <% } %>
                    <br /><br />
                    <% break;
                case "select":
                    %>
                    <%: Html.Label(Model.Controles[i].Label) %>    
                    <%: Html.DropDownList(Model.Controles[i].Name, Model.Controles[i].Values) %>      
                    <br /><br />
                    <% break;
                default:
                    %>      
                    <% break;                   
            } %>
        <% } %>
    </fieldset>
<% } %>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
