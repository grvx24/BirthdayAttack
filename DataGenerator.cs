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
        public delegate void UpdateStep(int counter,int max);
        public delegate void CompleteStep();
        public event UpdateStep UpdateEvent;
        public event CompleteStep CompleteEvent;

        public int[] GenerateUniqueIntegers(int length)
        {
            if (length > Int32.MaxValue / 2)
            {
                throw new ArgumentOutOfRangeException("Maximum length is: "+Int32.MaxValue/2);
            }

            Random rng = new Random();

            int startPoint = rng.Next(int.MinValue, int.MaxValue-length);
            int endPoint = startPoint + length;
            int difference = endPoint - startPoint;
            int[] result = new int[length];
            int counter = 0;

            for (int i = startPoint; i < endPoint; i++)
            {
                result[counter] = i;
                counter++;

                //update every 1000 steps
                if (counter % 1000 == 0)
                {
                    if (UpdateEvent != null)
                        UpdateEvent.Invoke(counter, difference);
                }
            }

            if(CompleteEvent!=null)
                CompleteEvent.Invoke();

            return result;

        }

    }
}
