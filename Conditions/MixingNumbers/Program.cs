using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = int.Parse(Console.ReadLine());
            int[] subtract = new int[n - 1];
            int[] produce = new int[n - 1];
            for (int i = 1; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                subtract[i - 1] = Math.Abs( arr[i - 1] - arr[i]);
                


            }

            for (int i = 1; i < n; i++)
            {
                Console.Write((arr[i - 1] % 10) * (arr[i] / 10) + " ");

            }
            Console.WriteLine();

            for (int i = 0; i < n-1; i++)
            {
                Console.Write(subtract[i]+" ");

            }



        }
    }
}
