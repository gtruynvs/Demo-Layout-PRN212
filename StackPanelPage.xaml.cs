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
    /// Interaction logic for StackPanelPage.xaml
    /// </summary>
    public partial class StackPanelPage : Page
    {
        public StackPanelPage()
        {
            InitializeComponent();
        }
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car
            {
                Name = txtCarName.Text,
                Color = txtColor.Text,
                Brand = txtBrand.Text
            };

            MessageBox.Show(car.ToString(), "Car Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
