using System;
using System.Collections.Generic;
using System.Text;

namespace Pokerly.Yuk
{
    public class Poker
    {
        public bool Draw()
        {
            System.Console.WriteLine("Playing");
            return true;
        }
    }

    public class TexasHoldemPoker : Poker
    {

    }
}
