using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    class Program
    {
        //(5x-1)/(1-n!)
        static void Main(string[] args)
        {
            double e = 0.01;
            double sum = 0, x;
            int n = 0;
            int factorial = 2;

            do
            {
                factorial *= factorial;

                if (n > 1)
                {
                    sum = (5 * x - 1) / (1 - factorial);
                    Console.WriteLine($"sum={sum}");
                }
                factorial++;

            } while (sum>e);


            Console.ReadKey();
        }




    }
}

