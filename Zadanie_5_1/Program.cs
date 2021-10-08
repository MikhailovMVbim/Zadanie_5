using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите {0} элемент массива:  ",i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            float sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            Console.WriteLine("Среднее арифметическое: {0:f2}",sum/n);
            Console.ReadKey();
        }
    }
}
