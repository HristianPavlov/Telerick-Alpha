using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperCutter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Pow(2, 10));
            //Console.WriteLine(1563/20);
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[11];
            int[] qwerty = new int[11];
            arr[0] =( int)Math.Pow(2, 10);
            for(int i = 1; i <= 10; i++)
            {
                arr[i] = arr[i - 1]/2;
            }


           int j = 0;
            while (j<=10)
              
            {
                if (n >= arr[j])
                {
                    n = n - arr[j];
                    qwerty[j]= 1;

                    continue;
                }
                if (qwerty[j] == 0)
                {
                    Console.WriteLine("A{0}", j);
                }
                j++;
               

            }
            //for (int i = 0; i <= 10; i++)
            //{
              
               
            //}
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(left);
        }
    }
}
