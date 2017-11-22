using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;
namespace CrookedWalls
{
    class Program
    {
        static void Main(string[] args)
        {
            string psss = Console.ReadLine();

            long[] arr = Regex.Split(psss, @"\s+").Where(p=>p.Length>0).Select(p => long.Parse(p)).ToArray();
            //BigInteger[] skipping = new int[arr.Length];
            long j = 1;
            //int i = 0;
            BigInteger sum = 0;
            while (j<arr.Length)
            {
                //BigInteger cat = (BigInteger)arr[j - 1];
                BigInteger x=new BigInteger( Math.Abs(arr[j - 1]-   arr[j]));

                if (x % 2 == 0)
                {
                    sum += x;
                    j += 2;
                   
                }
                else
                {
                    j++;
                }

            }
            Console.WriteLine(sum);
            //for(int x = 0; x < skipping.Length; x++)
            //{
                
            //}
        }
    }
}
