using System;
using System.Threading;

using NUnit.Framework;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Model.Tests.PlayerTests
{
    [TestFixture]
    public class Player_TwoAvailableMoves
    {
        private const int AMOUNT_OF_ASSERTIONS = 50;

        private static object[] TestValues =
        {
            new object[] {new SimplePlayer(""), 1, 2, 2},
            new object[] {new SimplePlayer(""), 2, 0, 0},
            new object[] {new MiniMaxPlayer(""), 1, 2, 2},
            new object[] {new MiniMaxPlayer(""), 2, 0, 0}
        };

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_TwoMoves_Row(IPlayer player, int value, int x, int y)
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 2);
            board.AddMove(new Move(0, 2), 2);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(1, 1), 2);
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(2, 1), 1);

            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(x, y);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_TwoMoves_Column(IPlayer player, int value, int x, int y)
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 2);
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(1, 1), 2);
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(2, 0), 2);
            board.AddMove(new Move(2, 1), 1);

            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(x, y);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

    }
}
