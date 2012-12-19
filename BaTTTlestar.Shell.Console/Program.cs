using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BaTTTlestar.Model;

namespace BaTTTlestar.Shell.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Player1 = null;
            game.Player2 = null;

            ConsoleGame shell = new ConsoleGame(game);
            shell.Run();
        }
    }
}
