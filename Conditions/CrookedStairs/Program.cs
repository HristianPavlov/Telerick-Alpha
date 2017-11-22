using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CrookedStairs
{

    class Program
    {
        static void Main(string[] args)
        {
            //int a= int.Parse(Console.ReadLine());
            //int b= int.Parse(Console.ReadLine());
            //int c= int.Parse(Console.ReadLine());
            //Console.WriteLine(4/3);
            //Console.WriteLine(5/3);

            BigInteger[] arr = new BigInteger[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = BigInteger.Parse(Console.ReadLine());

            }
            int height = int.Parse(Console.ReadLine());

            //if (i < 3)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //List<int> bricks = new List<int>();
            if (height>0)
            {
                Console.WriteLine(arr[0]);
            }
            if (height > 1)
            {
                Console.WriteLine(arr[1] + " " + arr[2]);
            }
            //Console.WriteLine();

            for (int i = 3; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int n = j;
                    
                        if (n >= 3)
                        {
                            n  %= 3;
                        }
                    
                    arr[n] = arr[0] + arr[1] + arr[2];

                    if (j!=i-1)
                    {
                        Console.Write("{0} ", arr[n]);
                    }
                    else
                    {
                        Console.WriteLine("{0}", arr[n]);
                    }

                    
                }
               


            }


        }
    }
}
