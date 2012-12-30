using System;
using System.Threading;

using NUnit.Framework;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Model.Tests.PlayerTests
{
    [TestFixture]
    public class SimplePlayer_FinishingMove_Row
    {
        private const int AMOUNT_OF_ASSERTIONS = 50;

        [Test]
        public void Test_SimplePlayer_Row0_Column0()
        {
            var board = new Board();
            board.AddMove(new Move(1, 0), 1);
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(1, 1), 2);
            board.AddMove(new Move(2, 1), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

            var expectedMove = new Move(0, 0);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test]
        public void Test_SimplePlayer_Row0_Column1()
        {
            var board = new Board();
            board.AddMove(new Move(0, 0), 1);
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(0, 1), 2);
            board.AddMove(new Move(2, 1), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

            var expectedMove = new Move(1, 0);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test]
        public void Test_SimplePlayer_Row0_Column2()
        {
            var board = new Board();
            board.AddMove(new Move(0, 0), 1);
            board.AddMove(new Move(1, 0), 1);
            board.AddMove(new Move(0, 1), 2);
            board.AddMove(new Move(1, 1), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

            var expectedMove = new Move(2, 0);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test]
        public void Test_SimplePlayer_Row1_Column0()
        {
            var board = new Board();
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(2, 1), 1);
            board.AddMove(new Move(1, 2), 2);
            board.AddMove(new Move(2, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

            var expectedMove = new Move(0, 1);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test]
        public void Test_SimplePlayer_Row1_Column1()
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 1);
            board.AddMove(new Move(2, 1), 1);
            board.AddMove(new Move(0, 2), 2);
            board.AddMove(new Move(2, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

            var expectedMove = new Move(1, 1);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test]
        public void Test_SimplePlayer_Row1_Column2()
        {
            var board = new Board();
            board.AddMove(new Move(0, 1), 1);
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(0, 2), 2);
            board.AddMove(new Move(1, 2), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

            var expectedMove = new Move(2, 1);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test]
        public void Test_SimplePlayer_Row2_Column0()
        {
            var board = new Board();
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(2, 2), 1);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(2, 0), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

            var expectedMove = new Move(0, 2);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test]
        public void Test_SimplePlayer_Row2_Column1()
        {
            var board = new Board();
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(2, 2), 1);
            board.AddMove(new Move(0, 0), 2);
            board.AddMove(new Move(2, 0), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

            var expectedMove = new Move(1, 2);
            for (int i = 0; i < AMOUNT_OF_ASSERTIONS; i++)
            {
                var move = player.Move();
                Assert.AreEqual(expectedMove, move);
                Thread.Sleep(1);
            }
        }

        [Test]
        public void Test_SimplePlayer_Row2_Column2()
        {
            var board = new Board();
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(1, 2), 1);
            board.AddMove(new Move(0, 0), 2);
            board.AddMove(new Move(1, 0), 2);

            var player = new SimplePlayer("");
            player.Board = board;
            player.Value = 1;

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
