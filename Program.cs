using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_descrite_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the number 2");
            int n2 = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                        sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine(i);
                    sum = 0;
                }
                else
                {
                    sum = 0;

                }
            }
        }
    }
}
