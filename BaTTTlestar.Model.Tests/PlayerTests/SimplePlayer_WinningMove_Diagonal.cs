using System;
using System.Threading;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Model.Tests.PlayerTests
{
    [TestClass]
    public class SimplePlayer_WinningMove_Diagonal
    {
        private const int AMOUNT_OF_ASSERTIONS = 50;

        [TestMethod]
        public void Test_SimplePlayer_DiagonalAsc_Row0()
        {
            var board = new Board();
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(0, 0), 2);
            board.AddMove(new Move(0, 1), 2);

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

        [TestMethod]
        public void Test_SimplePlayer_DiagonalAsc_Row1()
        {
            var board = new Board();
            board.AddMove(new Move(0, 2), 1);
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(1, 2), 2);

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

        [TestMethod]
        public void Test_SimplePlayer_DiagonalAsc_Row2()
        {
            var board = new Board();
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(2, 0), 1);
            board.AddMove(new Move(0, 0), 2);
            board.AddMove(new Move(0, 1), 2);

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

        [TestMethod]
        public void Test_SimplePlayer_DiagonalDesc_Row0()
        {
            var board = new Board();
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(2, 2), 1);
            board.AddMove(new Move(0, 1), 2);
            board.AddMove(new Move(0, 2), 2);

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

        [TestMethod]
        public void Test_SimplePlayer_DiagonalDesc_Row1()
        {
            var board = new Board();
            board.AddMove(new Move(0, 0), 1);
            board.AddMove(new Move(2, 2), 1);
            board.AddMove(new Move(1, 0), 2);
            board.AddMove(new Move(1, 2), 2);

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

        [TestMethod]
        public void Test_SimplePlayer_DiagonalDesc_Row2()
        {
            var board = new Board();
            board.AddMove(new Move(0, 0), 1);
            board.AddMove(new Move(1, 1), 1);
            board.AddMove(new Move(0, 2), 2);
            board.AddMove(new Move(1, 2), 2);

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
