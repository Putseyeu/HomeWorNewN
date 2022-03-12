using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(1, 28);
            Console.WriteLine(n);
            int totalNumber = 0;
            int maxNumber = 1000;
            int minNumber = 100;

            for (int i = minNumber; i < maxNumber; i++)
            {
                int c = i;
                while (c >= n)
                {
                    c -= n;
                    if (c == 0)
                    {
                        totalNumber += 1;
                    }
                }
            }
            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {n} равно {totalNumber}");
        }
    }
}
