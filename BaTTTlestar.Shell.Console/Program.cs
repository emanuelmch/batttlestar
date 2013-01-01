using System;

using BaTTTlestar.Model;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Shell.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Player1 = new MiniMaxPlayer("Player 1");
            game.Player2 = new MiniMaxPlayer("Player 2");

            ConsoleGame shell = new ConsoleGame(game);
            shell.Run();
        }
    }
}
