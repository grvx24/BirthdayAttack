using System;

namespace BirthdayAttack.Hash.OwnHash
{
    class HubaHash : IHash
    {
        public string Name => "Huba";

        public string ShortCutMessage(byte[] message)
        {
            throw new NotImplementedException();
        }

        public string ShortCutStringMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
