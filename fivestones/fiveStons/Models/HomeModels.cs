using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace fiveStons.Models
{
    public class IndexModel
    {
        public IndexModel()
        {
            Players = new List<Player>();
        }

        public List<Player> Players { get; set; }
        public string[] SelectedPlayer { get; set; }
        public Player Me { get; set; }
        public Game Invintation { get; set; }
    }
}