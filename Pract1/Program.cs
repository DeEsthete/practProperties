using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапозон массива x, y");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            RangeOfArray array = new RangeOfArray(x, y);

            Console.WriteLine("Заполните массив");
            for (int i = x; i < y; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив");
            for (int i = x; i < y; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
