using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Tests.TestUtils;

namespace BaTTTlestar.Model.Tests.GameTests
{
    [TestClass]
    public class Draw 
    {

        [TestMethod]
        public void Test_Draw()
        {
            TestGame game = new TestGame();

            game.TestMove(1, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 2);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 2);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 2);
            Assert.AreEqual(GameState.DRAW, game.GameState);
            Assert.IsNull(game.Winner);
        }

    }
}
