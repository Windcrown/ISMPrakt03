using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, res = 10; bool f;

            do
            {
                Console.Write("Enter Percent = ");
                f = int.TryParse(Console.ReadLine(), out p);
                if (f == false) Console.WriteLine("Error");

            } while (f == false);
            test(p, res);
        }


        static void test(double percent, double s)
        {
            percent /= 100;
            percent += 1;
            double speed = s;
            double res = 0;
            for (int i = 2; ; i++)
            {
                speed *= percent;
                res += speed;
                if (res > 200)
                {
                    Console.WriteLine($"Man ran {res} km in {i} days");
                    break;
                }
            }

        }
    }
}
