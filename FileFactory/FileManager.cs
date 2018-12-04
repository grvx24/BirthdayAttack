using Microsoft.Win32;
using System.IO;

namespace BirthdayAttack.FileFactory
{
    public static class FileManager
    {
        public static void SaveFile(int[] result,string fileName)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = fileName;
            if (fileDialog.ShowDialog() == true)
            {
                var stream = File.Open(fileDialog.FileName, FileMode.Create);
                using (BinaryWriter bw = new BinaryWriter(stream))
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        bw.Write(result[i]);
                    }
                }
            }
        }

        public static LoadingFileDto LoadMessagesFile()
        {
            LoadingFileDto result = new LoadingFileDto();

            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true)
            {
                result.LoadedData = File.ReadAllBytes(fileDialog.FileName);
                result.FileName = fileDialog.SafeFileName;
                result.LoadedDataLength = result.LoadedData.Length;
                result.NumberOfMessages = result.LoadedDataLength / sizeof(int);
            }

            return result;
        }
    }
}
