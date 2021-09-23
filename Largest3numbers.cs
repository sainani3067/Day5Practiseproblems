using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_practise_problems
{
    class Largest3numbers
    {
    static void Main calculatelargest3number ()
        {

            int first, second, third;
            Console.WriteLine("Enter the first number : ");
            first = int.num(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.num(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.num(Console.ReadLine());

            
            if (first > second)
            {
               
                if (first > third)
                {
                    Console.WriteLine("largest number : " + first);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("largest number : " + second);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
        }
    }

    

