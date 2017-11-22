using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            string position = Console.ReadLine();
            
            string word = "";
            while (position != "end")
            {
                sbyte count = sbyte.Parse(Console.ReadLine());
                string sentence = Console.ReadLine();
                sbyte start = sbyte.Parse(position);
                sbyte move = start;
                sbyte x = (sbyte)sentence.Length;
               // move = (sbyte)x;
                if (start < 0)
                {
                    move +=(sbyte)x;
                }
                
                    while(move >= 0 && move < sentence.Length)
                    {
                        word += sentence[move];
                        move += count;
                    }
                
                

                position = Console.ReadLine();
             
                
            }

            Console.WriteLine(word);



        }
    }
}
