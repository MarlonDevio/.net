using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimalMatchingGame
{
    using System.Windows.Threading;

    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _timer = new DispatcherTimer();
        private int _tenthOfSecondsElapsed;
        private int _matchesFound;

        public MainWindow()
        {
            InitializeComponent();

            _timer.Interval = TimeSpan.FromSeconds(.1);
            _timer.Tick += Timer_Tick;

            SetUpGame();
        }

        // Setting up the game
        private void SetUpGame()
        {
            List<string> animalEmojiList =
            [
                "😊", "😊",
                "😍", "😍",
                "👌", "👌",
                "😒", "😒",
                "🙌", "🙌",
                "💕", "💕",
                "😁", "😁",
                "😿", "😿"
            ];

            Random random = new();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timerTextBlock")
                {
                    int index = random.Next(animalEmojiList.Count);
                    string nextEmoji = animalEmojiList[index];
                    textBlock.Text = nextEmoji;
                    animalEmojiList.RemoveAt(index);
                };
            }
            _timer.Start();
            _tenthOfSecondsElapsed = 0;
            _matchesFound = 0;
        }


        // Timer ticking
        private void Timer_Tick(object? sender, EventArgs e)
        {
            _tenthOfSecondsElapsed++;
            timerTextBlock.Text = (_tenthOfSecondsElapsed / 10F).ToString("0.0s");
            if (_matchesFound == 8)
            {
                _timer.Stop();
                timerTextBlock.Text = timerTextBlock.Text + "- Play again?";
            };
        }


        private TextBlock _lastTextBlockClicked;
        private bool _findingMatch = false;

        /*
         * Game Logic
         */
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock? textBlock = sender as TextBlock;
            if (_findingMatch == false)
            {
                if (textBlock != null)
                {
                    textBlock.Visibility = Visibility.Hidden;
                    _lastTextBlockClicked = textBlock;
                }

                _findingMatch = true;
                return;
            }

            if (textBlock?.Text == _lastTextBlockClicked.Text)
            {
                _matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                _findingMatch = false;
                return;
            }

            _lastTextBlockClicked.Visibility = Visibility.Visible;
            _findingMatch = false;
            return;
        }

        // Reset of game
        private void TimerTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this._matchesFound == 8)
                SetUpGame();
        }
    }
}