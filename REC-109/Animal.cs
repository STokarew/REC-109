using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REC_109
{
    class Animal
    {
        public string say;
        public Animal(string _say)
        {
            say = _say;
        }
        public Animal(Animal a)
        {
            say = a.say;
        }
        public void ToTolk()
        {
            Console.WriteLine(say);
        }
    }
}