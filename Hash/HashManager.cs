using BirthdayAttack.Hash.OwnHash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BirthdayAttack.FileFactory;
using System.Web.Script.Serialization;
using System.IO;

namespace BirthdayAttack.Hash
{
    public static class HashManager
    {
        private static List<IHash> HashList = new List<IHash>()
        {
            new ShortMD4(1),
            new ShortMD4(2),
            new ShortMD4(4),
            new ShortMD5(1),
            new ShortMD5(2),
            new ShortMD5(4),
            new ShortSha256(1),
            new ShortSha256(2),
            new ShortSha256(4),
            new Crc8(),
            new Crc16(),
            new Crc32()

        };

        public static List<IHash> GetListOfAvailableFunctions()
        {
            return HashList;
        }

        public static string ShortCutMessageBySpecificFunction(byte[] msg, int id)
        {
            return HashList[id].ShortCutMessage(msg);
        }
        
    }
}
