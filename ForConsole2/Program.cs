using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
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
            double s = 1;
            for (int i = 2; i <= x; i++)
            {
                s += 1.0 / i;
            }
            Console.WriteLine($"Sum = {s}");
        }
    }
}

