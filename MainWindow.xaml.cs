using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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
        private BirthdayAttackManager birthdayAttackManager;

        //Random files generator
        private int numOfFiles = 0;
        private int readyFiles = 0;


        //Calculating hash
        private int toHashFiles = 0;
        private int hashedFiles = 0;
        private LoadingFileDto[] loadedData;


        //Finding collision
        private Dictionary<string, ResultJsonModel[]> loadedHashesDict;
        private CollisionModel[] collisions;
        private int searchedFiles;
        private int filesToSearchCollision;

        private BigInteger[] messagesToBirthdayAttack;
        public MainWindow()
        {
            InitializeComponent();
            LoadHashList();
            Setup();
        }

        private void Setup()
        {
            birthdayAttackManager = new BirthdayAttackManager();
            birthdayAttackManager.UpdateEvent += CalculateHashesLoading;
            birthdayAttackManager.CompleteEvent += CalculateHashesComplete;

            birthdayAttackManager.SearchCollisionUpdateEvent += SearchCollisionLoading;
            birthdayAttackManager.SearchCollisionCompleteEvent += SearchCollisionComplete;
        }



        private void CountMessagesToBirthdatyAttack()
        {
            var hashes = HashManager.GetListOfAvailableFunctions();
            messagesToBirthdayAttack = new BigInteger[hashes.Count];
            for (int i = 0; i < hashes.Count; i++)
            {
                messagesToBirthdayAttack[i] = Helpers.CountBirthdayMessages(hashes[i].HashLength * 8);
            }
        }
        private void LoadHashList()
        {
            ListOfHashes.ItemsSource = HashManager.GetListOfAvailableFunctions();
        }

        private void LoadMessages_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = true
            };

            if (fileDialog.ShowDialog() == true)
            {
                if (fileDialog.FileNames.Length > 0)
                {
                    LoadingFilesToHashLabel.Visibility = Visibility.Visible;
                    Task.Run(() =>
                    {
                        
                        loadedData = FileManager.LoadMessagesFiles(fileDialog.FileNames, fileDialog.SafeFileNames);

                        Dispatcher.Invoke(() =>
                        {
                            toHashFiles = loadedData.Length;
                            FilesGrid.ItemsSource = loadedData;
                            LoadingFilesToHashLabel.Visibility = Visibility.Hidden;
                        });
                    });
                }
            }
        }

        private void GenerateHashes_Click(object sender, RoutedEventArgs e)
        {
            if (loadedData == null)
            {
                MessageBox.Show("No files loaded!");
                return;
            }
            SaveFileDialog fileDialog = new SaveFileDialog();
            string filename = null;
            if (fileDialog.ShowDialog() == true)
            {
                filename = fileDialog.FileName;
            }

            if (filename == null)
            {
                MessageBox.Show("No files selected!");
                return;
            }

            int hashIndex = ListOfHashes.SelectedIndex;
            Task.Run(() => {

                Stopwatch sw = new Stopwatch();
                sw.Start();
                birthdayAttackManager.GenerateJsonHashes(loadedData, filename, hashIndex);
                sw.Stop();
                Dispatcher.Invoke(() => { generationHashTime.Text = sw.ElapsedMilliseconds + "ms"; });
            });

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

            if (regex.IsMatch(numFilesToGenerate.Text))
            {
                MessageBox.Show("Invalid number of files!");
                return;
            }

            numOfFiles = Int32.Parse(numFilesToGenerate.Text);
            readyFiles = 0;

            DataGenerator dg = new DataGenerator();


            dg.UpdateEvent += (int counter, int max) =>
            {
                Dispatcher.Invoke(() =>
                {
                    generatingDataLabel.Visibility = Visibility.Visible;
                    var percents = ((counter * 100) / max);
                    Generation_loading.Value = percents;
                    Loading_percents.Content = percents + "% "+readyFiles + "/" + numOfFiles;
                });
            };
            dg.CompleteEvent += () =>
            {
                readyFiles++;
                Dispatcher.Invoke(() =>
                {
                    generatingDataLabel.Visibility = Visibility.Hidden;
                    Loading_percents.Content = "100% " + readyFiles+"/"+numOfFiles;
                    Generation_loading.Value = 100.0;
                });
            };

            string fileName = null;

            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog()==true)
            {
                fileName = fileDialog.FileName;
            }

            if (fileName != null)
            {
                Task.Run(() =>
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    int[][] results = new int[numOfFiles][];
                    for (int i = 0; i < results.Length; i++)
                    {
                        results[i] = dg.GenerateUniqueIntegers(int.Parse(numOfMessages));
                    }
                    FileManager.SaveFiles(results, fileName);
                    sw.Stop();
                    Dispatcher.Invoke(() => { generationTimeText.Text = sw.ElapsedMilliseconds + "ms"; });
                });
            }
            else
            {
                MessageBox.Show("Filename is not picked!");
            }

        }

        private void LoadHashes_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;

            string[] filenames = null;
            string[] safefilenames = null;
            if (fileDialog.ShowDialog() == true)
            {
                filenames = fileDialog.FileNames;
                safefilenames = fileDialog.SafeFileNames;
            }

            if (filenames == null)
            {
                MessageBox.Show("No files selected!");
                return;
            }
            var numOfFiles = filenames.Length;
            loadedHashesDict = new Dictionary<string, ResultJsonModel[]>(); 
            var loadedHashes = new ResultJsonModel[numOfFiles][];

            var serializer = new JavaScriptSerializer
            {
                MaxJsonLength = int.MaxValue
            };

            JsonHashesWarningLabel.Content = "Loading files...";

            Task.Run(() =>
            {
                for (int i = 0; i < numOfFiles; i++)
                {
                    string jsonString = File.ReadAllText(filenames[i], Encoding.UTF8);

                    try
                    {
                        var hashesFromJson= serializer.Deserialize<ResultJsonModel[]>(jsonString);
                        loadedHashesDict.Add(safefilenames[i],hashesFromJson);
                    }
                    catch (Exception)
                    {
                        SearchCollisionBtn.IsEnabled = false;
                        JsonHashesWarningLabel.Content = "Invalid Json format, please use file generated by this application!";
                        JsonHashesWarningLabel.Foreground = new SolidColorBrush(Colors.Red);
                        JsonHashesWarningLabel.Visibility = Visibility.Visible;
                        return;
                    }
                }

                Dispatcher.Invoke(() =>
                {
                    SearchCollisionBtn.IsEnabled = true;
                    JsonHashesWarningLabel.Foreground = new SolidColorBrush(Colors.Green);
                    JsonHashesWarningLabel.Content = "Files has been loaded successfully, now you can search collisions!";
                    BAttackLoadedFilesLabel.Content = numOfFiles + " files loaded.";
                    filesToSearchCollision = numOfFiles;
                });        
            });


        }

        private void SearchCollision_Click(object sender, RoutedEventArgs e)
        {
            if (loadedHashesDict.Count == 0)
            {
                return;
            }

            int numOfFiles = loadedHashesDict.Count;

            searchedFiles = 0;
            collisions = new CollisionModel[numOfFiles];
            int i = 0;

            JsonHashesWarningLabel.Content = "Finding collisions...";

            
            Task.Run(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                foreach (var item in loadedHashesDict)
                {
                    collisions[i] = birthdayAttackManager.FindCollision(item.Value, item.Key);
                    i++;
                }

                int collisionsFound = 0;
                for (int j = 0; j < collisions.Length; j++)
                {
                    if (collisions[j].HasCollision)
                        collisionsFound++;

                }
                sw.Stop();
                Dispatcher.Invoke(() =>
                {
                    collisions_num.Text = collisionsFound.ToString();
                    hash_num.Text = numOfFiles.ToString();
                    searchingCollisionsTime.Text = sw.ElapsedMilliseconds + "ms";

                    if (collisionsFound > 0)
                    {
                        var filesWithCollision = collisions.Where(item => item.HasCollision == true);
                        FilesWithCollision.ItemsSource = filesWithCollision;
                    }
                });

            });

        }

        private void SeeMore_Click(object sender, RoutedEventArgs e)
        {
            tabItems.SelectedIndex = 2;
        }

        private void ListOfHashes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GenerateHashesBtn.IsEnabled = true;           
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numFilesToGenerate.Text, out int result);
            if (result < 99)
            {
                result++;
            }

            numFilesToGenerate.Text = result.ToString();
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numFilesToGenerate.Text, out int result);
            if (result > 1)
            {
                result--;
            }

            numFilesToGenerate.Text = result.ToString();
        }


        //events
        private void SearchCollisionLoading(int counter, int max)
        {
            Dispatcher.Invoke(() =>
            {
                var percents = ((counter * 100) / max);
                findCollisionLoading.Value = percents;
                findCollisionLabel.Content = percents + "% " + searchedFiles + "/" + filesToSearchCollision;
            });
        }

        private void SearchCollisionComplete()
        {
            searchedFiles++;
            Dispatcher.Invoke(() =>
            {
                JsonHashesWarningLabel.Content = "";
                findCollisionLoading.Value = 100.0;
                findCollisionLabel.Content = 100 + "% " + searchedFiles + "/" + filesToSearchCollision;
            });

        }
        private void CalculateHashesLoading(int counter, int max)
        {
            Dispatcher.Invoke(() =>
            {
                hashingDataLabel.Visibility = Visibility.Visible;
                var percents = ((counter * 100) / max);
                GenerateHashesLoading.Value = percents;
                HashesLoadingPercents.Content = percents + "% " + hashedFiles + "/" + toHashFiles;
            });
        }
        private void CalculateHashesComplete()
        {
            hashedFiles++;
            Dispatcher.Invoke(() =>
            {
                hashingDataLabel.Visibility = Visibility.Hidden;
                HashesLoadingPercents.Content = "100% " + hashedFiles + "/" + toHashFiles;
                GenerateHashesLoading.Value = 100.0;
            });
        }

        private void FilesWithCollision_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listbox = sender as ListBox;
            var item = listbox.SelectedItem as CollisionModel;
            if (item != null)
            {
                CollisionsTable.ItemsSource = item.Data.ToArray();
            }

        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }


        private void ImageMouseEnter_event(object sender, MouseEventArgs e)
        {

            Image img = sender as Image;

            switch (img.Name)
            {
                case "Paulina":
                    {
                        PaulinaLabel.Text = "Paulina Mrozek";
                        break;
                    }
                case "Kamil":
                    {
                        KamilLabel.Text = "Kamil Sagalara";
                        break;
                    }
                case "Hubert":
                    {
                        HubertLabel.Text = "Hubert Springer";
                        break;
                    }

                default:
                    {
                        return;
                    }
            }
            
        }

        private void ImageMouseLeave_event(object sender, MouseEventArgs e)
        {
            string[] hashes =
{
                "4b50d6210fde8f98b57800f469d0f185538e1419e287b339956407f86cd75bac",
                "15ce329305b63521d7149c50457ef7c79fb2e7675dfbcc9c436a63ed0d3f7a00",
                "26f9762a8e6a78caf319db200ff42f325018b1f5b31f6dcb59b789d16e481ffe"
            };

            Image img = sender as Image;

            switch (img.Name)
            {
                case "Paulina":
                    {
                        PaulinaLabel.Text = hashes[0];
                        break;
                    }
                case "Kamil":
                    {
                        KamilLabel.Text = hashes[1];
                        break;
                    }
                case "Hubert":
                    {
                        HubertLabel.Text = hashes[2];
                        break;
                    }

                default:
                    {
                        return;
                    }
            }
        }

        private void numFilesToGenerate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
