using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

using BaTTTlestar.Model;
using BaTTTlestar.Model.Data;
using BaTTTlestar.Model.Players;

namespace BaTTTlestar.Shell.WPF
{
    public partial class MainWindow : Window
    {
        private const string EMPTY_URI = "pack://application:,,,/resources/empty.png";
        private const string PLAYER_1_URI = "pack://application:,,,/resources/player1.png";
        private const string PLAYER_2_URI = "pack://application:,,,/resources/player2.png";

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
                game.Player1 = new RandomPlayer("O");
                game.Player2 = new MiniMaxPlayer("X");
            }

            RedrawGame();
        }

        private void RedrawGame()
        {
            for (int x = 0; x < Board.X_SIZE; x++)
                for (int y = 0; y < Board.Y_SIZE; y++)
                {
                    var image = FindImage(x, y);
                    RedrawImage(image, this.game.Board.GetMove(x, y));
                }
        }

        private void RedrawImage(Image image, int value)
        {
            switch (value)
            {
                case 1:
                    image.Source = new BitmapImage(new Uri(PLAYER_1_URI));
                    break;
                case 2:
                    image.Source = new BitmapImage(new Uri(PLAYER_2_URI));
                    break;
                default:
                    image.Source = new BitmapImage(new Uri(EMPTY_URI));
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
                    text = "And the " + game.Winner.Name + " won!";
                    PrepareForNewGame();
                    break;
            }

            this.StatusBlock.Text = text;
        }

        private Image FindImage(int x, int y)
        {
            var images = ((this.Content as Grid).Children[0] as Grid).Children;

            foreach (UIElement image in images)
            {
                if (Grid.GetColumn(image) == x && Grid.GetRow(image) == y)
                    return (Image)image;
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
