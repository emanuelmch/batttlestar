using System;
using System.Collections.Generic;

using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Model.Players
{
    public class MiniMaxPlayer : IPlayer
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public int Value { get; set; }

        public MiniMaxPlayer(string name)
        {
            this.Name = name;
        }

        public Move Move()
        {
            var moves = Board.GetPossibleMoves();

            Move bestMove = null;
            int bestMoveGrade = -(Board.SIZE + 1);

            foreach (Move move in moves)
            {
                var newBoard = Board.Copy();
                newBoard.AddMove(move, Value);

                var grade = MinMove(newBoard);
                grade = decreaseOneStep(grade);
                if (grade > bestMoveGrade)
                {
                    bestMove = move;
                    bestMoveGrade = grade;
                }
            }

            return bestMove;
        }

        private int MaxMove(Board board)
        {
            var winner = board.GetWinner();

            if (winner != 0 || board.IsFilled())
            {
                if (winner == 0)
                    return 0;
                if (winner == Value)
                    return Board.SIZE;
                return -Board.SIZE;
            }

            var moves = board.GetPossibleMoves();

            // Look for best move
            int bestMove = -(Board.SIZE + 1);

            foreach (Move move in moves)
            {
                var newBoard = board.Copy();
                newBoard.AddMove(move, Value);

                var grade = MinMove(newBoard);
                grade = decreaseOneStep(grade);
                if (grade > bestMove)
                    bestMove = grade;
            }

            return bestMove;
        }

        private int MinMove(Board board)
        {
            var winner = board.GetWinner();

            if (winner != 0 || board.IsFilled())
            {
                if (winner == 0)
                    return 0;
                if (winner == Value)
                    return Board.SIZE;
                return -Board.SIZE;
            }

            var enemyValue = (this.Value == 1) ? 2 : 1;
            var moves = board.GetPossibleMoves();

            int worstMove = Board.SIZE + 1;

            foreach (Move move in moves)
            {
                var newBoard = board.Copy();
                newBoard.AddMove(move, enemyValue);

                var grade = MaxMove(newBoard);
                grade = decreaseOneStep(grade);
                if (grade < worstMove)
                    worstMove = grade;
            }

            return worstMove;
        }

        private int decreaseOneStep(int grade)
        {
            if (grade > 0)
                return grade - 1;
            if (grade < 0)
                return grade + 1;
            return 0;
        }
    }
}
