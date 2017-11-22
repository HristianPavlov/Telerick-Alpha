using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your number: ");
            ulong number = ulong.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());
            byte value = byte.Parse(Console.ReadLine());

            Console.WriteLine(bin(number, position, value));


        
                //Console.WriteLine("Third bit is '0' " + Convert.ToString(number,2).PadLeft(16, '0'));
               

         

        }

        static ulong bin(ulong number, byte position, byte value) 
        {

            if (value == 0)
            {
                ulong mask = ~((ulong)1 << position);
                ulong found = number & mask;
               
                
                    return found;

                

            }
            else
            {
                ulong mask = ((ulong)1 << position);
                ulong found = number | mask;

               
                    return found;
            
            }

        }

    }
}
