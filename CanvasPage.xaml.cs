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

namespace Demo_WPF
{
    /// <summary>
    /// Interaction logic for CanvasPage.xaml
    /// </summary>
    public partial class CanvasPage : Page
    {
        public CanvasPage()
        {
            InitializeComponent();
        }
        private void btnCanvasDisplay_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car
            {
                Name = txtCanvasCarName.Text,
                Color = txtCanvasColor.Text,
                Brand = txtCanvasBrand.Text
            };

            MessageBox.Show(car.ToString(), "Car Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            // Quay lại trang trước đó
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
