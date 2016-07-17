<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebFormDropdown.ascx.cs" Inherits="PartialViewExample.WebFormDropdown" %>

<div class="dropdown">
    <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
        <%=Dropdown.HeaderText %><span class="caret"></span>
    </button>
    <ul class="dropdown-menu">
        <% foreach (var m in Dropdown.Items) { %>
            <li>
                <a href="<%=m.url %>"><%=m.text %></a>
            </li>
        <% } %>
    </ul>
</div>
