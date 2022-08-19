using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello pgm");

            int n;
            Console.WriteLine("Enter n: ");
            n=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n ; i++)
            {
                if (i >= 0)
                {
                    Console.WriteLine("Number is "+i);
                }
                else
                {
                    Console.WriteLine("less than 0");
                }
            }
            Console.ReadKey();

        }
    }
}
