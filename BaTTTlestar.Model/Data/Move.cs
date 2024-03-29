﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaTTTlestar.Model.Data
{
    public class Move
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Move() { }

        public Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj is Move)
            {
                var other = (Move)obj;
                if (other.X != this.X)
                    return false;
                return other.Y == this.Y;
            }

            return false;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }

    }
}
