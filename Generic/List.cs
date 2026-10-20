using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharpConceptBoldLab.Generic
{
    public class Animal 
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Sound { get; set; }

       
    }
    public class program
    {
        public static void Main(string[] args)
        {
           var animals = new List<Animal>
            {
                new Animal { Name = "Dog", Age = 3, Sound = "Woof" },
                new Animal { Name = "Cat", Age = 2, Sound = "Meow" },
                new Animal { Name = "Cow", Age = 5, Sound = "Moo" }
            };
            foreach(var item in animals)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, Sound: {item.Sound}");
            }

            var barkingAnimal = from  animal in animals
                                where animal.Sound == "Woof"
                                select animal;

            foreach (var item in barkingAnimal)
            {
                Console.WriteLine($"Barking Animal: {item.Name}, Age: {item.Age}, Sound: {item.Sound}");
            }
        }
    }
}
