﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaTTTlestar.Model.Tests.TestUtils;

namespace BaTTTlestar.Model.Tests.GameTests
{
    [TestClass]
    public class Player2Wins_Diagonal
    {

        [TestMethod]
        public void Test_Player2Wins_DiagonalAscending()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 0);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 2);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 0);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 0);
            Assert.AreEqual(game.Player2, game.Winner);
        }

        [TestMethod]
        public void Test_Player2Wins_DiagonalDescending()
        {
            TestGame game = new TestGame();

            game.TestMove(0, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 0);
            Assert.IsNull(game.Winner);

            game.TestMove(0, 2);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 1);
            Assert.IsNull(game.Winner);

            game.TestMove(1, 2);
            Assert.IsNull(game.Winner);

            game.TestMove(2, 2);
            Assert.AreEqual(game.Player2, game.Winner);
        }

    }
}
