using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaTTTlestar.Model
{
    public class Game
    {
        public Board Board { get; set; }
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }
    }
}
