﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaTTTlestar.Model.Data
{
    public class Board
    {
        public const int X_SIZE = 3;
        public const int Y_SIZE = 3;

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

    }
}
