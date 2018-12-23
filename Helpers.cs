using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        //not used!!!
        private static double CountProbability(BigInteger n, BigInteger k)
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

        //not used - it's too slow
        public static BigInteger CountBirthdayMessages(int hashLengthInBits)
        {
            if(hashLengthInBits>32)
            {
                throw new ArgumentOutOfRangeException("Do not use values above 32, calculation is too slow!!!");
            }
            
            BigInteger allMessages = BigInteger.Pow(2, hashLengthInBits);
            BigInteger allMessages_half = BigInteger.Pow(2, hashLengthInBits/2);
            BigInteger numOfMessages = 0;
            for (var i = allMessages_half; i < allMessages; i++)
            {
                var probability=CountProbability(i, allMessages);
                if (probability >= 0.5)
                {
                    numOfMessages = i;
                    break;
                }
            }

            return numOfMessages;
        }
    }
}
