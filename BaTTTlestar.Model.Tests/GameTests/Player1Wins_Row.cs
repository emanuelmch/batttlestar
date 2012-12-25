using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaTTTlestar.Model.Tests.TestUtils;

namespace BaTTTlestar.Model.Tests.GameTests
{
    [TestClass]
    public class Player1Wins_Row
    {

        [TestMethod]
        public void Test_Player1Wins_Row0()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 0);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 0);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 0);
            Assert.AreEqual(game.Player1, game.Winner);
        }

        [TestMethod]
        public void Test_Player1Wins_Row1()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 2);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 2);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 1);
            Assert.AreEqual(game.Player1, game.Winner);
        }

        [TestMethod]
        public void Test_Player1Wins_Row2()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 2);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 2);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 2);
            Assert.AreEqual(game.Player1, game.Winner);
        }

    }
}
