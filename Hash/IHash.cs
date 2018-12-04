using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAttack.Hash
{
    interface IHash
    {
        string ShortCutMessage(string message,int shortCutSizeInBits);
    }
}
