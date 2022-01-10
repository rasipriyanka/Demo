using System;
using System.Collections.Generic;
using System.Text;


namespace additiontwonumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER THE VALUE OF A :- ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE VALUE OF B :- ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("ADDITION OF TWO NUMBER IS :- "+c);
            Console.ReadLine();
        }
    }
}
