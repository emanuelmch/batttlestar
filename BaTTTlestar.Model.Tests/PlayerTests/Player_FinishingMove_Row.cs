using System;
using System.Threading;

using NUnit.Framework;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Model.Tests.PlayerTests
{
    [TestFixture]
    public class Player_FinishingMove_Row
    {
        private const int AMOUNT_OF_ASSERTIONS = 50;

        private static object[] TestValues =
        {
            new object[] {1},
            new object[] {2}
        };

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row0_Column0(int value)
        {
            var board = new Board();
            board.AddMove(new Move(1, 0), 1);
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(2, 1), 2);
            board.AddMove(new Move(2, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(0, 0);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row0_Column1(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 0), 1);
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(2, 1), 2);
            board.AddMove(new Move(2, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(1, 0);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row0_Column2(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 0), 1);
            board.AddMove(new Move(1, 0), 1);
            board.AddMove(new Move(1, 1), 2);
            board.AddMove(new Move(1, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(2, 0);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row1_Column0(int value)
        {
            var board = new Board();
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(2, 1), 1);
            board.AddMove(new Move(2, 0), 2);
            board.AddMove(new Move(2, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(0, 1);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row1_Column1(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 1);
            board.AddMove(new Move(2, 1), 1);
            board.AddMove(new Move(2, 0), 2);
            board.AddMove(new Move(2, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(1, 1);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row1_Column2(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 1);
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(1, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(2, 1);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row2_Column0(int value)
        {
            var board = new Board();
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(2, 2), 1);
            board.AddMove(new Move(2, 0), 2);
            board.AddMove(new Move(2, 1), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(0, 2);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row2_Column1(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(2, 2), 1);
            board.AddMove(new Move(2, 0), 2);
            board.AddMove(new Move(2, 1), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(1, 2);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Row2_Column2(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(1, 1), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = value;

            var expectedMove = new Move(2, 2);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

    }
}
