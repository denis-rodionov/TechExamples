<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<fiveStons.Models.IndexModel>" %>

<%
if (Model.Invintation != null && !Model.Invintation.Started)
   {
%>
        <div id="interact_panel">
           <p>Player <%: Model.Invintation.FirstPlayer.name %> invite you to join the game</p>
<%
           using (Html.BeginForm("Accept", "Home"))
           {
    %>           
               <input type="submit" value="Accept" />          
    <%
           }
       
           using (Html.BeginForm("Decline", "Home"))
           {
    %>           
               <input type="submit" value="Decline" />          
    <%
           }
%>
       </div>
<%
   }
%>

