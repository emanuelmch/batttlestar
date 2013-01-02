using System;
using System.Windows;
using System.Windows.Controls;

using BaTTTlestar.Model;
using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Shell.WPF
{
    public partial class MainWindow : Window
    {
        private const string PLAYER_1_VALUE = "X";
        private const string PLAYER_2_VALUE = "O";

        private bool gameOngoing = false;
        private Game game;

        public MainWindow()
        {
            InitializeComponent();
            NextMove(null, null);
        }

        private void NextMove(object sender, RoutedEventArgs e)
        {
            if (gameOngoing)
            {
                game.Move();
            }
            else
            {
                gameOngoing = true;
                this.NextMoveButton.Content = "Next move";
                this.game = new Game();
                game.Player1 = new RandomPlayer(PLAYER_1_VALUE);
                game.Player2 = new MiniMaxPlayer(PLAYER_2_VALUE);
            }

            RedrawGame();
        }

        private void RedrawGame()
        {
            for (int x = 0; x < Board.X_SIZE; x++)
                for (int y = 0; y < Board.Y_SIZE; y++)
                {
                    var button = FindButton(x, y);
                    RedrawButton(button, this.game.Board.GetMove(x, y));
                }
        }

        private void RedrawButton(Button button, int value)
        {
            switch (value)
            {
                case 1:
                    button.Content = PLAYER_1_VALUE;
                    break;
                case 2:
                    button.Content = PLAYER_2_VALUE;
                    break;
                default:
                    button.Content = "";
                    break;
            }

            string text = "";
            switch (game.GameState)
            {
                case GameState.ONGOING:
                    text = "Game is ongoing...";
                    break;
                case GameState.DRAW:
                    text = "Game is a draw!";
                    PrepareForNewGame();
                    break;
                case GameState.WINNER:
                    text = "And the winner is " + game.Winner.Name;
                    PrepareForNewGame();
                    break;
            }

            this.StatusBlock.Text = text;
        }

        private Button FindButton(int x, int y)
        {
            var buttons = ((this.Content as Grid).Children[0] as Grid).Children;

            foreach (UIElement button in buttons)
            {
                if (Grid.GetColumn(button) == x && Grid.GetRow(button) == y)
                    return (Button)button;
            }

            return null;
        }

        private void PrepareForNewGame()
        {
            this.NextMoveButton.Content = "Start new game";
            this.gameOngoing = false;
        }
    }
}
