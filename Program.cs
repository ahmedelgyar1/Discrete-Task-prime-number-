using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the frist number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                        count++;
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                    count = 0;
                }
                else
                {
                    count = 0;
                }

            }
        }
    }
}
