using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_practise_problems
{
    class Even_or_Odd
    {
         public static void calculateevenorodd()
            {
            int a = 24;
            int b = 34;

                Console.WriteLine("Even numbers between {0} and {1}: ", a, b);
                for ( a= a; a<= b; a++)
                {
                    if (a % 2 == 0)
                        Console.WriteLine(a + " ");
                }
            }
        }
    }

