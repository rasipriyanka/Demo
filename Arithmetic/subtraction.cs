using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetic
{
   
    public  class sub
        {
      public static void subtract()
            {
                int num1, num2;
                Console.WriteLine("enter 1st num= ");
                num1=int.Parse(Console.ReadLine());
                Console.WriteLine("enter 2nd num= ");
                num2=int.Parse(Console.ReadLine());

                int result = num1-num2;

                Console.WriteLine("Subtraction is: "+result);
                
            }
        }
    }

