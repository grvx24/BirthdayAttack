using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BirthdayAttack.Hash;

namespace BirthdayAttack.Hash.OwnHash
{
    class ShortMD5 : IHash
    {
        public ShortMD5(int hashLengthInBytes)
        {
            if (hashLengthInBytes > 16)
            {
                throw new ArgumentOutOfRangeException("Maximum hash length is 16 bytes!");
            }
            this.HashLength = hashLengthInBytes;
        }
        protected int HashLength { get; set; }
        public string Name => "MD5_4bytes";

        public string ShortCutMessage(byte[] message)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(message);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < HashLength; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }

                return sb.ToString();
            }
            
        }

        public string ShortCutStringMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
