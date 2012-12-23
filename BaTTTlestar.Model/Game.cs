using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaTTTlestar.Model
{
    public class Game
    {
        #region Basic Properties
        public Board Board { get; set; }
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }
        public IPlayer Winner { get; private set; }
        #endregion

        #region Constructor
        public Game()
        {
            this.Board = new Board();
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
            Move move = null;
            do
            {
                move = CurrentPlayer.Move();
            } while (!this.Board.IsMoveValid(move));

            this.Board.AddMove(move, _player1Turn ? 1 : 2);

            FindWinner();
            _player1Turn = !_player1Turn;
        }

        public bool IsOver()
        {
            return Winner != null;
        }
        #endregion

        #region Private Methods
        private void FindWinner()
        {
            // TODO
        }
        #endregion
    }
}
