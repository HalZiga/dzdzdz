using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ddzzzzzzzzzzzzzzzzz
{
    internal class Programdz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.Вывести число е ");
            double e = Math.E;
            Console.WriteLine("e={0:F1}",e);
            Console.ReadKey();


            Console.WriteLine("Задание 2.Вывестичисла 50 и 10 поl. ");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.ReadKey();


            Console.WriteLine("Задание 3.«столбиком» 4 любых чисел");

            Random rnd = new Random();
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

            value1 = rnd.Next();  //Получаю случайное число
            value2 = rnd.Next();
            value3 = rnd.Next();
            value4 = rnd.Next();

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);


            
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
                x = ((-1) * b) / (2 * a);
                Console.WriteLine($"Корень:{x}");
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
            


            Console.WriteLine("Задание17. среднее");
            Console.WriteLine("Введите первое и второе число");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
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
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("a) {0} {1} {2}", a, b, c);
            Console.WriteLine("б) {0} {1} {2}", b, c, a);


            Console.WriteLine("Задание20.  сек");
            Console.WriteLine("Введите число секунд");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine("Прошло часов" + sec / 3600);
            Console.WriteLine("Прошло минут" + (sec % 3600)/60);
            Console.WriteLine("Прошло секунд" + ((sec % 3600) % 60));


            Console.WriteLine("задание 21. квадрат");
            Console.WriteLine("Можно вырезать {0} квадратa", 543 / 130);


            Console.WriteLine("Задание. 22 трёхчисл");
            Console.WriteLine("введите трёхзначное число");
            int treh = int.Parse(Console.ReadLine());
            Console.WriteLine($"{treh % 10}" + $"{treh / 10}");


            Console.WriteLine("Задание 23. число > 999");
            Console.WriteLine("Введите число больше 999");
            treh = int.Parse(Console.ReadLine());
            Console.WriteLine($"a){treh / 100},b){treh / 1000}");


            Console.WriteLine("Задание 24. Четырёхзначное");
            int[] myarray = new int[4];
            for(int i = 0; i < myarray.Length;i++)
            {
                Console.Write($"\nВведите число {i}:\t");
                myarray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("a)" + myarray[3] + myarray[2] + myarray[1] + myarray[0]);
            Console.WriteLine("б)" + myarray[1] + myarray[0] + myarray[3] + myarray[2]);
            Console.WriteLine("в)" + myarray[0] + myarray[2] + myarray[1] + myarray[3]);
            Console.WriteLine("г)" + myarray[2] + myarray[3] + myarray[0] + myarray[1]);


            Console.WriteLine("Задание 25. трёхзнач с последней цифрой");
            Console.WriteLine("введите число");
            string inpt3 = Console.ReadLine();
            if ((int.Parse(inpt3) / 10) % 10 == 0)
            {
                Console.WriteLine("введите другое число");
            }
            else
            {
                Console.WriteLine("x = " + inpt3[1] + inpt3[2] + inpt3[0]);
            }


            Console.WriteLine("Задание 26. Стрелки часов");
            Console.WriteLine("\nВведите количество часов:\t");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите количество минут:\t");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите количество секунд:\t");
            int s = int.Parse(Console.ReadLine());
            if (h > 11)
            {
                h = h - 12;
            }
            Console.WriteLine("угол = " + (h*30 + m*0.5));


            Console.WriteLine("Задание 27. угол");
            Console.WriteLine("Введите угол");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение угла {0}, количество часов{1}, количество минут{2}",(a%30)*12, a/30, (a % 30) * 2);
            


            Console.WriteLine("Задание 28. меньший");
            Console.WriteLine("Введите 3 числа");
            int[] myarray1 = new int[3];
            for (int i = 0; i < myarray1.Length; i++)
            {
                myarray1[i] = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Минимальное число" + myarray1.Min());


            Console.WriteLine("Задание 29. макс и мин");
            Console.WriteLine("Введите 3 числа");
            int[] myarray2 = new int[3];
            for (int i = 0; i < myarray2.Length; i++)
            {
                myarray2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(myarray2.Max() + myarray2.Min());


            Console.WriteLine("Задание 30. количество делителей натурального числа");
            Console.WriteLine("Введите число");
            int int1 = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 1; i <= int1; i++)
            {
                if (int1 % i == 0)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);


            Console.WriteLine("задание 31. кубич");
            Console.WriteLine("введите коэффициенты уравнения (a,b,c,d)");
            int[] coef = Console.ReadLine().Split(' ').Select(l => int.Parse(l)).ToArray();
            for (int otr = -100; otr <= 100; otr++)
            {
                double result = coef[0] * Math.Pow(otr, 3) + coef[1] * Math.Pow(otr, 2) + coef[2] * otr + coef[3];
                if (result == 0)
                {
                    Console.WriteLine("X = " + otr);
                }
            }
           



            Console.WriteLine("задание 32. Арифмитическая прогрессия");
            Console.WriteLine("Введите первый элэмент арифметической прогрессии");
            double arif1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элэмент орифметической прогрессии");
            double arif2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер нужного элемента последовательности");
            double arif3 = double.Parse(Console.ReadLine());
            double nuzelem = (arif1 + (arif2 - arif1) * (arif3 - 1));
            Console.WriteLine($"{arif3} элэмент последовательности = {nuzelem}"); 


            Console.WriteLine("задание 33. кредит");
            Console.WriteLine("Являетесь ли вы пенсионером? (1 - да / 0 - нет)");
            int pens = int.Parse(Console.ReadLine());
            Console.WriteLine("Являетесь ли вы студентом? (1 - да / 0 - нет)");
            int student = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы тродоустроены? (1 - да / 0 - нет)");
            int trud = int.Parse(Console.ReadLine());
            if (((pens == 1 && trud == 0) || (student == 1 && trud == 0)) && (pens == 0 || student == 0))
            {
                Console.WriteLine("Поздравляю вам одобрен кредит)");
            }
            else
            {
                Console.WriteLine("Кредит не одобрен =)");
            }
            


            Console.WriteLine("задание34");
            Console.WriteLine("Введите имя:\t");
            string ima = Console.ReadLine();
            Console.WriteLine($"a){ima}\nб)Здарова {ima}");


            Console.WriteLine("задание35");
            Console.WriteLine("Введите имя:\t");
            string ima1 = Console.ReadLine();
            Console.WriteLine($"Привет, {ima1}");
            Console.WriteLine("Задай вопрос: Знаешь ли ты что-то о секретной комнате");
            ima1 = Console.ReadLine();
            Console.WriteLine("Да");
            Console.WriteLine("Задай вопрос: Можешь ли рассказать");
            ima1 = Console.ReadLine();
            Console.WriteLine("Нет");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green; 




            Console.WriteLine("задание36");
            int[] myarray5 = new int[24];
            int valu1 = rnd.Next(0, 9);
            int valu2 = rnd.Next(0, 9);
            int valu3 = rnd.Next(0, 9);
            int valu4 = rnd.Next(0, 9);
            int valu5 = rnd.Next(0, 9);
            int valu6 = rnd.Next(0, 9);
            int valu7 = rnd.Next(0, 9);
            int valu8 = rnd.Next(0, 9);
            int valu9 = rnd.Next(0, 9);
            int valu10 = rnd.Next(0, 9);
            int valu11 = rnd.Next(0, 9);
            int valu12 = rnd.Next(0, 9);
            myarray5[0] = valu1;
            myarray5[1] = valu2;
            myarray5[2] = valu3;
            myarray5[3] = valu4;
            myarray5[4] = valu5;
            myarray5[5] = valu6;
            myarray5[6] = valu7;
            myarray5[7] = valu8;
            myarray5[8] = valu9;
            myarray5[9] = valu10;
            myarray5[10] = valu11;
            myarray5[11] = valu12;
            for (int i = 12; i < 24;i++)
            {
                Console.Write($"Введите число {i}:\t");
                myarray5[i] = int.Parse(Console.ReadLine());
            }
            int Summachet = myarray5[23] + myarray5[21] + myarray5[19] + myarray5[17] + myarray5[15] + myarray5[13] + myarray5[11] + myarray5[9] + myarray5[7] + myarray5[5] + myarray5[3] + myarray5[1];
            int Summanechet = myarray5[22] + myarray5[20] + myarray5[18] + myarray5[16] + myarray5[14] + myarray5[12] + myarray5[10] + myarray5[8] + myarray5[6] + myarray5[4] + myarray5[2] + myarray5[0];
            int dis = 3*Summanechet + Summachet;
            int ostat = dis % 10;
            if (ostat == 0)
            {
                int kontr = 0;
                Console.WriteLine("Контрольная сумма = "+kontr);
            }
            else
            {
                int kontr = 10 - ostat;
                Console.WriteLine("Контрольная сумма = " + kontr);
            }
            
            Console.ReadKey();
        }
    }
}
