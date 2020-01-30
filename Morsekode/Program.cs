using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekode
{
    class Program
    {
        static char[] alfabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p' , 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å' };
        static string[] morsekode = { ".-", "-...", "-.-.", "-..", ".", "..-", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".-.-", "---", ".--.-" };
        static void Main(string[] args)
        {
            string sætning;

            Console.Write("hvad ønsker du oversat til morsekode: ");
            sætning = Console.ReadLine();
            char[] sætningArr = sætning.ToCharArray();

            for (int i = 0; i < sætningArr.Length; i++)
            {
                Console.WriteLine(sætningArr[i]);
                
            }
            Console.ReadKey();
        }
    }
}
