using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; bool f;

            do
            {
                Console.Write("Enter N (> 0) = ");
                f = int.TryParse(Console.ReadLine(), out n);
                if (f == false || n <= 0) Console.WriteLine("Error");

            } while (f == false || n <= 0);

            sum(n);
        }


        static void sum(int x)
        {
            double s = 0; int temp = x;
            for (int i = 1; i <= x; i++)
            {
               s += Math.Pow(i, temp--);
            }
            Console.WriteLine($"Sum = {s}");
        }
    }
}
