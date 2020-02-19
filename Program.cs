using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int method_sum(int a, int b)
        {
            int x, y, sum = 0, mask = 1;
            for (int i = 0; i < 32; i++)
            {
                x = a & mask;
                y = b & mask;
                if (x == 1 << i && y == 1 << i)
                {
                    sum |= 1 << (i + 1);
                }
                else if (x == 1 << i || y == 1 << i)
                {
                    sum |= 1 << i;
                }

                mask <<= 1;
            }
            return sum;
        }
        static void method_compare(int a, int b) { 
            int com = b & ((a - b) >> 31) | a & (~(a - b) >> 31);
            Console.WriteLine("{0} is bigger", com);
        
            /* int x = a;
             int y = b;
             int mask = 0;
             for (int i = 0; i < 32; i++)
             {
                 a = a << 1;
                 b = b << 1;
                 if (a == mask && b != mask)
                 {
                     Console.WriteLine("{0}<{1}", x, y);

                     break;
                 }
                 else
                 {
                     if (a != mask && b == mask)
                     {
                         Console.WriteLine("{0}>{1}", x, y);
                         break;
                     }

                 }
                 if (i == 31)
                 {
                     Console.WriteLine("{0}={1}", x, y);
                 }
             }
             */
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Shulman Denis IS-92(cs)");
            Console.Write("Enter first digit:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second digit:");
            int b = int.Parse(Console.ReadLine());

            int c = method_sum(a, b);
            Console.Write("Sum is : ");
            Console.WriteLine(c);
            method_compare(a, b);
            Console.ReadKey();

        }
    }
}
