using System.Collections.Generic;
using fiveStons.Models;
using System.Linq;
using System;
using System.Web.Mvc;

namespace fiveStons.Models
{
    public class PlayerManager
    {
        static PlayerManager _instatnce;

        public List<Game> GameList { get; set; }
        public FiveStonesEntities DB { get; private set;  }

        private PlayerManager()
        {
            GameList = new List<Game>();
            DB = new FiveStonesEntities();
        }

        public static PlayerManager GetInstance()
        {
            if (_instatnce == null)
                _instatnce = new PlayerManager();
            return _instatnce;
        }

        public Player FindPlayer(string name)
        {
            var res = DB.Players.Where(p => p.name == name);
            if (res.Count() == 1)
                return res.Single();
            else if (res.Count() == 0)
                return null;
            else
                throw new Exception("More than one player with the same name");
        }

        public Game FindInvintation(Player player)
        {
            var res = GameList.Where(g => g.SecondPlayer == player);
            if (res.Count() == 1)
                return res.Single();
            else
                return null;
        }

        public void StartGame(Game game)
        {
            game.Started = true;
            log("Игрок '" + game.FirstPlayer + "' и игрок '" +
                game.SecondPlayer + "' начали игру!");
        }

        public Game FindGame(Player player)
        {
            var res = GameList.Where(g => g.SecondPlayer == player || g.FirstPlayer == player);
            if (res.Count() == 1)
                return res.Single();
            else
                return null;
        }

        public void NewGame(Player first, Player second)
        {
            Game newGame = new Game(first, second);
            GameList.Add(newGame);

            // clear all other games with current players
            GameList.RemoveAll(g => g != newGame && (g.FirstPlayer == newGame.FirstPlayer ||
                                                          g.FirstPlayer == newGame.SecondPlayer ||
                                                          g.SecondPlayer == newGame.FirstPlayer ||
                                                          g.SecondPlayer == newGame.SecondPlayer));
        }

        public void deleteCreatedGames(Player player)
        {
            var games = GameList.Where(g => g.FirstPlayer == player);
            if (games.Count() > 0)
                GameList.Remove(games.Single());
        }

        internal void deleteGame(Game game)
        {
            GameList.Remove(game);
        }

        internal void deleteStertedGames(Player player)
        {
            int count = GameList.RemoveAll(g => g.Started && (g.FirstPlayer == player || g.SecondPlayer == player));
            if (count != 0)
                log("Игрок '" + player + "' покинул игру!");
        }

        public void LogPlayerOn(Player p, bool on)
        {
            p.logged_on = on;
            DB.SaveChanges();
            log("Игрок '" + p + (on ? "' вошёл в систему!" : "' вышел из системы"));
        }

        public bool isLoggedOn(string name)
        {
            try
            {
                return FindPlayer(name).logged_on.Value;
            }
            catch
            {
                return false;
            }
        }

        public void LogPlayerOn(string name, bool on)
        {
            try
            {
                Player p = FindPlayer(name);
                LogPlayerOn(p, on);
            }
            catch { }
        }

        public void AddPlayer(Player p)
        {
            DB.Players.AddObject(p);
            DB.SaveChanges();
        }

        public List<Player> getOpponentList(Player me)
        {
            var pl = DB.Players.Where(p => (p.name != me.name && p.logged_on == true));
            return pl.ToList();
        }

        public Player findMe(Controller controller)
        {
            string name = controller.User.Identity.Name;
            return FindPlayer(name);
        }

        public void log(string eventDescription)
        {
            Log newEvent = new Log();
            newEvent.event_time = DateTime.Now;
            newEvent.event_desc = eventDescription;

            DB.Log.AddObject(newEvent);
            DB.SaveChanges();
        }
    }
}