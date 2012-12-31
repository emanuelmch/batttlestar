using System;
using System.Collections.Generic;

using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Model.Players
{
    public class MiniMaxPlayer : IPlayer
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public int Value { get; set; }

        public MiniMaxPlayer(string name)
        {
            this.Name = name;
        }

        public Move Move()
        {
            return null;
        }

    }
}
