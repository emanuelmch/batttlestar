using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Tests.TestUtils;

namespace BaTTTlestar.Model.Tests.GameTests
{
    [TestClass]
    public class Player1Wins_Diagonal
    {

        [TestMethod]
        public void Test_Player1Wins_DiagonalAscending()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 2);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 0);
            Assert.AreEqual(GameState.WINNER, game.GameState);
            Assert.AreEqual(game.Player1, game.Winner);
        }

        [TestMethod]
        public void Test_Player1Wins_DiagonalDescending()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 2);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 2);
            Assert.AreEqual(GameState.WINNER, game.GameState);
            Assert.AreEqual(game.Player1, game.Winner);
        }

    }
}
