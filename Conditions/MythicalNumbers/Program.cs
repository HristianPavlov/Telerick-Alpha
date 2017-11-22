using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string  one = Console.ReadLine();
            double first = Char.GetNumericValue( one[0]);
            double second = Char.GetNumericValue(one[1]);
            double third = Char.GetNumericValue(one[2]);
            //Console.WriteLine("{0}{1}{2}", first, second, third);
            if (third == 0)
            {
                Console.WriteLine("{0:F2}",second * first);
            }
            else if(0<third && third <= 5)
            {
                Console.WriteLine("{0:F2}", second * first/third);

            }
            else
            {
                Console.WriteLine("{0:F2}", (second + first )* third);

            }

        }
    }
}
