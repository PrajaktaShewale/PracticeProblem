using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Factorial
    {
        public void Fact()
        {
            Console.WriteLine("Enter Number ");
           int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int x = 1; x <= num; x++)
            {
                fact *= x;
            }
            Console.WriteLine(fact);
        }
    }
}
