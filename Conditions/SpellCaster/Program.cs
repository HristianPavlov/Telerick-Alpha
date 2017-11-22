using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellCaster
{
    class Program
    {
        static void Main(string[] args)
        {
            string pssst = Console.ReadLine();
            //pssst[3] = "";
            List<string> parts = pssst.Split(new char[] { '\r', '\n', ',', '\t', ' ' }).ToList(); ;
            List<char> words = new List<char>(pssst.Length);

            //parts.Add("1");
            //parts.Add("2");
            //parts.Add("3");
            //parts.Add("4");
            //parts.Add("5");
            //parts.Add("6");
            //parts.Add("7");
            //parts.Add("8");
            int count = 1;
            int lampa = 0;
                string str = "";
            while (true)

            {
                for (int i = 0; i < parts.Count; i++)
                {
                    string kkk = parts[i];
                    int x = kkk.Length - count;
                    if (x >= 0)
                    {
                        words.Add(kkk[x]);
                        lampa = 1;
                        str += kkk[x];
                    }
                    

                }
                if (lampa == 0)
                {
                    break;
                }

                lampa = 0;
                count++;
            }
            int sedem=7;
            int deset = 10;
            deset %= sedem;
            Console.WriteLine(deset);

            Console.WriteLine(str);
            Console.WriteLine(str);
           // words.Insert(50, 'l');
            //Console.WriteLine(parts.Count);
            // parts.RemoveAt(2
            //parts.Insert(2, "3)");
            //foreach (char pussy in words)
            //{
            //    Console.Write(pussy);

            //}
            //Console.WriteLine();

            int s = words.Count-1;
            for(int i = 0; i <= s; i++)
            {
                char x = words[i];

                //int letterValue = char.ToLower(result[i]) - 'a' + 1; //giving the letters the Latin alphabet value
                int postition = (int)x;
                if (postition > 96)
                {
                    postition -= 96;
                }else
                {
                    postition -= 64;
                }
                postition += i;
                while (postition >= words.Count)
                {
                    postition -= words.Count;
                }
                words.RemoveAt(i);

                //if (postition >= s)
                //{
                //    words.Add(x);
                //}

                //else {
                    words.Insert(postition, x);
                //}
               
            }
            //  Console.WriteLine((int)'m');
            //Console.WriteLine((int)'a');
            //Console.WriteLine((int)'`');





            foreach (char pussy in words)
            {
                Console.Write(pussy);

            }
            Console.WriteLine();

            //static char[] MovingCharFromLeftToRight(char[] result, int position, int i)
            //{
            //    for (int j = i; j < position; j++)
            //    {
            //        char temp = result[j];
            //        result[j] = result[j + 1];
            //        result[j + 1] = temp;
            //    }
            //    return result;
            //}
            //static char[] MovingCharFromRightToLeft(char[] result, int position, int i)
            //{
            //    for (int j = i; j > position; j--)
            //    {
            //        char temp = result[j];
            //        result[j] = result[j - 1];
            //        result[j - 1] = temp;
            //    }
            //    return result;
            //}
        }
    }
}
