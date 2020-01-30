using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_øvelse_3
{
    class Program
    {
        public static string[] drengenavne = { "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar", "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias", "Anton", "Carl", "Silas", "Valdemar", "Benjamin", "Nikolaj", "Marcus", "August", "Sander", "Jacob" };

        static void Main(string[] args)
        {
            string søg;
            Console.Write("søg: ");
            søg = Console.ReadLine();
            Console.WriteLine("\n");
            //
            if (drengenavne.Contains(søg))
            {
                Console.WriteLine("den findes i arrayet");
            }
            else
            {
                Console.WriteLine("findes ikke i arrayet");
            }

            for (int i = 0; i < drengenavne.Length; i++)
            {
                //viser alle navnene 
                drengenavne.Contains(søg);
                Array.Sort(drengenavne);
                Console.WriteLine(drengenavne[i]);
            }

            Console.ReadKey();

        }
    }
}
