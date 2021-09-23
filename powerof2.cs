using System;

namespace Day5_practise_problems
{
    class Program
    {
        public static void calculatepowerof2()
        {
            Console.WriteLine("\tBasic Core Programs");

            int num;
            num = int.Parse(Console.ReadLine());


            Program p = new Program();
            bool flag = false;
            flag = p.IsPowerOf2(num);

            if (flag == true)
                Console.WriteLine("{0} is a number that is the power of 2.", num);
            else
                Console.WriteLine("{0} is not the power of 2.", num);
        }
        Boolean IsPowerOf2(int number)
        {
            while (number != 1)
            {
                if (number % 2 != 0)
                    return false;
                number = number / 2;
            }
            return true;
        }

    }
}