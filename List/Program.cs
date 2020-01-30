using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        public static List<int> tal = new List<int>() { 1, 2, 4, 5, 7, 8, 10, 11, 13, 14, 16, 17, 19, 20 };
        static void Main(string[] args)
        {
            tal[3] = 17;

            for (int i = 0; i < tal.Count; i++)
            {
                Console.WriteLine(tal[i]);
            }
            Console.ReadKey();
        }
    }
}
