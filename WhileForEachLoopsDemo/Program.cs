using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileForEachLoopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // average of all numbers

            

            while (true)
            {
                Console.Write("enter a number to calculate the average from 1 to number: ");

                int num = int.Parse(Console.ReadLine());
                int firstNum = 1;
                int total = 0;

                while (firstNum <= num)
                {
                    total += firstNum;
                    firstNum++;
                }

                Console.WriteLine($"average of all numbers from 1 to {num}: " + total / num);
                Console.WriteLine();
            }

            
            Console.ReadLine();
        }
    }
}
