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
            Console.WriteLine("Open my repo");
            int n;
            Console.WriteLine("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                if((n>0) && (n < 10))
                {
                    Console.WriteLine("n is from 0 to 9");
                }
                else if(n==10){
                    Console.WriteLine("n is equal to 10");

                }
                else
                {
                    Console.WriteLine("n is greater than 10");
                }
            }

        }
    }
}
