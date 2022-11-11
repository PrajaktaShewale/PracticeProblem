using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problems
{
    internal class Palindrome
    {
        public void Pali()
        {
            Console.Write("Enter a Number To Check Palindrome : ");
            //int number = int.Parse(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                remineder = number % 10;
                sum = (sum * 10) + remineder;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }

        }
    }
}
