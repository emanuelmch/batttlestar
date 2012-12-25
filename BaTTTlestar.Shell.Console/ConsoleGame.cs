using System;

using BaTTTlestar.Model;
using BaTTTlestar.Model.Data;

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
            drawBoard();

            do
            {
                System.Console.ReadKey();

                _game.Move();
                drawBoard();
            } while (!_game.IsOver());

            if (_game.GameState == GameState.DRAW)
            {
                System.Console.WriteLine("Aaaaand we have a draw!");
            }
            else
            {
                IPlayer winner = _game.Winner;
                System.Console.WriteLine("The winner is " + winner.Name);
            }

            System.Console.ReadLine();
        }

        public void drawBoard()
        {
            Board board = _game.Board;
            for (int y = 0; y < Board.Y_SIZE; y++)
            {
                for (int x = 0; x < Board.X_SIZE; x++)
                {
                    System.Console.Write(board.GetMove(x, y));
                    if (x != (x - 1))
                        System.Console.Write("|");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
    }
}
