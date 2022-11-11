using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Power
    {
        public void Pow()
        {
            int number, number1, power, i;
            Console.WriteLine("Enter 1st num ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd num  ");
            number1 = Convert.ToInt32(Console.ReadLine());

            power = 1;
            i = 1;
            while (i <= number1)
            {
                power = power * number;
                i++;
            }
            Console.WriteLine("Power : " + power);
        }
    }
}
