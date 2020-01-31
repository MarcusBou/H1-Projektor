using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potens_regner
{
    class Program
    {
         public static double tal, potens, output;

        static void Main(string[] args)
        {
            Console.Write("Dit primære tal: ");
            Double.TryParse(Console.ReadLine(), out tal);
            Console.Write("Din potens: ");
            Double.TryParse(Console.ReadLine(), out potens);

            potenser();
            Console.ReadKey();
        }

        static void potenser()
        {
            output = tal;
            for (int i = 0; i < potens-1; i++)
            {
                output = output * tal;
            }

            Console.WriteLine(output);
        }
    }
}
