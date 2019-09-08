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

namespace SpecialBoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BackgroundGenerators.StartUp();
        }

        private void BTNRun_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBBackground_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBRace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBSubRace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBSubClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBFeats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
