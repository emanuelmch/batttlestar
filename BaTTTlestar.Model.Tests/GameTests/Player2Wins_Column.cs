using System;

using NUnit.Framework;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Tests.TestUtils;

namespace BaTTTlestar.Model.Tests.GameTests
{
    [TestFixture]
    public class Player2Wins_Column
    {

        [Test]
        public void Test_Player2Wins_Column0()
        {
            TestGame game = new TestGame();

            game.TestMove(2, 2);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 2);
            Assert.AreEqual(GameState.WINNER, game.GameState);
            Assert.AreEqual(game.Player2, game.Winner);
        }

        [Test]
        public void Test_Player2Wins_Column1()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 2);
            Assert.AreEqual(GameState.WINNER, game.GameState);
            Assert.AreEqual(game.Player2, game.Winner);
        }

        [Test]
        public void Test_Player2Wins_Column2()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 0);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.AreEqual(GameState.ONGOING, game.GameState);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 2);
            Assert.AreEqual(GameState.WINNER, game.GameState);
            Assert.AreEqual(game.Player2, game.Winner);
        }

    }
}