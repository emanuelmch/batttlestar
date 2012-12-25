using System;

using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Model.Tests.TestUtils
{
    public class TestGame : Game
    {
        public TestPlayer TestPlayer1
        {
            get
            {
                return Player1 as TestPlayer;
            }
        }

        public TestPlayer TestPlayer2
        {
            get
            {
                return Player2 as TestPlayer;
            }
        }

        public TestPlayer CurrentTestPlayer
        {
            get
            {
                return CurrentPlayer as TestPlayer;
            }
        }

        public TestGame() : base()
        {
            this.Player1 = new TestPlayer("Player 1");
            this.Player2 = new TestPlayer("Player 2");
        }

        public void TestMove(int x, int y)
        {
            CurrentTestPlayer.NextMove = new Move(x, y);
            this.Move();
        }
    }
}
