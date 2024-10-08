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

namespace Demo_WPF
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

        private void NavigateToCanvasPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new CanvasPage();
        }

        private void NavigateToWrapPanelPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new WrapPanelPage();
        }

        private void NavigateToStackPanelPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new StackPanelPage();
        }

        private void NavigateToDockPanelPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new DockPanelPage();
        }

        private void NavigateToGridPanelPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new GridPanelPage();
        }


    }
}