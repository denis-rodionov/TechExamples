<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    bool logged = false;
    if (Request.IsAuthenticated) {
        logged = fiveStons.Models.PlayerManager.GetInstance().isLoggedOn(Page.User.Identity.Name);        
        if (logged == false)
        {
            fiveStons.Models.PlayerManager.GetInstance().LogPlayerOn(Page.User.Identity.Name, false);
            %>
            [ <%: Html.ActionLink("Войти", "LogOn", "Account") %> ]
            <%
        }
%>
        Здравствуйте <b><%: Page.User.Identity.Name %></b>!
        [ <%: Html.ActionLink("Выйти", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Войти", "LogOn", "Account") %> ]
<%
    }
%>
