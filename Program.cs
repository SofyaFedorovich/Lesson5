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
            int Sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите число {0}:", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое введенных чисел: {0}", Sum / 7);
            Console.ReadKey();
        }

    }
}
