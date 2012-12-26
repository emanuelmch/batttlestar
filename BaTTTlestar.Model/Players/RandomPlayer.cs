using System;
using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Model.Players
{
    public class RandomPlayer : IPlayer
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public int Value { get; set; }

        public RandomPlayer(string name)
        {
            this.Name = name;
        }

        public Move Move()
        {
            Random random = new Random();
            int x = random.Next(Board.X_SIZE);
            int y = random.Next(Board.Y_SIZE);
            return new Move(x, y);
        }
    }
}
