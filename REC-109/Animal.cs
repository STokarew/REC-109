using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REC_109
{
    abstract class Animal
    {
        public string Say { get; }
        public Animal(string say)
        {
            Say = say;
        }
        public void ToTolk() => Console.WriteLine(Say);

    }
}