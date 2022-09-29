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
            Console.WriteLine("Задача 2.1 Написать программу, которая спрашивает имя  пользователя, и затем приветствует пользователя по имени.");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Приветствую тебя {name}");
            Console.ReadKey();

            Console.WriteLine("Упражнение 2.2 деление 2 чисел");

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


            Console.WriteLine("Задание 2.1 Прочитать букву с экрана и вывести на печать  следующую за ней букву в алфавитном порядке.");
            Console.WriteLine("Введите 1 букву");
            string input = Console.ReadLine();
            input = input.ToLower(); // делаем букву маленькой
            if (input == "z")
            {
                Console.WriteLine("Следуюущая буква - а");
            }
            else
            {
                int value = char.Parse(input); //получаем код буквы в юникоде
                Console.WriteLine("Седуюущая буква - " + (char)(value + 1));
                


                Console.WriteLine("Задание 2.2");
                Console.WriteLine("Введите коэффиценты a,b,c");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double diskr = Math.Pow(b, 2) - 4 * a * c;
                if (diskr > 0)
                {
                    double x1 = (b * (-1) + Math.Sqrt(diskr)) / 2 * a;
                    double x2 = (b * (-1) - Math.Sqrt(diskr)) / 2 * a;
                    Console.WriteLine("{0}, {1}", x1, x2);
                }
                if (diskr == 0)
                {
                    double x1 = (b * (-1)) / 2 * a;
                    Console.WriteLine(x1);
                }
                else
                {
                    Console.WriteLine("нет вещественных корней");
                }
                Console.ReadKey();
            }
        }
    }
}
