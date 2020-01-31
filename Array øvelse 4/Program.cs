using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_øvelse_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[16,11] { { 1, 2, 3 }, { 4, 5, 6 }, { 7,8,1,1,1,1,1,1,1,1,1 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
