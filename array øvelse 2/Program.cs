using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_øvelse_2
{
    class Program
    {

        public static string[] drengenavne = { "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar", "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias", "Anton", "Carl", "Silas", "Valdemar", "Benjamin", "Nikolaj", "Marcus", "August", "Sander", "Jacob"  };

        static void Main(string[] args)
        {
            string søg;
            Console.Write("søg: ");
            søg = Console.ReadLine();
            Console.WriteLine("\n");
   

            for (int i = 0; i < drengenavne.Length; i++)
            {

                if (drengenavne.Contains(søg))
                {
                    Console.WriteLine("den findes i data basen");
                }
                drengenavne.Contains(søg);
                Array.Sort(drengenavne);
                Console.WriteLine(drengenavne[i]);
            }

            Console.ReadKey();

        }
    }
}
