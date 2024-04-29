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
using H3_CardPickerGame.Classes;

namespace H3_CardPickerGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listOfCards.Items.Clear();
            string[] cards = CardPicker.PickSomeCards(Convert.ToInt32(cardAmountSlider.Value));
            foreach (var card in cards)
            {
                listOfCards.Items.Add(card);
            }

        }
    }
}