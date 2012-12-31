using System;
using System.Threading;

using NUnit.Framework;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Model.Tests.PlayerTests
{
    [TestFixture]
    public class Player_FinishingMove_Column
    {
        private const int AMOUNT_OF_ASSERTIONS = 50;

        private static object[] TestValues =
        {
            new object[] {1},
            new object[] {2}
        };

        [Test, TestCaseSource("TestValues")]
        public void Test_Player_Column0_Row0(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 1);
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(1, 2), 2);
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
        public void Test_Player_Column0_Row1(int value)
        {
            var board = new Board();
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(0, 2), 2);
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
        public void Test_Player_Column0_Row2(int value)
        {
            var board = new Board();
            board.AddMove(new Move(2, 1), 1);
            board.AddMove(new Move(2, 2), 1);
            board.AddMove(new Move(0, 2), 2);
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
        public void Test_Player_Column1_Row0(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 0), 1);
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(1, 2), 2);
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
        public void Test_Player_Column1_Row1(int value)
        {
            var board = new Board();
            board.AddMove(new Move(1, 0), 1);
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(0, 2), 2);
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
        public void Test_Player_Column1_Row2(int value)
        {
            var board = new Board();
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(2, 2), 1);
            board.AddMove(new Move(0, 2), 2);
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
        public void Test_Player_Column2_Row0(int value)
        {
            var board = new Board();
            board.AddMove(new Move(0, 0), 1);
            board.AddMove(new Move(0, 1), 1);
            board.AddMove(new Move(1, 1), 2);
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
        public void Test_Player_Column2_Row1(int value)
        {
            var board = new Board();
            board.AddMove(new Move(1, 0), 1);
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(0, 1), 2);
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
        public void Test_Player_Column2_Row2(int value)
        {
            var board = new Board();
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(2, 1), 1);
            board.AddMove(new Move(0, 1), 2);
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
