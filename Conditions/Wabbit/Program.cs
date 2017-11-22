using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Wabbit
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(',').Select(p => int.Parse(p)).ToArray();
            int n = int.Parse(Console.ReadLine());
            BigInteger count = 0;
            BigInteger max = -1000000;
           
            for (int i=0;i<n;i++)
            {
                int[] hops = Console.ReadLine().Split(',').Select(p => int.Parse(p)).ToArray();
                int jumps = 0;
                int position = 0;
                int[] path = new int[arr.Length];
                path[0] = 1;
                count = arr[0];
                while (true)
                {
                    int x=jumps;
                    if (jumps > hops.Length - 1)
                    {
                         x= jumps % hops.Length;

                    }
                    int move = hops[x];
                    position +=move;

                    if (position >= arr.Length || position <= 0)
                    {
                        break;
                    }

                    if (path[position] == 1)
                    {
                        break;
                    }else
                    {
                        path[position] = 1;
                        count += arr[position];
                     

                    }
                    
                    jumps++;
                }
                if (count > max)
                {
                    max = count;
                }
                //count = 0;


            }
            Console.WriteLine(max);
        }
    }
}
