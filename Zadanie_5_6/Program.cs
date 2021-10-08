using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMagic = true;
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            // вывод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //проверка на магию
            int checkSumGor = 0;
            int checkSumVert = 0;
            int checkSumDiag1 = 0;
            int checkSumDiag2 = 0;
            int magicSum = 0;
            //суммы в строках
            for (int i = 0; i < n; i++)
            {
                checkSumGor = 0;
                checkSumVert = 0;
                for (int j = 0; j < n; j++)
                {
                    checkSumGor += array[i, j];
                    checkSumVert += array[j, i];
                    if (i==j)
                    {
                        checkSumDiag1 += array[i, j];
                    }
                    if (i==n-j-1)
                    {
                        checkSumDiag2 += array[i, j];
                    }
                }
                Console.WriteLine("Г: " +checkSumGor + "  В: "+checkSumVert);
                if (i==0)
                {
                    magicSum = checkSumGor;
                }
                if ((checkSumGor!=magicSum)||(checkSumVert!=magicSum))
                {
                    isMagic = false;
                }
            }
            if ((checkSumDiag1 != magicSum) || (checkSumDiag2 != magicSum))
            {
                isMagic = false;
            }
            Console.WriteLine("Д1: " + checkSumDiag1 + "  Д2: " + checkSumDiag2);
            Console.WriteLine();

            if (isMagic) Console.WriteLine("Поздравляю, это магический квадрат !!!");
            else Console.WriteLine("Увы, это вовсе не магический квадрат. (((");
            Console.ReadKey();
        }
    }
}
