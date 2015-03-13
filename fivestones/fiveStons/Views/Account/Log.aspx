<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Log
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Журнал</h2>

    <table>
    <tbody>
    <tr><th>Время</th><th>Описание события</th></tr>
    <% foreach (fiveStons.Log p in (IEnumerable<fiveStons.Log>)ViewData["logs"])
       { %>
            <tr>
                <td><%= p.event_time %></td>
                <td><%= p.event_desc %></td>
            </tr>
    <% } %>
    </tbody>
    </table>

</asp:Content>
