using System;

namespace BirthdayAttack.Hash.OwnHash
{
    class HubaHash : IHash
    {
        public string Name => "Huba";

        public string ShortCutMessage(string message, int shortCutSizeInBits)
        {
            throw new NotImplementedException();
        }
    }
}
