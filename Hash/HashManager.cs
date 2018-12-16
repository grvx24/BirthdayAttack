using BirthdayAttack.Hash.OwnHash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public static Dictionary<ResultJsonModel, ResultJsonModel> FindCollision(ResultJsonModel[] loadedHashes)
        {
            Array.Sort(loadedHashes, delegate (ResultJsonModel x, ResultJsonModel y) { return x.HexHash.CompareTo(y.HexHash); });

            Dictionary<ResultJsonModel, ResultJsonModel> collisionList = new Dictionary<ResultJsonModel, ResultJsonModel>();
            for (int i = 0; i < loadedHashes.Length - 1; i++)
            {
                if (loadedHashes[i].HexHash == loadedHashes[i + 1].HexHash)
                {
                    collisionList.Add(loadedHashes[i], loadedHashes[i + 1]);
                }
            }

            return collisionList;
        }
    }
}
