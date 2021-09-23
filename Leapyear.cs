using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_practice_problems
{
    class Leapyear
    {
      public  static void calculateleapyear ()
        {
            int year = 2012;
            if (year % 4 == 0)
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                    Console.Write("{0} is not a leap year", year);
                else
                    Console.Write("{0} is a leap year", year);

            }
        }
    }
}
        
      
    




