using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AandB
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeTheNumbersMatch(28, 39, 20, 30);
        }
        // The following program increases/decreases the value of A and B until A is equal to X and B is equal to Y. Find the bug and its solution:
        //public static void MakeTheNumbersMatch(int a, int b, int x, int y)
        //{
        //    while (a != x && b != y)
        //    {
        //        if (a > x)
        //        {
        //            a--;
        //        }
        //        else
        //        {
        //            a++;
        //        }
        //        if (b > y)
        //        {
        //            b--;
        //        }
        //        else
        //        {
        //            b++;
        //        }
        //    }
        //}
         /* Solution */
        public static void MakeTheNumbersMatch(int a, int b, int x, int y)
        {
            while (a != x || b != y) // solution
            {
                if (a > x)
                {
                    a--;
                }
                else if (a < x) //
                {
                    a++;
                }
                if (b > y)
                {
                    b--;
                }
                else if (b < y) // 
                {
                    b++;
                }
                Console.WriteLine("a = " + a + " x = " + x);
                Console.WriteLine("b = " + b + " y = " + y);
                Console.WriteLine("--------------------------\n");
            }
            Console.WriteLine(" "+a+" "+b+" "+x+" "+y+" ");
            Console.Read();

        }
    }
}
