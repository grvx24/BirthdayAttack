using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAttack.Hash
{
    public interface IHash
    {
        string Name { get; }
        int HashLength { get; set; }
        string ShortCutMessage(byte[] message);
        string ShortCutStringMessage(string message);
    }
}
