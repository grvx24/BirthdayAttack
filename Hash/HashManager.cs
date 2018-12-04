using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAttack.Hash
{
    public static class HashManager
    {
        public static List<Hash> GetListOfAvailableFunctions()
        {
            List<Hash> result = new List<Hash>();

            result.Add(new Hash("Huba",1));
            result.Add(new Hash("Kamel Korniszonke", 2));
            result.Add(new Hash("Pralina Malina", 3));

            return result;
        }
    }
}
