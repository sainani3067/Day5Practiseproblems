using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_practise_problems
{
    class Swapof2numbers
    {
        static void  findSwapof2numbers()
        {

            //initializing num1 by 3 and num2 by 6
            int num1 = 3, num2 = 6;

            Console.WriteLine("Numbers before interchanging : \n num1 = " + num1 + " \n num2 = " + num2);

            //logic to interchange values from num1 --> num2 and num2 --> num1
            // interchanging the numbers using arithmetic operators like + and -
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("Numbers after interchanging : \n num1 = " + num1 + "  \n num2 = " + num2);

        }

    }

} 
    

