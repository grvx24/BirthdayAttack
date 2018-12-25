using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAttack.Hash.OwnHash
{
    public class ShortMD4 : IHash
    {
        public ShortMD4(int hashLengthInBytes)
        {
            if (hashLengthInBytes > 16)
            {
                throw new ArgumentOutOfRangeException("Maximum hash length is 16 bytes!");
            }
            this.HashLength = hashLengthInBytes;
            this.Name = "MD4_" + HashLength + "bytes";
        }
        public int HashLength { get; set; }
        public string Name { get; }

        public string ShortCutMessage(byte[] message)
        {
            using (MD4 md4 = new MD4())
            {
                byte[] hash = md4.ComputeHash(message);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < HashLength; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }

                return sb.ToString();
            }

        }
    }
}
