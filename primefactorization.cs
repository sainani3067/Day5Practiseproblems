using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_practise_problems
{
    class primefactorization
    {
   
             public static void Prime()
            {
                Console.WriteLine("Enter the number :");
                int n, a = 0;
                n = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine("{0} is a Prime Number", n);
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
                Console.ReadLine();
            }
        }
    }


