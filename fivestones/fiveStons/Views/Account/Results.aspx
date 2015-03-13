<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Results
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Результаты</h2>

    <table>
    <tbody>
    <tr><th>Игрок</th><th>В сети</th><th>Побед</th><th>Поражений</th></tr>
    <% foreach (fiveStons.Player p in (IEnumerable<fiveStons.Player>)ViewData["players"])
       { %>
            <tr>
                <td><%= p.name %></td>
                <td><%= p.logged_on.Value ? "Онлайн" : "Не в системе" %></td>
                <td><%= p.vin_count %></td>
                <td><%= p.lose_count %></td>
            </tr>
    <% } %>
    </tbody>
    </table>

</asp:Content>
