using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Задача 2.1 Написать программу, которая спрашивает имя  пользователя, и затем приветствует пользователя по имени.")
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Приветствую тебя {name}");
            Console.ReadKey();*/

            /*Console.WriteLine("Упражнение 2.2 деление 2 чисел");

            Console.WriteLine("Введите первое чило");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());

            if (b == 0)
                Console.Write("Деление на 0 невозможно, начните заново");
            else
            {
                double delenie = a / b;
                Console.WriteLine($"Деление={delenie}");
            }
            
            Console.ReadKey();*/

            Console.WriteLine("Задание 2.1 Прочитать букву с экрана и вывести на печать  следующую за ней букву в алфавитном порядке.");
            Console.WriteLine("Введите 1 букву");
            int bukva = Console.ReadLine();
            int novbuk = ++bukva ;

        }
    }
}
