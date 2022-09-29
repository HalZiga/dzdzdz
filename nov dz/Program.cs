using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_dz
{
    struct User
    {
        public string name;
        public string town;
        public int age;
        public int pin;
        public User(int Age, string Name, string Town, int PIN)
        {
            name = Name;
            town = Town;
            age = Age;
            pin = PIN;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}, Город: {town}, Возраст: {age}, PIN: {pin}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Задание 2");
            Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}" + "\n" +
            $"byte: {byte.MinValue} ... {byte.MaxValue}" + "\n" +
            $"short: {short.MinValue} ... {short.MaxValue}" + "\n" +
            $"ushort: {ushort.MinValue} ... {ushort.MaxValue}" + "\n" +
            $"int: {int.MinValue} ... {int.MaxValue}" + "\n" +
            $"uint: {uint.MinValue} ... {uint.MaxValue}" + "\n" +
            $"long: {long.MinValue} ... {long.MaxValue}" + "\n" +
            $"ulong: {ulong.MinValue} ... {ulong.MaxValue}" + "\n" +
            $"char: U+000 ... U+ffff" + "\n" +
            $"float: {float.MinValue} ... {float.MaxValue}" + "\n" +
            $"double: {double.MinValue} ... {double.MaxValue}" + "\n" +
            "bool: true ... false" + "\n" +
            $"decimal: {decimal.MinValue} ... {decimal.MaxValue}" + "\n" +
            "string: Ограничено только системной памятью" + "\n" +
            "object: Практически всё, что угодно" + "\n");


            Console.WriteLine("Задание 4");
            string[] imafam = Console.ReadLine().Split(' ');
            Console.WriteLine($"{imafam[0][0].ToString().ToUpper()}.{imafam[1][0].ToString().ToUpper()}");


            Console.WriteLine("Task 3");
            User new_user = new User();
            Console.WriteLine("Введите имя");
            new_user.name = Console.ReadLine();
            Console.WriteLine("Введите город");
            new_user.town = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            new_user.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите PIN");
            new_user.pin = int.Parse(Console.ReadLine());
            new_user.Print();

            Console.WriteLine("Задсние 6");
            Console.WriteLine("Введите скорость в км/ч:");
            double S = double.Parse(Console.ReadLine().Replace(".", ","));
            int a;
            S = S / 3.6;
            a = (int)S;
            Console.WriteLine($"Скорость в м/с равна: {a}");*/


            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите слово");
            string slovo = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (char n in slovo.ToCharArray())
            {
                if (char.IsUpper(n))
                {
                    result.Append(char.ToLower(n));
                }
                else
                {
                    result.Append(char.ToUpper(n));
                }
            }
            Console.WriteLine(result);


            Console.WriteLine("Задание 5");
            Console.WriteLine("\nВведите стандартную цену:\t");
            double normPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите скидку DutyFree:\t");
            double salePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите сумму отпуска:\t");
            double holidayPrice = double.Parse(Console.ReadLine());
            double a = holidayPrice / salePrice;
            double b = a - (a%1) + 1;
            if ( a % 1 == 0)
            {
                Console.WriteLine($"Вам нужно купить {a} бутолок");
            }
            else
            {
                Console.WriteLine($"Вам нужно купить {b} бутолок");
            }


            Console.WriteLine("Задание 1");




            Console.ReadKey();
        }

    }
}
