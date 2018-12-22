using System.Collections.Generic;
using Microsoft.Win32;
using System.IO;
using BirthdayAttack.Hash;

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

        public static void SaveFiles(int[][] result, string fileName)
        {
            for (int i = 0; i < result.Length; i++)
            {
                var stream = File.Open(fileName + "_" + i, FileMode.Create);
                using (BinaryWriter bw = new BinaryWriter(stream))
                {
                    for (int j = 0; j < result[i].Length; j++)
                    {
                        bw.Write(result[i][j]);
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

        public static LoadingFileDto[] LoadMessagesFiles(string[] filenames,string[] safefilenames)
        {
            LoadingFileDto[] results = null;

            var numOfFiles = filenames.Length;
            if (numOfFiles == 0)
            {
                return null;
            }

            results = new LoadingFileDto[numOfFiles];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = new LoadingFileDto();
            }
            for (int i = 0; i < numOfFiles; i++)
            {
                results[i].LoadedData = File.ReadAllBytes(filenames[i]);
                results[i].FileName = safefilenames[i];
                results[i].LoadedDataLength = results[i].LoadedData.Length;
                results[i].NumberOfMessages = results[i].LoadedDataLength / sizeof(int);
            }
            return results;
        }

    }
}
