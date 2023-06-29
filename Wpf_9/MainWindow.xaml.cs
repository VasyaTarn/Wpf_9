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

namespace Wpf_9
{
    public partial class MainWindow : Window
    {
        private RoutedCommand redCommand;
        private RoutedCommand greenCommand;
        private RoutedCommand blueCommand;

        public MainWindow()
        {
            InitializeComponent();

            redCommand = new RoutedCommand("RedCommand", typeof(MainWindow));
            greenCommand = new RoutedCommand("GreenCommand", typeof(MainWindow));
            blueCommand = new RoutedCommand("BlueCommand", typeof(MainWindow));

            CommandBindings.Add(new CommandBinding(redCommand, RedCommand_Executed));
            CommandBindings.Add(new CommandBinding(greenCommand, GreenCommand_Executed));
            CommandBindings.Add(new CommandBinding(blueCommand, BlueCommand_Executed));

            InputBindings.Add(new KeyBinding(redCommand, new KeyGesture(Key.R, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(greenCommand, new KeyGesture(Key.G, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(blueCommand, new KeyGesture(Key.B, ModifierKeys.Control)));
        }

        private void RedCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SetButtonColor(Colors.Red);
        }

        private void GreenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SetButtonColor(Colors.Green);
        }

        private void BlueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SetButtonColor(Colors.Blue);
        }

        private void SetButtonColor(Color color)
        {
            button.Background = new SolidColorBrush(color);
        }
    }
}
