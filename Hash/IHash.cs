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
        string ShortCutMessage(string message,int shortCutSizeInBits);
    }
}
