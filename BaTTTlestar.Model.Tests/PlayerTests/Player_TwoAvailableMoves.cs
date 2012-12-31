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
            new object[] {1, 2,2},
            new object[] {2,0,0}
        };

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_TwoMoves_Row(int value, int x, int y)
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 2);
            board.AddMove(new Move(0, 2), 2);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(1, 1), 2);
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(2, 1), 1);

            var player = new SimplePlayer("");
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
        public void Test_Player_TwoMoves_Column(int value, int x, int y)
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 2);
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(1, 1), 2);
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(2, 0), 2);
            board.AddMove(new Move(2, 1), 1);

            var player = new SimplePlayer("");
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
