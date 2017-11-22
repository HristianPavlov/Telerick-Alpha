using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            int even ;
            int odd ;
            int  n = int.Parse(Console.ReadLine());

            string[] kkk = new string[n];

            for (int i = 0; i < n; i++)
            {
                kkk[i] = Console.ReadLine();
            }

                
            for (int i = 0; i < n; i++)
            {
                even = 0;
                odd = 0;


                for (int j = 0; j < 4; j++)
                {
                    string k = kkk[i];
                    int digit = (int)Char.GetNumericValue(k[j]);
                    if (digit % 2 == 0)
                    {
                        even += digit;
                    }
                    else 
                    {
                        odd += digit;

                    }

                }
                if (odd > even)
                {
                    Console.WriteLine("right");

                }
                else if (odd < even)
                {
                    Console.WriteLine("left");
                }
                else
                {
                    Console.WriteLine("straight");
                }
            }
                //int gidig1 = (int)Char.GetNumericValue(kkk[0]);
                //int gidig2 = (int)Char.GetNumericValue(kkk[1]);
                //int gidig3 = (int)Char.GetNumericValue(kkk[2]);
                //int gidig4 = (int)Char.GetNumericValue(kkk[3]);


            


        }
    }
}
