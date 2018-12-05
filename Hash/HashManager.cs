using BirthdayAttack.Hash.OwnHash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAttack.Hash
{
    public static class HashManager
    {
        private static List<IHash> HashList = new List<IHash>()
        {
            new HubaHash(),
            new ShortMD5(4)
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
