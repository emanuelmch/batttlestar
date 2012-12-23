using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaTTTlestar.Model.Players
{
    public class RandomPlayer : IPlayer
    {
        public string Name { get; set; }

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
