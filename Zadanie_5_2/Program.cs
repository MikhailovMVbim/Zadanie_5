using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
            }
            int max = array[0];
            int min = array[0];
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("Минимальное число в массиве: {0}",min);
            Console.WriteLine("Максимальное число в массиве: {0}", max);
            Console.WriteLine("Сумма максимального и минимального элементов массива: {0}", min+max);
            Console.ReadKey();
        }
    }
}
