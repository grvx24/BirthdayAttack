using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BirthdayAttack
{
    class DataGenerator : IDataGenerator
    {
        public int[] GenerateUniqueIntegers(int length)
        {
            if (length > Int32.MaxValue / 2)
            {
                throw new ArgumentOutOfRangeException("Maximum length is: "+Int32.MaxValue/2);
            }

            Random rng = new Random();

            int startPoint = rng.Next(int.MinValue, int.MaxValue-length);
            int[] result = new int[length];
            for (int i = startPoint; i < length; i++)
            {
                result[i] = i;
            }

            return result;

        }

    }
}
