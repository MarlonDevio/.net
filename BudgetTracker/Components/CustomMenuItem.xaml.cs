using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetTracker.Components
{
    /// <summary>
    /// Interaction logic for CustomMenuItem.xaml
    /// </summary>
    public partial class CustomMenuItem : UserControl
    {
        public static readonly DependencyProperty MenuItemTextProperty =
            DependencyProperty.Register(nameof(MenuItemText), typeof(string), typeof(CustomMenuItem),
                new PropertyMetadata("Default Text"));

        public string MenuItemText
        {
            get => (string)GetValue(MenuItemTextProperty);
            set => SetValue(MenuItemTextProperty, value);
        }

        public CustomMenuItem()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var customMenu = sender as TextBlock;
            MessageBox.Show(customMenu.Text);
        }
    }
}