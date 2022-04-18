using System;
using System.Collections.Generic;

namespace REC_109
{
    
   
        class Program
        {
            static void Main(string[] args)
            {
                Animal cat = new Animal("мяу");
                Animal dog = new Animal("гав");
                Animal cow = new Animal("муу");
                Animal cock = new Animal("кококо");

                List<Animal> animals = new List<Animal>() { cat, dog, cow, cock };
                foreach (Animal a in animals)
                {
                    a.ToTolk();
                }

            }
       }
}
