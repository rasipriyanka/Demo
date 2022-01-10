using OopsConcepts.ClassAndObjectConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
   class Program
    {
      public static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.breed="shitzu";
            dog1.color="white";
            Console.WriteLine("Dog1 details"+dog1.breed+","+dog1.color);
            Dog dog2 = new Dog();
            dog2.breed="goldenretriver";
            dog2.color="brown";
            Console.WriteLine("Dog2 details"+dog2.breed+","+dog2.color);

            Dog.Bark();
            Dog.Sleep();
        }
    }
}
