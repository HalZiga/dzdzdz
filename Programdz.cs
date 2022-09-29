using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddzzzzzzzzzzzzzzzzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Задание 1.Вывести число е ");
            double e = Math.E;
            Console.WriteLine("e={0:F1}",e);
            Console.ReadKey();


            Console.WriteLine("Задание 2.Вывестичисла 50 и 10 поl. ");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.ReadKey();


            Console.WriteLine("Задание 3.«столбиком» 4 любых чисел");
            Random rnd = new Random();//создаю рандом

            int value1 = rnd.Next();  //Получаю случайное число
            int value2 = rnd.Next(); 
            int value3 = rnd.Next(); 
            int value4 = rnd.Next();

            Console.WriteLine(value1);  
            Console.WriteLine(value2); 
            Console.WriteLine(value3); 
            Console.WriteLine(value4);
            Console.ReadKey();

            Console.WriteLine("Задание 4. Число + 10");
            Console.WriteLine("Введите число");
            double chis = double.Parse(Console.ReadLine());
            Console.WriteLine(chis + 10);

            Console.WriteLine("Задание 5. Перим квад");
            Console.WriteLine("Число давай");
            double chislo = double.Parse(Console.ReadLine());
            Console.WriteLine(chislo * 4);


            Console.WriteLine("Задание 6. окружность");
            Console.WriteLine("Введите радиус");
            double pi = Math.PI;
            double Radius = double.Parse(Console.ReadLine());
            double L = 2 * Radius * Math.PI;
            double S = Math.PI * Radius * Radius;
            Console.WriteLine($"Длинна окружности = {L},Площадь = {S}");


            Console.WriteLine("Задание 7. y=cos(x)");
            Console.WriteLine("Введите х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y= " + Math.Cos(x));


            Console.WriteLine("Задание 8. Трапеция");
            Console.WriteLine("Введите основания оснований");
            double osn1 = double.Parse(Console.ReadLine());
            double osn2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значения высоты трапеции");
            double visot = double.Parse(Console.ReadLine());
            double bokov = Math.Sqrt(((osn1 - osn2) * (osn1 - osn2)) + (visot * visot));
            Console.WriteLine(osn2 + osn1 + (2 * bokov));


            Console.WriteLine("Задание 9. Конфеты");
            int konfet = 100;
            int pechen = 80;
            int yablok = 90;
            Console.WriteLine("введите кг конфет");
            double konf = double.Parse(Console.ReadLine());
            Console.WriteLine("введите кг печенья");
            double pech = double.Parse(Console.ReadLine());
            Console.WriteLine("введите кг яблок");
            double yabl = double.Parse(Console.ReadLine());
            Console.WriteLine((konf * konfet) + (pech * pechen) + (yablok * yabl));


            Console.WriteLine("Задание 10. Мир Труд Май");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир" + "\n" + "    "  + "Труд" + "\n" + "         " + "Май");// н перескакивает строки пустата даёт место


            Console.WriteLine("Задание 11. сложное задание с перестановкой");
            Console.WriteLine("Введите 1 число:");
            string chislo1 = Console.ReadLine();
            Console.WriteLine("Введите 2 число:");
            string chislo2 = Console.ReadLine();
            chislo1 = chislo1.Replace(',', '.');
            chislo2 = chislo2.Replace(',', '.');


            Console.WriteLine("Задание 13. введите");
            Console.WriteLine("Введите число");
            double ch = double.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {ch}");


            Console.WriteLine("Задание 14.вывод инфы");
            Console.WriteLine("2 кг" + "\n" + "13 17");


            Console.WriteLine("Задание 15");
            Random rnd = new Random();//создаю рандом

            int value1 = rnd.Next();  //Получаю случайное число
            int value2 = rnd.Next();
            int value3 = rnd.Next();
            int value4 = rnd.Next();

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);


            с
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = ((b * b) - (4 * a * c));
            if (D>0)
            {
                double x1 = ((-1) * b - D) / (2 * a);
                double x2 = ((-1) * b + D) / (2 * a);
                Console.WriteLine($"Корни:{x1},{x2}");
            }
            if (D==0)
            {
                double x = ((-1) * b) / (2 * a);
                Console.WriteLine($"Корень:{x}");
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
            


            Console.WriteLine("Задание17. среднее");
            Console.WriteLine("Введите первое и второе число");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1}",(a + b) / 2, Math.Sqrt(a * b));


            Console.WriteLine("Задание18. растояние");
            Console.WriteLine("Введите Х1 потом У1");
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Х2 потом У2");
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2)));


            Console.WriteLine("Задание19.  программа обмена");
            Console.WriteLine("Введите a d c поочерёдно");
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("a) {0} {1} {2}", a, b, c);
            Console.WriteLine("б) {0} {1} {2}", b, c, a);*/


            Console.WriteLine("Задание20.  сек");
            Console.WriteLine("Введите число секунд");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine("Прошло часов" + sec / 3600);
            Console.WriteLine("Прошло минут" + (sec % 3600)/60);
            Console.WriteLine("Прошло секунд" + ((sec % 3600) % 60));


            Console.ReadKey();
        }
    }
}
