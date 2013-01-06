using System;

using BaTTTlestar.Model;
using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Shell.WPF
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public int Value { get; set; }

        public Move NextMove { get; set; }

        public HumanPlayer(string name)
        {
            this.Name = name;
        }

        public Move Move()
        {
            var nextMove = NextMove;
            NextMove = null;
            return nextMove;
        }
    }
}
