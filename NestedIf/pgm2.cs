using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIf
{
    internal class pgm2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is my second main");
            
            int n;
            Console.WriteLine("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}",n,i,n*i);
            }
            Console.ReadLine();
        }
    }
}
