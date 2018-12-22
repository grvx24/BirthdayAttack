using System;

namespace BirthdayAttack.Hash.OwnHash
{
    class HubaHash : IHash
    {
        public string Name => "Huba";

        public int HashLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
