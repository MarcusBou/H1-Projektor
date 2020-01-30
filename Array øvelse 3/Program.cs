using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_øvelse_3
{
    class Program
    {
        static List<string> drengenavne = new List<string>() { "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar", "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias", "Anton", "Carl", "Silas", "Valdemar", "Benjamin", "Nikolaj", "Marcus", "August", "Sander", "Jacob" };
        static List<string> pigenavne = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                //menuen
                Console.Clear();
                string menuvalg;
            
                Console.WriteLine("Velkommen til navne array opgaven\nDe forskellige menuer, står her under:\n Tilføj drengenavn: 1\n Fjern drengenavn: 2\n Tilføj pigenavn: 3\n Fjern pigenavn: 4\n Drengenavne: 5\n Pigenavne: 6\n");
                Console.Write("Skriv nummeret for at gå ind på en af de over stående menuer: ");
                menuvalg = Console.ReadLine();

                if (menuvalg == "1")
                {
                    tilføjDrengenavn();
                }
                else if (menuvalg == "2")
                {
                    sletDrengeNavn();
                }
                else if (menuvalg == "3")
                {
                    tilføjPigenavn();
                }
                else if (menuvalg == "4")
                {
                    sletPigeNavn();
                }
                else if (menuvalg == "5")
                {
                    DrengenavneListe();
                }
                else if (menuvalg == "6")
                {
                    PigenavneListe();
                }
                else
                {
                    Console.WriteLine("dette er ikke et menuvalg");
                }

            }
        }

        //til at tilføje navne
        public static void tilføjDrengenavn()
        {
            string tilføjDreng;
            Console.Clear();
            Console.Write("Drenge navnet du ønsker at tilføje: ");
            tilføjDreng = Console.ReadLine();
            drengenavne.Add(tilføjDreng);
        }

        public static void tilføjPigenavn()
        {
            string tilføjPige;
            Console.Clear();
            Console.Write("Pige navnet du ønsker at tilføje: ");
            tilføjPige = Console.ReadLine();
            pigenavne.Add(tilføjPige);
        }

        //til at slette navne
        public static void sletDrengeNavn()
        {
            string Drengenavnet;
            Console.Clear();
            Console.Write("Drenge navnet du vil have slettet: ");
            Drengenavnet = Console.ReadLine();

            if (drengenavne.Contains(Drengenavnet))
            {
                drengenavne.Remove(Drengenavnet);
            }
            else
            {
                Console.WriteLine("dette navn findes ikke");
            }
        }
        public static void sletPigeNavn()
        {
            string Pigenavnet;
            Console.Clear();
            Console.Write("Pige navnet du vil have slettet: ");
            Pigenavnet = Console.ReadLine();

            if (drengenavne.Contains(Pigenavnet))
            {
                drengenavne.Remove(Pigenavnet);
            }
            else
            {
                Console.WriteLine("dette navn findes ikke");
            }
        }

        //til at se navnelisterne
        public static void DrengenavneListe()
        {
            Console.WriteLine("Her er alle drenge navne i systemet");
            for (int i = 0; i < drengenavne.Count; i++)
            {
                Console.WriteLine(drengenavne[i]);
            }

            Console.ReadKey();
        }

        public static void PigenavneListe()
        {
            Console.WriteLine("Her er alle Pige navne i systemet");
            for (int i = 0; i < pigenavne.Count; i++)
            {
                Console.WriteLine(pigenavne[i]);
            }

            Console.ReadKey();
        }
    }
}
