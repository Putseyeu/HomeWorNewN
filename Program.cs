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
            int minRandomNumber = 1;
            int maxRandomNumber = 28;
            int randomNumberN = random.Next(minRandomNumber, maxRandomNumber);
            int totalNumber = 0;
            int maxNumber = 1000;
            int minNumber = 100;

            for (int i = minNumber; i < maxNumber; i++)
            {
                int variableAlgorithm = i;
                while (variableAlgorithm >= randomNumberN)
                {
                    variableAlgorithm -= randomNumberN;
                    if (variableAlgorithm == 0)
                    {
                        totalNumber += 1;
                    }
                }
            }
            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {randomNumberN} равно {totalNumber}");
        }
    }   
}
