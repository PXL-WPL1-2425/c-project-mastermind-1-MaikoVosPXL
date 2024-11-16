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

namespace mastermindPEMaikoVosWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        string randomColorOne, randomColorTwo, randomColorThree, randomColorFour;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLoader(object sender, RoutedEventArgs e)
        {
            randomColorOne = PickingRandomColor(rnd.Next(0, 6));
            randomColorTwo = PickingRandomColor(rnd.Next(0, 6));
            randomColorThree = PickingRandomColor(rnd.Next(0, 6));
            randomColorFour = PickingRandomColor(rnd.Next(0, 6));
            this.Title = $"MasterMind: {randomColorOne}, {randomColorTwo}, {randomColorThree}, {randomColorFour}";
        }

        private string PickingRandomColor(int randomNumber)
        {
            switch (randomNumber)
            {
                case 0:
                    return "Red";
                case 1:
                    return "Yellow";
                case 2:
                    return "Orange";
                case 3:
                    return "White";
                case 4:
                    return "Green";
                case 5:
                    return "Blue";
                default:
                    return "Black";
            }
        }
    }
}
