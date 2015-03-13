using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fiveStons.Models
{
    enum Direction { TopLeft = 1, Top = 3, TopRight = 5, Left = 7, Right = 8, BottomLeft = 6, Bottom = 4, BottomRight = 2 }

    public class Game
    {
        const int WIN_COUNT = 5;
        const int FIELD_SIZE = 30;

        bool _started = false;

        public List<Cell> CellList { get; set; }
        public Player FirstPlayer { get; set; }      // inviter
        public Player SecondPlayer { get; set; }     // invited
        public Player Winner { get; set; }

        public Game(Player first, Player second)
        {
            FirstPlayer = first;
            SecondPlayer = second;
            Started = false;
            Turn = null;
            CellList = new List<Cell>();
        }

        // second player accepted invintation
        public bool Started { 
            get { return _started; }
            set { _started = value; if (value == true) Turn = FirstPlayer; }
        }

        public Player Turn { get; set; }

        private void finishTurn(Player player)
        {
            if (player == FirstPlayer)
                Turn = SecondPlayer;
            else if (player == SecondPlayer)
                Turn = FirstPlayer;
            else
                throw new Exception("Player not in the game!");
        }

        public void makeTurn(Player player, string cellName)
        {
            Cell newCell = new Cell(cellName, player == FirstPlayer ? Sign.Red : Sign.Blue);
            CellList.Add(newCell);
            if (isWin(newCell))
                finishGame(player);
            else
                finishTurn(player);
        }

        private void finishGame(Player player)
        {
            Winner = player;
            player.vin_count++;
            Player opponent = getOpponent(player);
            opponent.lose_count++;
            PlayerManager.GetInstance().log("Игра закончена! Победитель: '" +
                player + "', проишравший: '" + opponent + "'");
            PlayerManager.GetInstance().DB.SaveChanges();            
        }

        private Player getOpponent(Player player)
        {
            if (player == FirstPlayer)
                return SecondPlayer;
            else
                return FirstPlayer;
        }

        public bool isWin(Cell cell)
        {
            for (int i = 1; i <= 7; i += 2)
            {
                int count = dirCount((Direction)i, cell, 0) + dirCount((Direction)(i + 1), cell, 0) + 1;
                if (count >= WIN_COUNT)
                    return true;
            }

            return false;
        }

        private int dirCount(Direction direction, Cell cell, int count)
        {
            Cell curCell = getNextCell(cell, direction);

            if (curCell == null || curCell.Sign != cell.Sign)
                return count;
            else
                return dirCount(direction, curCell, ++count);
        }

        private Cell getNextCell(Cell cell, Direction direction)
        {
            int x = cell.X + getX(direction);
            int y = cell.Y + getY(direction);
            if (x < 0 || y < 0 || x >= FIELD_SIZE || y >= FIELD_SIZE)
                return null;
            else
                return getCell(x, y);
        }

        private Cell getCell(int x, int y)
        {
            var res = CellList.Where(c => c.X == x && c.Y == y);
            if (res.Count() == 1)
                return res.Single();
            else
                return null;
        }

        private int getX(Direction direction)
        {
            switch (direction)
            {
                case Direction.Bottom:      return 0;
                case Direction.BottomLeft: return -1;
                case Direction.BottomRight: return 1;
                case Direction.Left: return -1;
                case Direction.Right: return 1;
                case Direction.Top: return 0;
                case Direction.TopLeft: return -1;
                case Direction.TopRight: return 1;                    
            }
            throw new Exception("!!!!");
        }

        private int getY(Direction direction)
        {
            switch (direction)
            {
                case Direction.Bottom: return 1;
                case Direction.BottomLeft: return 1;
                case Direction.BottomRight: return 1;
                case Direction.Left: return 0;
                case Direction.Right: return 0;
                case Direction.Top: return -1;
                case Direction.TopLeft: return -1;
                case Direction.TopRight: return -1;
            }
            throw new Exception("!!!!");
        }
    }
}