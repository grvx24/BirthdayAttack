using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAttack
{
    class Helpers
    {
        public static string ByteArrayToHex(byte[] input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i].ToString("x2"));
            }

            return sb.ToString();
        }

        //zmienić ulong na biginteger!!!
        public static double CountProbability(ulong n, ulong k)
        {
            if (n <= 0 || k <= 0)
            {
                throw new ArgumentException("n, k can't be lower than 0!");
            }

            double result = 1.0;

            for (ulong i = 1; i < n; i++)
            {
                var temp = (i / (double)k);
                var p = 1.0 - temp;
                result *= p;

            }

            return 1 - result;
        }
    }
}
