using System;
using System.Collections.Generic;

namespace BaTTTlestar.Model.Data
{
    public class Board
    {
        public const int X_SIZE = 3;
        public const int Y_SIZE = 3;
        public const int SIZE = X_SIZE * Y_SIZE;

        private int[][] _board;

        public Board()
        {
            this._board = new int[X_SIZE][];
            for (int i = 0; i < X_SIZE; i++)
                this._board[i] = new int[Y_SIZE];
        }

        public bool IsMoveValid(Move move)
        {
            return _board[move.X][move.Y] == 0;
        }

        public void AddMove(Move move, int player)
        {
            if (this._board[move.X][move.Y] != 0)
                throw new InvalidOperationException("Position [" + move.X + "," + move.Y + "] is already used: " + this._board[move.X][move.Y]);
            this._board[move.X][move.Y] = player;
        }

        public int GetMove(int x, int y)
        {
            return this._board[x][y];
        }

        public bool IsFilled()
        {
            for (int x = 0; x < X_SIZE; x++)
                for (int y = 0; y < Y_SIZE; y++)
                {
                    if (this._board[x][y] == 0)
                        return false;
                }

            return true;
        }

        public List<Move> GetPossibleMoves()
        {
            var possibleMoves = new List<Move>();

            for (int x = 0; x < Board.X_SIZE; x++)
                for (int y = 0; y < Board.Y_SIZE; y++)
                {
                    var move = new Move(x, y);
                    if (IsMoveValid(move))
                        possibleMoves.Add(move);
                }

            return possibleMoves;
        }


        public Board Copy()
        {
            var copy = new Board();
            
            for (int x = 0; x < X_SIZE; x++)
                for (int y = 0; y < Y_SIZE; y++)
                {
                    copy._board[x][y] = this._board[x][y];
                }

            return copy;
        }

        public int GetWinner()
        {
            var winner = CheckRows();
            winner = (winner != 0) ? winner : CheckColumns();
            winner = (winner != 0) ? winner : CheckDiagonals();

            return winner;
        }

        private int CheckRows()
        {
            int winner = 0;
            for (int i = 0; i < Board.Y_SIZE; i++)
            {
                // TODO Create a method "GetRow" on Board
                int column0 = GetMove(0, i);
                int column1 = GetMove(1, i);
                int column2 = GetMove(2, i);
                if ((column0 != 0) && (column0 == column1) && (column1 == column2))
                {
                    winner = column0;
                    break;
                }
            }

            return winner;
        }

        private int CheckColumns()
        {
            int winner = 0;
            for (int i = 0; i < Board.X_SIZE; i++)
            {
                // TODO Create a method "GetColumn" on Board
                int row0 = GetMove(i, 0);
                int row1 = GetMove(i, 1);
                int row2 = GetMove(i, 2);
                if ((row0 != 0) && (row0 == row1) && (row1 == row2))
                {
                    winner = row0;
                    break;
                }
            }

            return winner;
        }

        private int CheckDiagonals()
        {
            // We can't have a diagonal without the middle
            int d11 = GetMove(1, 1);
            if (d11 == 0)
                return 0;

            int d00 = GetMove(0, 0);
            int d22 = GetMove(2, 2);

            if ((d00 == d11) && (d11 == d22))
                return d11;

            int d20 = GetMove(2, 0);
            int d02 = GetMove(0, 2);

            if ((d20 == d11) && (d11 == d02))
                return d11;

            return 0;
        }

    }
}
