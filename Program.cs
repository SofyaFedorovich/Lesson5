using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // среднее арифметическое массива из семи элементов
            int[] array = new int[7];
            int Summa = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Введите число массива: {0}", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
                Summa += array[i];
            }
            Console.Write("Среднее арифметическое членов массива: {0}", Summa / 7);
            Console.ReadKey();
        }

    }
}
