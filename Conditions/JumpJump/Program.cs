using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpJump
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] psss = Console.ReadLine().ToCharArray();
            int i = 0;
            
            while (true)
            {

                int x = (int)Char.GetNumericValue(psss[i]);
                if (psss[i] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                    break;

                }
                else if (psss[i] == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", i);
                    break;
                }
                else if ( x%2==0)
                {
                    i += x;
                }else if (x % 2 != 0)
                {
                    i -= x;
                }

                if(i>=psss.Length || i < 0)
                    Console.WriteLine("Fell off the dancefloor at {0}!", i);
                {
                    break;

                }

            }

        }
    }
}
