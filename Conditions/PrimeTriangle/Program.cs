using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(0 % 5);
            int x = int.Parse(Console.ReadLine());
            int[] arr = new int[x + 1];
            for (int i = 0; i <=x; i++)
            {
                arr[i]=i;
            }
            int count = 1;
            int max = 0;
            for (int i = 2; i <= Math.Sqrt( arr.Length); i++)
            {
                if (arr[i] != 0)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[j] != 0) { 
                        if (arr[j] % i == 0)
                        {
                            arr[j] = 0;
                        }
                    }

                    }

                    
                }
            }

            for (int i=1;i<arr.Length;i++)
            {
                if (arr[i] != 0)
                {
                    count++;
                    max = i;
                    }
            }

            for (int i = 1; i <= max; i++)
            {
                if (arr[i] != 0) { 
                for (int j = 1; j <= i; j++)
                {
                        if (arr[j] != 0)
                        {
                            Console.Write(1);
                        }
                        else
                        {
                            Console.Write(0);
                        }
                }

                Console.WriteLine();
            }

            }





        }
    }
}
