<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<fiveStons.Models.GameModel>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Game
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type = "text/javascript" src="../../Scripts/game.js">
</script>
<h2>Game</h2>
<h3 id="message"></h3>
<%: Html.Hidden("player_color", ViewData["player_color"]) %>
<%: Html.Hidden("turn", ViewData["turn"]) %>
<%: Html.Hidden("started", ViewData["started"]) %>
<%: Html.Hidden("winner", ViewData["winner"]) %>
<table>
<% 
    const int N=30;
    for (int i=1; i<=N; i++)
    {
%>
        <tr>
<%
        for (int j=1; j<=N; j++)
        {
%>
            <td id="<%: i+ "_" +j %>" class="empty_cell" onclick="click_handler('<%: i+ "_" +j %>')">
            </td> 
<%            
        }
%>
        </tr>
<%
    }
%>
</table>
<h3 id="lower_message"></h3>
</asp:Content>