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

        private const string PLAYER_1_NAME = "O";
        private const string PLAYER_2_NAME = "X";

        private IPlayer player1 = new RandomPlayer(PLAYER_1_NAME);
        private IPlayer player2 = new MiniMaxPlayer(PLAYER_2_NAME);

        private bool gameOngoing = false;
        private Game game;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            NextMove(sender, e);
        }

        private void ChangePlayer(object sender, RoutedEventArgs e)
        {
            var menuitem = sender as MenuItem;
            var parent = menuitem.Parent as MenuItem;

            // OK, this is ugly, but it's not like I'm caring much at this point...
            foreach (var child in parent.Items)
            {
                var childItem = child as MenuItem;
                childItem.IsChecked = childItem == menuitem;
            }


            bool isPlayer1 = parent.Header.Equals("Player 1");

            IPlayer newplayer = createNewPlayer(menuitem.Header as string, isPlayer1 ? PLAYER_1_NAME : PLAYER_2_NAME);

            if (isPlayer1)
                this.player1 = newplayer;
            else
                this.player2 = newplayer;

            RestartGame();
            RedrawGame();
        }

        private IPlayer createNewPlayer(string text, string name)
        {
            if (text == "Easy")
                return new RandomPlayer(name);
            if (text == "Medium")
                return new SimplePlayer(name);
            if (text == "Hard")
                return new MiniMaxPlayer(name);

            return null;
        }

        private void NextMove(object sender, RoutedEventArgs e)
        {
            if (gameOngoing)
            {
                game.Move();
            }
            else
            {
                this.NextMoveButton.Content = "Next move";
                RestartGame();
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

        private void RestartGame()
        {
            this.gameOngoing = true;
            this.game = new Game();
            this.game.Player1 = player1;
            this.game.Player2 = player2;
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
            var images = ((this.Content as Grid).Children[1] as Grid).Children;

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
