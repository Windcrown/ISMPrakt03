using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; bool f, f2; double a;
            do
            {
                Console.Write("Enter A = ");
                f = double.TryParse(Console.ReadLine(), out a);
                Console.Write("Enter N (N > 0) = ");
                f2 = int.TryParse(Console.ReadLine(), out n);
                if (f == false || f2 == false || n <= 0) Console.WriteLine("Error");

            } while (f == false || f2 == false || n <= 0);

            pow(a, n);
        }
        static void pow(double x, int y)
        {
            double res = 1;
            for (int i = 1; i <= y; i++)
            {
                res *= x;
            }
            Console.WriteLine($"Res = {res}");
        }
    }
}

