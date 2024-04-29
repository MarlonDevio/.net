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

namespace h03_graphics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddComponents();
        }

        private void AddComponent(Panel container, Control elementToAdd)
        {
           container.Children.Add(elementToAdd);
        }

        private void AddComponent(Panel container, Shape shape)
        {
           container.Children.Add(shape);
        }

        // Adding Components
        private void AddComponents()
        {
            Rectangle aRectangle = new()
            {
                Width = 100,
                Height = 100,
                // Fill = Brushes.Aqua,
                Fill = new SolidColorBrush(Colors.Indigo),
                Margin = new Thickness(50, 10, 10, 10)
            };

            AddComponent(paperCanvas, aRectangle);
            foreach (var line in Triangle())
            {
             AddComponent(paperCanvas, line);  
            }
        }

        private Line DrawLine(double x1, double x2, double y1, double y2)
        {
           Line line = new()
           {
              X1 = x1,
              Y1 = y1,
              X2 = x2,
              Y2 = y2,
               StrokeThickness = 1,
               Stroke = Brushes.Black,
           };

           return line;
        }

        private Line[] Triangle()
        {
           Line baseLine = DrawLine(0, 20, 0, 0);
           Line angleLine = DrawLine(20, 20, 0, 20);
           Line lastLine = DrawLine(20, 0, 20, 0);
            return [baseLine, angleLine, lastLine];
        }
    }
}
/*
 *
 *Using Brushes.Aqua:
   Brushes.Aqua is a predefined property of the Brushes class that returns a SolidColorBrush 
initialized to the color Aqua. This is a convenience provided by .NET so that developers can 
quickly access common colors without needing to explicitly instantiate new brush objects.
   This method is very concise and convenient for using standard colors, reducing the verbosity 
of the code and improving readability.
   Since Brushes.Aqua is a static property, the same instance of SolidColorBrush is returned each time,
which can be beneficial for memory usage if the same color is used frequently across the application.
   Using new SolidColorBrush(Colors.Red):
   This line creates a new instance of a SolidColorBrush, this time explicitly setting the color to Red.
This approach gives you the flexibility to use any color defined in the Colors class or even custom colors.
   By creating a new instance, you have the option to modify properties of the SolidColorBrush instance, 
such as its Opacity or other properties, without affecting any other uses of the same color elsewhere in your 
application.
   This approach is necessary when you need a unique instance of a brush for special cases where brush properties
might be dynamically changed.
   Summary
   Predefined Brushes (e.g., Brushes.Aqua): Use when you want a quick and memory-efficient way to set standard
colors without the need for customization beyond the color itself.
   Instantiating SolidColorBrush (e.g., new SolidColorBrush(Colors.Red)): Use when you need flexibility, 
such as adjusting additional properties or using non-standard colors, or when you want an independent 
instance to avoid side effects in other parts of the application.
 */