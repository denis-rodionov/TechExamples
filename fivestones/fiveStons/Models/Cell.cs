using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fiveStons.Models
{
    public enum Sign { Red=1, Blue=2 }

    public class Cell
    {
        public Cell(string cellName, Sign sign)
        {
            // TODO: Complete member initialization
            this.Name = cellName;
            this.Sign = sign;
        }

        public string Name { get; set; }
        public Sign Sign { get; set; }

        public int X
        {
            get
            {
                string[] arr = Name.Split('_');
                return int.Parse(arr[0]);
            }
        }

        public int Y
        {
            get
            {
                string[] arr = Name.Split('_');
                return int.Parse(arr[1]);
            }
        }

        public override string ToString()
        {
            return Name;
        }
            
    }
}