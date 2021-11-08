using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0; bool f;
            do
            {

                do
                {
                    Console.Write("Number = ");
                    f = int.TryParse(Console.ReadLine(), out number);
                    if (f == false) Console.WriteLine("Error");
                } while (f == false);
                sum += number;

            } while (number != 0);
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
