using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; bool f;

            do
            {
                Console.Write("Enter N (> 1) = ");
                f = int.TryParse(Console.ReadLine(), out n);
                if (f == false || n <= 1) Console.WriteLine("Error");

            } while (f == false || n <= 1);

            min(n);
        }


        static void min(int x)
        {
            for (int i = 1; i <= x; i++)
            {
               if (Math.Pow(3, i) > x)
                {
                    Console.WriteLine($"Min = 3^{i}");
                    break;
                }
            }
        }
    }
}
