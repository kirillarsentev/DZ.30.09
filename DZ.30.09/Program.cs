using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ._30._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ДЗ. Задача1");
            Console.WriteLine("Введи размеры окна");
            int size_a = Convert.ToInt32(Console.ReadLine());
            int size_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер головы");
            int size_d = Convert.ToInt32(Console.ReadLine());
            if (size_d + 1 < size_a & size_d + 1 < size_b)
            {
                Console.WriteLine("Голова пролезет в форточку");
            }
            else
            {
                Console.WriteLine("Голова не пролезет в форточку");
            }



            Console.WriteLine("ДЗ.Задача2");
            Console.WriteLine("Введите число 1 < n < 10 ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            while (num < 9)
            {
                Console.WriteLine(n * num);
                num++;
            }
            Console.WriteLine("ДЗ.Задача3");
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.Read());

            if (number % 3 == 0 & number % 5 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Бум");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Бэнг");
            }
            else
            {
                Console.WriteLine("Мимо");
            }


            Console.WriteLine("ДЗ.Задача4");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (str == str.ToUpper())
            {
                Console.WriteLine("Все букву строки заглавные");
            }
            else
            {
                Console.WriteLine("Не все буквы строки заглавные");
            }



            Console.WriteLine("ДЗ.Задача5");
            Console.WriteLine("Введите число");
            int numbers = Convert.ToInt32(Console.ReadLine());
            string sheep = "овца...";
            int m = 1;
            string str_1 = "";
            while (m <= numbers)
            {
                str_1 = m + sheep;
                Console.Write(str_1);
                m++;
            }

            Console.WriteLine("ДЗ.Задача6");
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, -9 };
            int c = 0;
            double summ = 0;
            try
            {
                for (int j = 0; j < ints.Length - 1; j++)
                {
                    summ += ints[j];
                    c++;
                }
                Console.WriteLine(summ / (ints.Length - 1));

            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");

                throw;
            }
            finally
            {
                Console.WriteLine("Программа завершилась успешно");
            }



            Console.WriteLine("ДЗ.Задача7");
            Console.WriteLine("Введите число от 6 до 14");
            int l = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (l)
                {
                    case 6: Console.WriteLine("шестёрка"); break;
                    case 7: Console.WriteLine("семёрка"); break;
                    case 8: Console.WriteLine("восьмёрка"); break;
                    case 9: Console.WriteLine("девятка"); break;
                    case 10: Console.WriteLine("десятка"); break;
                    case 11: Console.WriteLine("валет"); break;
                    case 12: Console.WriteLine("дама"); break;
                    case 13: Console.WriteLine("король"); break;
                    case 14: Console.WriteLine("туз"); break;
                }


            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");

                throw;
            }
            finally
            {
                Console.WriteLine("Программа завершилась");

            }


            Console.WriteLine("ДЗ.Задача 8");
            string[] strs = { "jknvvm", "jgjnjn", "Hello Kitty", "jngnt", "Barbie doll" };
            int bag = 0;
            foreach (string s in strs)
            {
                if (s == "Hello Kitty" || s == "Barbie doll")
                {
                    bag++;
                }
            }
            Console.WriteLine(bag);


            Console.WriteLine("ДЗ.Задача9");
            Console.WriteLine("Введите число от 1 до 7");
            int p = Convert.ToInt32(Console.ReadLine());
            days day = (days)Enum.GetValues(typeof(days)).GetValue(p-1);
            Console.WriteLine(day);



            Console.WriteLine("ДЗ.Задача10");
            Console.WriteLine("Введите элементы массива");
            int[] arr = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }



            Console.WriteLine("ДЗ.Задача11");
            Console.WriteLine("Введите элементы массива");
            int[] massiv = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int el = 0;
            while (massiv[el] < massiv[el + 1] & el <= 9)
            {
                el++;
            }

            if (el == 9)
            {
                Console.WriteLine("Массив упорядочен");
            }
            else {
                el+=2;
                Console.WriteLine("Массив не упорядочен massiv["+ el +"]");
            }

            
            
            


        }
        enum days
        {
            понедельник=1,
            вторник = 2,
            среда = 3,
            четверг = 4,
            пятница = 5,
            суббота = 6,
            воскресенье = 7
        }

    }
}
