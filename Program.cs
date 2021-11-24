using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadratnoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\ta*x*x+b*x+c=0");
            int a, b, c;
            Console.WriteLine("\tPlease enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tPlease enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tPlease enter c");
            c = Convert.ToInt32(Console.ReadLine());
            double x,x1,x2, D;
            D = Math.Pow(b, 2) - (4 * a * c);
            if (D < 0)
                Console.WriteLine("\tNo solutions");
            if (D == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine($"\tx={x}");
            }
            if (D > 0)
            {
                x1 = -b - Math.Sqrt(D) / (2 * a);
                x2 = -b + Math.Sqrt(D)/(2 * a);
                Console.WriteLine($"\tx1={x1}\tx2={x2}");
            }
        }
    }
}
