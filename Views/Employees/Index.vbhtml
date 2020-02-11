@ModelType IEnumerable(Of testing.testing.Employee)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>
<h1>***Hi there**</h1>
<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.city)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.state)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.city)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.state)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
