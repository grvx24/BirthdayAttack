using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAttack.FileFactory
{
    public class LoadingFileDto
    {
        public byte[] LoadedData { get; set; }

        public string FileName { get; set; }

        public int LoadedDataLength { get; set; }

        public int NumberOfMessages { get; set; }
    }
}
