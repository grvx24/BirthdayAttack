using Microsoft.Win32;
using System.IO;

namespace BirthdayAttack
{
    public static class FileManager
    {
        public static void SaveFile(int[] result)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
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
    }
}
