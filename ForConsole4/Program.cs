using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b; bool f, f2;
            do
            {
                Console.Write("Enter A (a < b) = ");
                f = int.TryParse(Console.ReadLine(), out a);
                Console.Write("Enter B = ");
                f2 = int.TryParse(Console.ReadLine(), out b);
                if (f == false || f2 == false || a >= b) Console.WriteLine("Error");

            } while (f == false || f2 == false || a >= b);

            sqq(a, b);
        }
        static void sqq(int x, int y)
        {
            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum += i * i;
            }
            Console.WriteLine($"Dob = {sum}");
        }
    }
}
