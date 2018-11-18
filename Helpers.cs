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
        public static string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
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
