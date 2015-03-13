<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<fiveStons.Models.IndexModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<span id="message"><%: ViewData["message"] %></span>

<script type = "text/javascript" src="../../Scripts/index.js">
</script>
<%  if (Model.Me != null)
    {
        using (Html.BeginForm())
        {
            if (Model.Players.Count() == 0)
            {%>
                На данный момент нет ни одного свободного игрока.
            <% }
            else
            { %>
                <%: Html.ListBoxFor(m => m.SelectedPlayer, new SelectList(Model.Players, "name", "name", Model.SelectedPlayer))%>
                <input type="submit" value="Start game" />
                <%: Html.HiddenFor(m => m.Players)%>
<%          }
        }
    }
    else
    { 
%>
        Для приглашения других игроков необходимо выполнить вход!
<%  
    }
%>
    <div id="interactPanel">
<%
    Html.RenderPartial("InteractPanel"); 
%>
    </div>
</asp:Content>
