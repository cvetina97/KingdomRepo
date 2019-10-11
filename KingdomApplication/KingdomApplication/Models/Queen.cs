using System;
using System.Collections.Generic;
using System.Text;
using KingdomApplication.Interfaces;

namespace KingdomApplication.Models
{
    public class Queen:ICharacter
    {
        public override void Fight()
        {
            Console.WriteLine("I will fight like a queen !");
        }
    }
}
