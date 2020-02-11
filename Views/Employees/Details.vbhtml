@ModelType testing.testing.Employee
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Employee</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.city)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.city)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.state)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.state)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
