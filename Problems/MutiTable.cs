using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class MutiTable
    {
        public void table()
        {
            int num, multi;
            Console.WriteLine("Enter the Number ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMulti Table  ", num);
            for (int i = 1; i <= 10; i++)
            {
                multi = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, multi);
            }
        }
    }
}
