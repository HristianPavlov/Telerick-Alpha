using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrookedDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string x = Console.ReadLine();
           // Console.WriteLine(x.Length);
            for (int i=0;i<x.Length;i++)
            {
                if (x[i] >=48 && x[i]<=57)
                {
                    n += (int)Char.GetNumericValue(x[i]);
                }
                if (n>9)
                {
                    n -= 9;
                }
            }
            Console.WriteLine(n);

        }
    }
}
