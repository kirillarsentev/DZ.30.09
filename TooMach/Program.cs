using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooMach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков.Задача1");
            Console.WriteLine("Введите число от 1 до 365");
            DateTime data = Convert.ToDateTime("01.01.2022");
            int num = Convert.ToInt32(Console.ReadLine());
            data = data.AddDays(num - 1);
            Console.WriteLine(data.ToString("Введенный день: d MMMM"));


            Console.WriteLine("Тумаков.Задача2");
            Console.WriteLine("Введите число от 1 до 365");
            DateTime data_1 = Convert.ToDateTime("01.01.2022");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            if (num_1 < 1 || num_1 > 365)
            {
                Console.WriteLine("Число находится вне диапазона");
            }
            else
            {
                data_1 = data_1.AddDays(num_1 - 1);
                Console.WriteLine(data_1.ToString("Введенный день: d MMMM"));

            }


            Console.WriteLine("Тумаков.Задача3");
            Console.WriteLine("Введите число от 1 до 365");
            DateTime data_2 = Convert.ToDateTime("01.01.2022");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            if (num_2 < 1 || num_2 > 365)
            {
                Console.WriteLine("Число находится вне диапазона");
            }
            else
            {
                data_2 = data_2.AddDays(num_2 - 1);
                Console.WriteLine(data_2.ToString("Введенный день: d MMMM"));

            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year + "год-високосный ");
            }
            else
            {
                Console.WriteLine(year + "год-не високосный ");
            }
            Console.WriteLine();

        }

    }
}
