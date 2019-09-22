using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborotornya_rabota1
{
    class Program
    { 
        static void change_color(int i)
        {
            if (i == 1)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (i == 2)
                Console.ForegroundColor = ConsoleColor.Green;
        }
        static void no_korny()
        {
            change_color(1);
            Console.WriteLine("Корней нет");
        }

        

        static void input(ref double a, ref double b, ref double c)
        {
            try
            {
                Console.Write("Введите коэфицент a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите коэфицент b:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите коэфицент c:");
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Введены некоректные данные");
                input(ref a, ref b, ref c);
            }
            if (a == 0)
            {
                Console.WriteLine("Параметр a должен быть не равен 0!!!!");
                input(ref a, ref b, ref c);
            }
        }
       
        static int Main(string[] args)
        {
            double a;
            double b;
            double c;
            double x1;
            double x2;
            double x3;
            double x4;

            

       
            a = 0;
            b = 0;
            c = 0;
            Console.Title = ("Зудин Алексей Максимович ИУ5-33Б");
            if (args.Length == 3)
            {
                try
                {
                    a = Convert.ToDouble(args[0]);
                    b = Convert.ToDouble(args[1]);
                    c = Convert.ToDouble(args[2]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Введены неверные параметры командной строки");
                    return (0);
                }
                if (a == 0)
                {
                    Console.WriteLine("Параметр командной строки 'a' должен быть не равен 0!!!!");
                    return (0);
                }

            }
            else
            {
                input(ref a, ref b, ref c);
            }
            if (b != 0 && c != 0)
            {
                if (b * b - 4 * a * c < 0)
                {
                    ////////////
                    no_korny();
                    return (0);
                }
                else
                {
                    if (b * b - 4 * a * c == 0)
                    {
                        if (-b / (2 * a) < 0)
                        {
                            x1 = Math.Sqrt(-b / (2 * a)*-1);
                            x2 = -Math.Sqrt(-b / (2 * a) * -1);
                            //мнимые корни
                            change_color(2);
                            Console.WriteLine("x1 = {0}i x2 = {1}i", x1, x2);
                            return (0);
                        }
                        else
                        {
                           x1 = Math.Sqrt(-b / (2 * a));
                           x2 = -Math.Sqrt(-b / (2 * a));
                            Console.WriteLine("{0},{1}", x1, x2);
                            return (0);
                        }
                    }
                    else
                    {
                        if ((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a) < 0)
                        {
                            x1 = Math.Sqrt((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a)*-1);
                            x2 = -Math.Sqrt((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a)*-1);
                            //мнимые корни
                            change_color(2);
                            Console.Write("x1 = {0}i x2 = {1}i ", x1, x2);
                           
                        }
                        else
                        {
                            x1 = Math.Sqrt((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                            x2 = -Math.Sqrt((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                            change_color(2);
                            Console.Write("x1 = {0} x2 = {1} ", x1, x2);
                        }
                        if ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a) < 0)
                        {
                            x3 = Math.Sqrt((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a)*-1);
                            x4 = -Math.Sqrt((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a)*-1);
                            //мнимые корни
                            change_color(2);
                            Console.WriteLine("x3 = {0}i x4 = {1}i", x3, x4);
                           
                        }
                        else
                        {
                            x3 = Math.Sqrt((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                            x4 = -Math.Sqrt((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                            change_color(2);
                            Console.WriteLine("x3 = {0} x4 = {1}", x3, x4);
                        }
                        return (0);
                    }
                }
            }
            else
            {
                if (b != 0 && c == 0)
                {
                    if (b > 0)
                    {
                        x1 = Math.Sqrt(b / a);
                        change_color(2);
                        Console.WriteLine("x1 = 0 x2 = {0}i x3 = -{1}i", x1, x1);
                    }
                    else
                    {
                        x1 = Math.Sqrt(-b / a);
                        change_color(2);
                        Console.WriteLine("x1 = 0 x2 = {0} x3 = -{1}", x1, x1);
                    }
                }
                else
                {
                    if (b == 0 && c != 0)
                    {
                        if (c > 0)
                        {
                            x1 = Math.Sqrt(c / a * -1);
                            change_color(2);
                            Console.WriteLine("x1 = {0}i x2 = -{1}i", x1, x1);
                        }
                        else
                        {
                            x1 = Math.Sqrt(-c / a);
                            change_color(2);
                            Console.WriteLine("x1 = {0} x2 = -{1}", x1, x1);
                        }
                    }
                    else
                    {
                        change_color(2);
                        Console.WriteLine("Единственное решение x = 0 ");
                    }
                }

            }
            return (0);
        }
    }
}