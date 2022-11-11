using System;
namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Alphabets" + "\n" + "2.ASCII " + "\n" + "3. Multiplication" + "\n" + "4. power" + "\n" +
                    "5. Factorial" + "\n" + "6. Palindrome" + "\n" + "7. Exit");

                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Alphabets al = new Alphabets();
                        al.Alpha();
                        break;
                    case 2:
                        ASCIICode c = new ASCIICode();
                        c.code();
                        break;
                    case 3:
                        MutiTable multi = new MutiTable();
                        multi.table();
                        break;
                    case 4:
                        Power pow = new Power();
                        pow.Pow();
                        break;
                    case 5:
                        Factorial f = new Factorial();
                        f.Fact();
                        break;
                    case 6:
                        Palindrome p = new Palindrome();
                        p.Pali();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}