using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Microsoft.Win32;

namespace BirthdayAttack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private byte[] loadedData;

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
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true)
            {
                loadedData = File.ReadAllBytes(fileDialog.FileName);
            }

            if (loadedData != null)
            {
                fileName_label.Content = "File name: "+fileDialog.SafeFileName;
                fileSize_label.Content = "File size: " + loadedData.Length + " bytes";
                MessagesNumber_label.Content = "Number of messages: " + loadedData.Length / sizeof(int);
            }
            else
            {
                fileName_label.Content = "File name: ";
                fileSize_label.Content = "File size: 0";
                MessagesNumber_label.Content = "Number of messages: 0";
            }

        }

        private void GenerateHashes_Click(object sender, RoutedEventArgs e)
        {
            if (loadedData == null)
            {
                MessageBox.Show("No file loaded!");
                return;
            }
        }

        private void GenerateMessage_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            string numOfMessages = message_num.Text;
            if (regex.IsMatch(numOfMessages))
            {   
                MessageBox.Show("Invalid length parameter!");
                return;
            }

            DataGenerator dg = new DataGenerator();
            //events
            dg.UpdateEvent += (int counter, int max) =>
            {
                Dispatcher.Invoke(() =>
                {
                    GeneratingData_label.Visibility = Visibility.Visible;
                    var percents = ((counter * 100) / max);
                    Generation_loading.Value = percents;
                    Loading_percents.Content = percents + "%";
                });


            };
            dg.CompleteEvent += () =>
            {
                Dispatcher.Invoke(() =>
                {
                    GeneratingData_label.Visibility = Visibility.Hidden;
                    Loading_percents.Content = "100%";
                });
            };

            Task.Run(() =>
            {
                var result = dg.GenerateUniqueIntegers(int.Parse(numOfMessages));

                Dispatcher.Invoke(() =>
                {
                    FileManager.SaveFile(result);
                });
            });
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
