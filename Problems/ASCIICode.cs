using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class ASCIICode
    {
        public void code()
        {

            char convert;
            Console.WriteLine("Enter a char ");
            convert = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII Value of " + convert + " " + Convert.ToInt32(convert));
        }
    }
}
