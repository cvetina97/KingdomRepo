using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomApplication.Interfaces
{
    public abstract class ICharacter
    {
        public abstract void Fight();

        public void WashMySocks()
        {
            Console.WriteLine("wash them!");
        }
    }
}
