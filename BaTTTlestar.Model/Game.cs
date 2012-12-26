using System;
using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Model
{
    public class Game
    {
        #region Basic Properties
        public Board Board { get; set; }
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }
        public IPlayer Winner { get; private set; }
        public GameState GameState { get; private set; }
        #endregion

        #region Constructor
        public Game()
        {
            this.Board = new Board();
            this.GameState = Data.GameState.ONGOING;
        }
        #endregion

        #region Members
        private bool _player1Turn = true;
        #endregion

        #region Calculated Properties
        public IPlayer CurrentPlayer
        {
            get
            {
                return _player1Turn ? Player1 : Player2;
            }
        }
        #endregion

        #region Public Methods
        public void Move()
        {
            CurrentPlayer.Board = Board;
            Player1.Value = 1;
            Player2.Value = 2;

            Move move = null;
            do
            {
                move = CurrentPlayer.Move();
            } while (!this.Board.IsMoveValid(move));

            this.Board.AddMove(move, _player1Turn ? 1 : 2);

            FindWinner();

            if (Winner != null)
                this.GameState = Data.GameState.WINNER;
            else if (Board.IsFilled())
                this.GameState = Data.GameState.DRAW;

            _player1Turn = !_player1Turn;
        }

        public bool IsOver()
        {
            return this.GameState != Data.GameState.ONGOING;
        }
        #endregion

        #region Private Methods
        private void FindWinner()
        {
            this.Winner = CheckRows() ?? CheckColumns() ?? CheckDiagonals();
        }

        private IPlayer CheckRows()
        {
            int winner = 0;
            for (int i = 0; i < Board.Y_SIZE; i++)
            {
                // TODO Create a method "GetRow" on Board
                int column0 = Board.GetMove(0, i);
                int column1 = Board.GetMove(1, i);
                int column2 = Board.GetMove(2, i);
                if ((column0 != 0) && (column0 == column1) && (column1 == column2))
                {
                    winner = column0;
                    break;
                }
            }

            return ValueToPlayer(winner);
        }

        private IPlayer CheckColumns()
        {
            int winner = 0;
            for (int i = 0; i < Board.X_SIZE; i++)
            {
                // TODO Create a method "GetColumn" on Board
                int row0 = Board.GetMove(i, 0);
                int row1 = Board.GetMove(i, 1);
                int row2 = Board.GetMove(i, 2);
                if ((row0 != 0) && (row0 == row1) && (row1 == row2))
                {
                    winner = row0;
                    break;
                }
            }

            return ValueToPlayer(winner);
        }

        private IPlayer CheckDiagonals()
        {
            // We can't have a diagonal without the middle
            int d11 = Board.GetMove(1, 1);
            if (d11 == 0)
                return null;

            int d00 = Board.GetMove(0, 0);
            int d22 = Board.GetMove(2, 2);

            if ((d00 == d11) && (d11 == d22))
                return ValueToPlayer(d11);

            int d20 = Board.GetMove(2, 0);
            int d02 = Board.GetMove(0, 2);

            if ((d20 == d11) && (d11 == d02))
                return ValueToPlayer(d11);

            return null;
        }

        private IPlayer ValueToPlayer(int value)
        {
            switch (value)
            {
                case 1:
                    return Player1;
                case 2:
                    return Player2;
                default:
                    return null;
            }
        }
        #endregion
    }
}
