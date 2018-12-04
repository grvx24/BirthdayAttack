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
using BirthdayAttack.FileFactory;
using BirthdayAttack.Hash;
using Microsoft.Win32;

namespace BirthdayAttack
{
    public partial class MainWindow : Window
    {
        private byte[] loadedData;

        public MainWindow()
        {
            InitializeComponent();
            LoadHashList();
        }

        private void LoadHashList()
        {
            ListOfHashes.ItemsSource = HashManager.GetListOfAvailableFunctions();
        }

        private void LoadMessages_Click(object sender, RoutedEventArgs e)
        {
            var loadedFile = FileManager.LoadMessagesFile();
            loadedData = loadedFile.LoadedData;
            
            fileName_label.Content = "File name: " + loadedFile.FileName;
            fileSize_label.Content = "File size: " + loadedFile.LoadedDataLength;
            MessagesNumber_label.Content = "Number of messages: " + loadedFile.NumberOfMessages;
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
                    FileManager.SaveFile(result, DateTime.Now.ToString("ddMMyyyyHHmmss") + "_" + numOfMessages);
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
