using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using fiveStons.Models;
using System.Web.UI;

namespace fiveStons.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewData["message"] = Request.Params["message"];
            IndexModel model = loadIndexData(null);
            if (model.Me != null)
                PlayerManager.GetInstance().deleteStertedGames(model.Me);
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Index(IndexModel postModel)
        {
            IndexModel model = loadIndexData(postModel);

            if (postModel.SelectedPlayer == null)  // gamer is not selected
            {
                ViewData["error"] = "Choose a player to start the game";
                return View(model);
            }
            else
            {
                Player opponent = PlayerManager.GetInstance().FindPlayer(postModel.SelectedPlayer.First());

                PlayerManager.GetInstance().NewGame(model.Me, opponent);
                return RedirectToAction("game");
            }
        }

        public ActionResult Accept()
        {
            IndexModel model = loadIndexData(null);
            PlayerManager.GetInstance().StartGame(model.Invintation);
            return RedirectToAction("Game");
        }

        public ActionResult Decline()
        {
            IndexModel model = loadIndexData(null);
            PlayerManager.GetInstance().deleteGame(model.Invintation);
            return View("Index", model);
        }

        private IndexModel loadIndexData(IndexModel postModel)
        {
            IndexModel model = new IndexModel();
            model.Me = PlayerManager.GetInstance().findMe(this);
            
            if (model.Me != null)
            {
                model.Players = PlayerManager.GetInstance().getOpponentList(model.Me);
            
                if (postModel != null)
                    model.SelectedPlayer = postModel.SelectedPlayer;

                // check invintations
                model.Invintation = PlayerManager.GetInstance().FindInvintation(model.Me);
            }

            return model;
        }

        public ActionResult Game()
        {
            Player me = PlayerManager.GetInstance().findMe(this);
            Game g = PlayerManager.GetInstance().FindGame(me);
            if (me == null)
                return Redirect("/account/logon");
            else if (g == null)
                return Redirect("/home/index");
            else          // load page
            {
                ViewData["player_color"] = (me == g.FirstPlayer ? "red" : "blue");
                ViewData["turn"] = (me == g.Turn ? 1 : 0);
                ViewData["started"] = (g.Started ? 1 : 0);
                ViewData["winner"] = (g.Winner == null ? "null" : (g.FirstPlayer == g.Winner ? "red" : "blue"));

                return View();
            }
        }

        public ActionResult Turn()
        {
            Player me = PlayerManager.GetInstance().findMe(this);
            Game g = PlayerManager.GetInstance().FindGame(me);
            if (g != null)
            {
                g.makeTurn(me, Request.Params["cell"]);
                if (g.Winner == me)
                    return Json("win", JsonRequestBehavior.AllowGet);
                else
                    return Json("OK", JsonRequestBehavior.AllowGet);
            }
            else
                return null;
        }

        public ActionResult Check_Turn()
        {
            Player me = PlayerManager.GetInstance().findMe(this); 
            Game g = PlayerManager.GetInstance().FindGame(me);
            if (g == null)
                return Json("GameLeave", JsonRequestBehavior.AllowGet);
            else if (g.Winner != null)
                return Json("opponent_win", JsonRequestBehavior.AllowGet);
            else if (g.Turn == me)
                return Json(g.CellList, JsonRequestBehavior.AllowGet);
            else
                return null;
        }

        public ActionResult Check_Invite()
        {
            IndexModel model = loadIndexData(null);
            return PartialView("InteractPanel", model);
        }

        public ActionResult Get_Field()
        {
            Game g = PlayerManager.GetInstance().FindGame(
                    PlayerManager.GetInstance().findMe(this));
            if (g != null)
                return Json(g.CellList, JsonRequestBehavior.AllowGet);
            else
                return null;
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
