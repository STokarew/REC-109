using System;
using System.Collections.Generic;

namespace REC_109
{
    
   
        class Program
        {
            static void Main(string[] args)
            {
                Cats cat = new Cats("мяу");
                Dogs dog = new Dogs("гав");
                Cows cow = new Cows("муу");
                Cocks cock = new Cocks("кококо");

                List<Animal> animals = new List<Animal>() { cat, dog, cow, cock };
                foreach (Animal a in animals)
                {
                    a.ToTolk();
                }
            Console.ReadKey();
            }
       }
}
