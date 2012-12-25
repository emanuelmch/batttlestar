﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaTTTlestar.Model.Tests.TestUtils
{
    public class TestPlayer : IPlayer
    {
        public string Name
        {
            get;
            set;
        }

        public Move NextMove
        {
            get;
            set;
        }

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
