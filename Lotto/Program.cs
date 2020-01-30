using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        public static int[] lottonumre = new int[7];
        public static int[] vinderNumre = new int[7];
        static void Main(string[] args)
        {
            while (true)
            {
            Random rnd = new Random();
            int ens = 0;
          
            for (int i = 0; i < lottonumre.Length; i++)
            {
                lottonumre[i] = rnd.Next(1, 21);
                vinderNumre[i] = rnd.Next(1, 21);

                if (lottonumre[i] == vinderNumre[i])
                {
                    ens++;
                }
            }
            if (ens == 7)
            {
                Console.WriteLine("Tillykke du har vundet");
            }

            Console.WriteLine("Dine lotto numre er:");
            Console.WriteLine("{0}", string.Join(" ", lottonumre));
            Console.WriteLine("\nvinder lotto numrene er");
            Console.WriteLine("{0}", string.Join(" ", vinderNumre));
            Console.WriteLine("\nDu havde " + ens + " ens med vindernumret");
            Console.ReadKey();
            }
        }
    }
}
