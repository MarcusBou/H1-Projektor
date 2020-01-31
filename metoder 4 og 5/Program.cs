using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_4_og_5
{
    class Program
    {
        public static int[] reverse = new int[9];
        public static int[] normal = new int[9];
        static void Main(string[] args)
        {
            valueLoop();
            printValue();
            Console.ReadKey();
        }

        public static void valueLoop()
        {
            for (int i = 0; i <= normal.Length -1; i++)
            {
                normal[i] = i + 1;
                reverse[i] = i + 1;
            }
        }

        public static void printValue()
        {
            for (int i = 0; i <= normal.Length -1; i++)
            {
                Console.WriteLine(normal[i]);
            }
            Console.WriteLine("\n");
            Array.Reverse(reverse);
            for (int i = 0; i <= reverse.Length - 1; i++)
            {
                Console.WriteLine(reverse[i]);
            }
        }
    }
}
