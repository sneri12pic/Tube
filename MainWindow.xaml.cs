using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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


namespace Tube
{
    public partial class MainWindow : Window
    {
        UndergroundFacade undergroundFacade = new UndergroundFacade();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, RoutedEventArgs e)
        {
            UndergroundFacade undergroundFacade_test = new UndergroundFacade();
            undergroundFacade_test.AddStation("1", "StationOne", 1);
            undergroundFacade_test.AddStation("2", "StationTwo", 2);
            undergroundFacade_test.AddStation("3", "StationThree", 3);
            undergroundFacade_test.AddStation("4", "StationFour", 4);
            undergroundFacade_test.AddStation("5", "StationFive", 5);
            txtOutput.Text = undergroundFacade_test.GetStationList(); //ToString basically
        }

        private void btn_loadStations_Click(object sender, RoutedEventArgs e)
        {
            //Location of the data to parse
            CSVReader reader = new CSVReader("C:\\Users\\Stepan\\source\\repos\\coursework2_OOSD\\coursework2_OOSD\\Data Layer\\Stations.csv");

            foreach (String[] line in reader.ReadFile())
            {
                undergroundFacade.AddStation(line[0], line[1], Int32.Parse(line[2]));
            }

            //Hides load stations grid and shows findStation grid
            grid_loadStations.Visibility = Visibility.Hidden;
            grid_findStation.Visibility = Visibility.Visible;
        }

        private void btn_findStation_Click(object sender, RoutedEventArgs e)
        {
            //IDs: 940GZZLUALD, 940GZZLUADE ... 
            string input = txtBox_findStation.Text;
            Station result = undergroundFacade.find(input);

            if (result == null) { txtOutput.Text = " No station found! "; }
            else { txtOutput.Text = result.ToString(); }
        }

        private void txtBox_findStation_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
