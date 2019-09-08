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

            //intake all the info
            BackendGenerators.StartUp();

            //populate the combo boxes
            foreach (string i in BackendGenerators.Races.Keys)
            {
                CBRace.Items.Add(i);
            }
            foreach (string i in BackendGenerators.Classes.Keys)
            {
                CBClass.Items.Add(i);
            }
            foreach (string i in BackendGenerators.Backgrounds.Keys)
            {
                CBBackground.Items.Add(i);
            }
        }

        private void BTNRun_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBBackground_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            CBSubClass.Items.Clear();
            clearStatTextBlock();
            TBFeatExplanation.Text = null;
            CBFeats.Items.Clear();

            LBLSubClass.Visibility = Visibility.Visible;
            CBSubClass.Visibility = Visibility.Visible;

            LBLSubClass.Content = BackendGenerators.getSubClassType(Convert.ToString(CBClass.SelectedValue));

            string temp = "";
            for (int i = 0; i < BackendGenerators.Classes[Convert.ToString(CBClass.SelectedValue)].Length; i++)
            {
                if (BackendGenerators.Classes[Convert.ToString(CBClass.SelectedValue)][i] == '|')
                {
                    CBSubClass.Items.Add(temp);
                    temp = null;

                }
                else
                {
                    temp += BackendGenerators.Classes[Convert.ToString(CBClass.SelectedValue)][i];
                }
            }
            CBSubClass.Items.Add(temp);
        }

        private void CBRace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string to be used for confirmations later
            string t;

            //book keeping
            CBSubRace.Items.Clear();
            clearStatTextBlock();
            TBFeatExplanation.Text = null;
            CBFeats.Items.Clear();

            //fancy visability setting changes to only present relevant options
            if (BackendGenerators.Races[Convert.ToString(CBRace.SelectedValue)] != "")
            {
                CBSubRace.Visibility = Visibility.Visible;
                LBLSubRace.Visibility = Visibility.Visible;

                string temp = "";
                for (int i = 0; i < BackendGenerators.Races[Convert.ToString(CBRace.SelectedValue)].Length; i++)
                {
                    if (BackendGenerators.Races[Convert.ToString(CBRace.SelectedValue)][i] == '|')
                    {
                        CBSubRace.Items.Add(temp);
                        temp = null;
                    }
                    else
                    {
                        temp += BackendGenerators.Races[Convert.ToString(CBRace.SelectedValue)][i];
                    }
                }
                CBSubRace.Items.Add(temp);
            }
            else
            {
                CBSubRace.Visibility = Visibility.Hidden;
                LBLSubRace.Visibility = Visibility.Hidden;
            }
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

        //method to clear out the stat output TextBlock after a selection starts being chanegd
        private void clearStatTextBlock()
        {
            TBSTR.Text = "";
            TBDEX.Text = "";
            TBCON.Text = "";
            TBINT.Text = "";
            TBWIS.Text = "";
            TBCHA.Text = "";
        }
    }
}
