using System;
using BaTTTlestar.Model.Data;

namespace BaTTTlestar.Model.Players
{
    public class SimplePlayer : IPlayer
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public int Value { get; set; }

        public SimplePlayer(string name)
        {
            this.Name = name;
        }

        public Move Move()
        {
            return WinningMove() ?? NonLosingMove() ?? RandomMove();
        }

        private Move WinningMove()
        {
            return SearchForLine(Value);
        }

        private Move NonLosingMove()
        {
            return SearchForLine(Value == 1 ? 2 : 1);
        }

        private Move SearchForLine(int value)
        {
            return SearchForRow(value) ?? SearchForColumn(value) ?? SearchForDiagonal(value);
        }

        private Move SearchForRow(int value)
        {
            for (int y = 0; y < Board.Y_SIZE; y++)
            {
                if (Board.GetMove(0, y) == value)
                {
                    if (Board.GetMove(1, y) == value && Board.GetMove(2, y) == 0)
                        return new Move(2, y);
                    if (Board.GetMove(1, y) == 0 && Board.GetMove(2, y) == value)
                        return new Move(1, y);
                }
                else if (Board.GetMove(0, y) == 0)
                {
                    if (Board.GetMove(1, y) == value && Board.GetMove(2, y) == value)
                        return new Move(0, y);
                }
            }

            return null;
        }

        private Move SearchForColumn(int value)
        {
            for (int x = 0; x < Board.X_SIZE; x++)
            {
                if (Board.GetMove(x, 0) == value)
                {
                    if (Board.GetMove(x, 1) == value && Board.GetMove(x, 2) == 0)
                        return new Move(x, 2);
                    if (Board.GetMove(x, 1) == 0 && Board.GetMove(x, 2) == value)
                        return new Move(x, 1);
                }
                else if (Board.GetMove(x, 0) == 0)
                {
                    if (Board.GetMove(x, 1) == value && Board.GetMove(x, 2) == value)
                        return new Move(x, 0);
                }
            }

            return null;
        }

        private Move SearchForDiagonal(int value)
        {
            return SearchForAscendingDiagonal(value) ?? SearchForDescendingDiagonal(value);
        }

        private Move SearchForAscendingDiagonal(int value)
        {
            if (Board.GetMove(0, 2) == value)
            {
                if (Board.GetMove(1, 1) == value && Board.GetMove(2, 0) == 0)
                    return new Move(2, 0);
                if (Board.GetMove(1, 1) == 0 && Board.GetMove(2, 0) == value)
                    return new Move(1, 1);
            }
            else if (Board.GetMove(0, 2) == value)
            {
                if (Board.GetMove(1, 1) == value && Board.GetMove(2, 0) == value)
                    return new Move(0,2);
            }

            return null;
        }

        private Move SearchForDescendingDiagonal(int value)
        {
            if (Board.GetMove(0, 0) == value)
            {
                if (Board.GetMove(1, 1) == value && Board.GetMove(2, 2) == 0)
                    return new Move(2, 2);
                if (Board.GetMove(1, 1) == 0 && Board.GetMove(2, 2) == value)
                    return new Move(1, 1);
            }
            else if (Board.GetMove(0, 0) == value)
            {
                if (Board.GetMove(1, 1) == value && Board.GetMove(2, 2) == value)
                    return new Move(0, 0);
            }

            return null;
        }

        private Move RandomMove()
        {
            Random random = new Random();
            while (true)
            {
                int x = random.Next(Board.X_SIZE);
                int y = random.Next(Board.Y_SIZE);
                var move = new Move(x, y);
                if (Board.IsMoveValid(move))
                    return move;
            }
        }
    }
}
