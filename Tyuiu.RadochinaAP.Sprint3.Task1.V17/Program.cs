using Tyuiu.RadochinaAP.Sprint3.Task1.V17.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                              *");
            Console.WriteLine("* Тема: Оператор цикла while                                                              *");
            Console.WriteLine("* Задание #1                                                                                             *");
            Console.WriteLine("* Вариант #17                                                                                            *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу используя цикл for,                                                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                                                         *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 4;

            Console.WriteLine("Переменная Х = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}