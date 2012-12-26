using System;
using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Model.Tests.TestUtils
{
    public class TestPlayer : IPlayer
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public int Value { get; set; }

        public Move NextMove { get; set; }

        public TestPlayer(string name)
        {
            this.Name = name;
        }

        public Move Move()
        {
            return NextMove;
        }

   }
}
