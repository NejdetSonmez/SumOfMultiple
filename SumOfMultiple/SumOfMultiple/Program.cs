using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiple
{
    class Program
    {
        static void SumOfMultiple(int limit)
        {          
            int sum = 0;
            for (int i = 1; i < limit; i++)
            {
                int value2 = i % 3 == 0 ? 3 : 0;
                int value1 = i % 5 == 0 ? 5 : 0;
                sum += (value1 + value2) > 0 ? i : 0;
            }
            OutPut(sum);
        }
        static void OutPut(int summation)
        {
          Console.WriteLine("Output: {0}",summation);
        }
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Welcome to SumOfMultiple! Please, enter a limit.");
            Console.Write("Input:");      
            input = Convert.ToInt16(Console.ReadLine());
            SumOfMultiple(input);
            Console.ReadKey();      
        }
    }
}
