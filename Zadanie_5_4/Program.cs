using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int count = 0;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.WriteLine(i+ " " + array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n; i+=2)
            {
                if ((array[i]>0)&&(array[i]%2==1))
                {
                    Console.WriteLine(i + " " + array[i]);
                    count++;
                }  
            }
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах: {0}",count);
            Console.ReadKey();
        }
    }
}
