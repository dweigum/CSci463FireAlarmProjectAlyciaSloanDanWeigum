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
using System.Windows.Shapes;

namespace CSci463FireAlarmProjectAlyciaSloanDanWeigum
{
    /// <summary>
    /// Interaction logic for appWindow.xaml
    /// </summary>
    public partial class appWindow : Window
    {
        public appWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AlertTextBox.Text = "Fire and rescue have been called and are on the way.";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFloorAlarming.Visibility = Visibility.Collapsed;
            AlertTextBox.Text = "The alarm has been deactived.";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainFloorAlarming.Visibility = Visibility.Visible;
            AlertTextBox.Text = "The alarm has been activated. Fire and rescue have been called and are on the way.";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AlertTextBox.Text = "All camera feeds are being recorded.";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            VideoDisplayHeader.Visibility = Visibility.Visible;
            SecondFloorCamera.Visibility = Visibility.Visible;
            SecondFloorCameraLabel.Visibility = Visibility.Visible;
            FirstFloorCamera.Visibility = Visibility.Visible;
            FirstFloorCameraLabel.Visibility = Visibility.Visible;
            AlertTextBox.Text = "Video is now available on the left side of the application.";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MainFloorSensors.Visibility = Visibility.Visible;
            SecondFloorSensors.Visibility = Visibility.Visible;
            AlertTextBox.Text = "Sensors, cameras, sprinklers, and fire doors have been added to all levels.";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            SecondFloor.Visibility = Visibility.Visible;
            AlertTextBox.Text = "You added a level to the structure.";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MainFloor.Visibility = Visibility.Visible;
            AlertTextBox.Text = "You added a new structure to your system.";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden; 
            MainWindow.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden; 
            MainWindow.Show();
        }
    }
}
