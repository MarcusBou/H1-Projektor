using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            //et for loop til at fylde arrayet
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                //tilføjer værdier til arrayet
                arr[i] = i;
                arr[5] = arr[4] * 2;
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
