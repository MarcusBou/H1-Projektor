using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrTal = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < arrTal.Length; i++)
            {
                int randomNumb = rnd.Next(0,500);
                arrTal[i] = randomNumb;
                for (int j = 0; j < arrTal.Length - 1; j++)
                {
                    if (arrTal[j] > arrTal[j+1])
                    {
                        int temp = arrTal[j + 1];
                        arrTal[j + 1] = arrTal[j];
                        arrTal[j] = temp;
                    }
                }
      
                Console.WriteLine(arrTal[i]);
            }
            Console.ReadKey();
        }
    }
}
