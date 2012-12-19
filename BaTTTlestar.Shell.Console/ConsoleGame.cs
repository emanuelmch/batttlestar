using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BaTTTlestar.Model;

namespace BaTTTlestar.Shell.Console
{
    public class ConsoleGame
    {
        private Game _game;

        public ConsoleGame(Game game)
        {
            this._game = game;
        }

        public void Run()
        {
            System.Console.WriteLine("BaTTTlestar by Bill");
            System.Console.ReadKey();
        }
    }
}
