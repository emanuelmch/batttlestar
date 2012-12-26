using System;
using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Model.Players
{
    public class SimplePlayer : IPlayer
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public int Value { get; set; }

        public SimplePlayer(string name)
        {
            this.Name = name;
        }

        public Move Move()
        {
            return WinningMove() ?? NonLosingMove() ?? RandomMove();
        }

        private Move WinningMove()
        {
            return null;
        }

        private Move NonLosingMove()
        {
            return null;
        }

        private Move RandomMove()
        {
            Random random = new Random();
            while (true)
            {
                int x = random.Next(Board.X_SIZE);
                int y = random.Next(Board.Y_SIZE);
                var move = new Move(x, y);
                if (Board.IsMoveValid(move))
                    return move;
            }
        }
    }
}
