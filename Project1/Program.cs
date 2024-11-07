using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Меню заданий:\n" +
                "1) Вычисление стоимости обоев для помещения.\n" +
                "2) Найти значение выражения.\n" +
                "3) Создание приглашения в театр.\n" +
                "4) Таблица пяти чисел.\n" +
                "5) Площадь треугольника по его сторонам.\n" +
                "6) Является ли семизначное число палиндромом?\n" +
                "7) В какой четверти точка?\n" +
                "8) Всевозможные комбинации трёхзначного числа.\n" +
                "9) Определение названия месяца, времени года и дней, оставшихся до конца месяца, на основе введённой даты.\n" +
                "10) Вывод оценки студента.\n" +
                "11) Имя и возраст мужчин.\n");
            Console.Write("Выберите задание: ");
            short task = Convert.ToInt16(Console.ReadLine());
            if (task < 1 || task > 11)
            {
                Console.WriteLine("\nНекорректный ввод!");
            }
            switch (task)
            {
                case 1:
                    {
                        Console.Write("\nВведите длину помещения в метрах: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите ширину помещения в метрах: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите высоту помещения в метрах: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите стоимость рулона обоев за квадратный метр: ");
                        double wallpaper = Convert.ToDouble(Console.ReadLine());
                        if (length <= 0 || width <= 0 || height <= 0 || wallpaper < 0)
                        {
                            Console.WriteLine("\nНекорректный ввод!");
                            break;
                        }
                        double cost = wallpaper * (length * width + length * height * 2 + width * height * 2);
                        Console.WriteLine("Стоимость обоев = " + cost);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nВведите x, y и z: ");
                        Console.Write("x = ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("y = ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        Console.Write("z = ");
                        double z = Convert.ToDouble(Console.ReadLine());
                        if (-7 * Math.Pow(x, 2) * Math.Pow(y, 8) + z * y == 0)
                        {
                            Console.WriteLine("Переменные не входят в область допустимых значений.");
                            break;
                        }
                        double result = ((x * x - Math.Sqrt(Math.Pow(z, 9) + 8 * x * y))
                            / Math.Abs(-7 * x * x * Math.Pow(y, 8) + z * y)) + 3;
                        Console.WriteLine("Значение выражения = " + Math.Round(result, 5));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nСоздание приглашения в театр: ");
                        Console.Write("Введите название театра: ");
                        string theatre = Console.ReadLine();
                        Console.Write("Введите название спектакля: ");
                        string play = Console.ReadLine();
                        Console.Write("Введите время представления: ");
                        string time = Console.ReadLine();
                        Console.Write("Введите стоимость билета: ");
                        string ticket = Console.ReadLine();
                        Console.WriteLine("Приглашаем в наш театр \"{0}\", название спектакля \"{1}\"," +
                            "время представления: {3}, цена билета: {4}", theatre, play, time, ticket);
                        break;
                    }
                case 4:
                    {
                        Console.Write("\nВведите первое целое число: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите второе целое число: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите третье целое число: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите четвёртое целое число: ");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите пятое целое число: ");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nВведённые числа:          " + num1 + "           " + num2 + "           " + num3 + "           " + num4 + "           " + num5);
                        Console.WriteLine("Модуль:                   " + Math.Abs(num1) + "           " + Math.Abs(num2) + "           " + Math.Abs(num3) + "           " + Math.Abs(num4) + "           " + Math.Abs(num5));
                        Console.WriteLine("Квадратный корень:        " + Math.Round(Math.Sqrt(Convert.ToDouble(num1)), 2) + "         " + Math.Round(Math.Sqrt(Convert.ToDouble(num2)), 2) + "         " + Math.Round(Math.Sqrt(Convert.ToDouble(num3)), 2) + "         " + Math.Round(Math.Sqrt(Convert.ToDouble(num4)), 2) + "         " + Math.Round(Math.Sqrt(Convert.ToDouble(num5)), 2));
                        Console.WriteLine("Значение в пятой степени: " + Math.Pow(num1, 5) + "     " + Math.Pow(num2, 5) + "     " + Math.Pow(num3, 5) + "     " + Math.Pow(num4, 5) + "     " + Math.Pow(num5, 5));
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("\nВведите стороны a, b, c треугольника:");
                        Console.Write("a = ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b = ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("c = ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        if (a + b < c || a + c < b || b + c < a)
                        {
                            Console.WriteLine("\nТакого треугольника быть не может!");
                            break;
                        }
                        double p = (a + b + c) / 2;
                        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine("\nПлощадь треугольника со сторонами " + a + ", " + b + " и " + c + " равна " + area + ".");
                        break;
                    }
                case 6:
                    {
                        Console.Write("\nВведите семизначное число: ");

                        //string palindrome = Console.ReadLine();
                        //if (palindrome.Length != 7)
                        //{
                        //    Console.WriteLine("\nЧисло не семизначное!");
                        //    break;
                        //}
                        //char[] array = palindrome.ToCharArray();

                        ulong palindrome = Convert.ToUInt64(Console.ReadLine());
                        if (palindrome / 1000000 < 1 || palindrome / 1000000 > 9)
                        {
                            Console.WriteLine("\nЧисло не семизначное!");
                            break;
                        }
                        ulong[] array = new ulong[7];
                        array[0] = palindrome / 1000000;
                        array[1] = palindrome % 1000000 / 100000;
                        array[2] = palindrome % 100000 / 10000;
                        array[3] = palindrome % 10000 / 1000;
                        array[4] = palindrome % 1000 / 100;
                        array[5] = palindrome % 100 / 10;
                        array[6] = palindrome % 10;

                        if (array[0] == array[6] && array[1] == array[5] && array[2] == array[4]) Console.WriteLine("\nЭто палиндром!!!");
                        else Console.WriteLine("\nЭто не палиндром...");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("\nВведите координаты x и y точки:");
                        Console.Write("x = ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("y = ");
                        double y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        if (x != 0 || y != 0)
                        {
                            if (x == 0)
                            {
                                Console.WriteLine("Точка находится на оси y.");
                                break;
                            }
                            if (y == 0)
                            {
                                Console.WriteLine("Точка находится на оси x.");
                                break;
                            }
                            if (x > 0)
                            {
                                if (y > 0)
                                {
                                    Console.WriteLine("Точка находится на первой четверти.");
                                    break;
                                }
                                Console.WriteLine("Точка находится на четвёртой четверти.");
                                break;
                            }
                            if (y > 0)
                            {
                                Console.WriteLine("Точка находится на второй четверти.");
                                break;
                            }
                            Console.WriteLine("Точка находится на третьей четверти.");
                            break;
                        }
                        Console.WriteLine("Точка является началом координат.");
                        break;
                    }
                case 8:
                    {
                        Console.Write("\nВведите трёхзначное число: ");
                        int threeDigit = Convert.ToInt32(Console.ReadLine());
                        if (threeDigit > 999 || threeDigit < 100)
                        {
                            Console.WriteLine("Число не трёхзначное.");
                            break;
                        }
                        char[] array = Convert.ToString(threeDigit).ToCharArray();
                        Console.WriteLine("Все комбинации трёхзначного числа: ");
                        Console.WriteLine(array[0] + array[1] + array[2]);
                        Console.WriteLine(array[0] + array[2] + array[1]);
                        Console.WriteLine(array[1] + array[0] + array[2]);
                        Console.WriteLine(array[1] + array[2] + array[0]);
                        Console.WriteLine(array[2] + array[0] + array[1]);
                        Console.WriteLine(array[2] + array[1] + array[0]);
                        break;
                    }
                case 9:
                    {
                        Console.Write("\nВведите дату в формате ДД.ММ.ГГГГ: ");
                        char[] dateArr = Console.ReadLine().ToCharArray();
                        if (dateArr.Length != 10 || dateArr[2] != '.' || dateArr[5] != '.' ||
                            Convert.ToUInt16(string.Concat(dateArr[0], dateArr[1])) > 31 ||
                            Convert.ToUInt16(string.Concat(dateArr[3], dateArr[4])) > 12 ||
                            Convert.ToUInt16(string.Concat(dateArr[0], dateArr[1])) <= 0 ||
                            Convert.ToUInt16(string.Concat(dateArr[3], dateArr[4])) <= 0)
                        {
                            Console.WriteLine("Некорректный ввод!");
                            break;
                        }
                        ushort year = Convert.ToUInt16(string.Concat(dateArr[6], dateArr[7], dateArr[8], dateArr[9]));
                        byte leap;
                        if (year % 400 == 0) leap = 1;
                        else
                        {
                            if (year % 100 == 0) leap = 0;
                            else
                            {
                                if (year % 4 == 0) leap = 1;
                                else leap = 0;
                            }
                        }
                        ushort day = Convert.ToUInt16(string.Concat(dateArr[0], dateArr[1]));
                        ushort month = Convert.ToUInt16(string.Concat(dateArr[3], dateArr[4]));
                        switch (month)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Месяц: январь.\nВремя года: зима.\nДней осталось до конца месяца: " + (31 - day));
                                    break;
                                }
                            case 2:
                                {
                                    if ((leap == 0 && day >= 29) || (leap == 1 && day >= 30))
                                    {
                                        Console.WriteLine("Некорректный ввод!");
                                        break;
                                    }
                                    Console.WriteLine("Месяц: февраль.\nВремя года: зима.\nДней осталось до конца месяца: " + (28 + leap - day));
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Месяц: март.\nВремя года: весна.\nДней осталось до конца месяца: " + (31 - day));
                                    break;
                                }
                            case 4:
                                {
                                    if (day >= 31)
                                    {
                                        Console.WriteLine("Некорректный ввод!");
                                        break;
                                    }
                                    Console.WriteLine("Месяц: апрель.\nВремя года: весна.\nДней осталось до конца месяца: " + (30 - day));
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Месяц: май.\nВремя года: весна.\nДней осталось до конца месяца: " + (31 - day));
                                    break;
                                }
                            case 6:
                                {
                                    if (day >= 31)
                                    {
                                        Console.WriteLine("Некорректный ввод!");
                                        break;
                                    }
                                    Console.WriteLine("Месяц: июнь.\nВремя года: лето.\nДней осталось до конца месяца: " + (30 - day));
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine("Месяц: июль.\nВремя года: лето.\nДней осталось до конца месяца: " + (31 - day));
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine("Месяц: август.\nВремя года: лето.\nДней осталось до конца месяца: " + (31 - day));
                                    break;
                                }
                            case 9:
                                {
                                    if (day >= 31)
                                    {
                                        Console.WriteLine("Некорректный ввод!");
                                        break;
                                    }
                                    Console.WriteLine("Месяц: сентябрь.\nВремя года: осень.\nДней осталось до конца месяца: " + (30 - day));
                                    break;
                                }
                            case 10:
                                {
                                    Console.WriteLine("Месяц: октябрь.\nВремя года: осень.\nДней осталось до конца месяца: " + (31 - day));
                                    break;
                                }
                            case 11:
                                {
                                    if (day >= 31)
                                    {
                                        Console.WriteLine("Некорректный ввод!");
                                        break;
                                    }
                                    Console.WriteLine("Месяц: ноябрь.\nВремя года: осень.\nДней осталось до конца месяца: " + (30 - day));
                                    break;
                                }
                            case 12:
                                {
                                    Console.WriteLine("Месяц: декабрь.\nВремя года: зима.\nДней осталось до конца месяца: " + (31 - day));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Произошла непредвиденная неизвестная ошибка.");
                                    break;
                                }
                        }
                        break;
                    }
                case 10:
                    {
                        Console.Write("\nВведите оценку студента от нуля до пяти баллов: ");
                        ushort grade = Convert.ToUInt16(Console.ReadLine());
                        switch (grade)
                        {
                            case 5:
                                {
                                    Console.WriteLine("Студент получил оценку \"отлично\"!");
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Студент получил оценку \"хорошо\"!");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Студент получил оценку \"удовлетворительно\"!");
                                    break;
                                }
                            case 2:     // в C# 9.0 и в более поздних версиях можно писать "case 2 or 1 or 0:" ! ! !
                            case 1:
                            case 0:
                                {
                                    Console.WriteLine("Студент получил оценку \"неудовлетворительно\"!");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Некорректный ввод!");
                                    break;
                                }
                        }
                        break;
                    }
                case 11:
                    {

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.Write("\nНажмите любую клавишу для продолжения: ");
            Console.ReadKey();
            Console.WriteLine("\n");
            goto start;
        }
    }
}
