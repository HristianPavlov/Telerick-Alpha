using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheGate
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int monthNumber = int.Parse(Console.ReadLine());

            int day = int.Parse(Console.ReadLine())-1;
            int[] longg= { 1, 3, 5,7,8,10,12 };
            int[] shortt = { 4, 6, 9,11 };

            if (day==0)
            {

                 
                    monthNumber --;
                    if (monthNumber == 0)
                    {
                        monthNumber = 12;
                        year--;
                    }

                if (longg.Contains(monthNumber))
                {

                    day = 31;


                 }else if (shortt.Contains(monthNumber))
                {
                    day = 30;
                }
                else if (monthNumber==2 &&  year%4==0)
                {
                    day = 29;
                }
                else if (monthNumber == 2)
                {
                    day = 28;
                }



            }
        

            string month ="";
            
            switch (monthNumber)
            {
                case 1:
                    month = "Jan";
                    break;
                case 2:
                    month = "Feb";
                    break;
                case 3:
                    month = "Mar";
                    break;
                case 4:
                    month = "Apr";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Jun";
                    break;
                case 7:
                    month = "Jul";
                    break;
                case 8:
                    month = "Aug";
                    break;
                case 9:
                    month = "Sep";
                    break;
                case 10:
                    month = "Oct";
                    break;
                case 11:
                    month = "Nov";
                    break;
                case 12:
                    month = "Dec";
                    break;

            }
            Console.WriteLine("{0}-{1}-{2}",day,month,year);

        }
    }
}
