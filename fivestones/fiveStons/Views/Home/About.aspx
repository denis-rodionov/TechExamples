<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About Us
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>О программе</h2>
    <p>
        Игра "Пять камней" была развита как альтернатива игры "Крестики-нолики". Как и в вышеупомянутой игре, чтобы выиграть,
        нам неообходимо выстроить в ряд определенное колличество символов(в нашем случае 5 камней), и если в крестиках-ноликах
        поле было маленким, то в данном случае его хватает для комфортной игры. Не стоит недооценивать сложность этой игры - 
        если немного потренироваться то обыграть вас будет крайне трудно.
        <br><br>Автор: Никита Родионов Иу7-71.
    </p>
</asp:Content>