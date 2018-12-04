using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace BirthdayAttack
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
        static String ReadingFromFile(String path)
        {
            string s = File.ReadAllText(path, Encoding.Default);
            return s;
        }

        private void LoadMessages_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerateHashes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerateMessage_Click(object sender, RoutedEventArgs e)
        {
            DataGenerator dg = new DataGenerator();
            var result=dg.GenerateUniqueIntegers(50);

            foreach (var n in result)
            {
                Trace.WriteLine(n);
            }
        }

        private void LoadHashes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchCollision_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SeeMore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
