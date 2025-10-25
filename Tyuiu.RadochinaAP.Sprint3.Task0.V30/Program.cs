using Tyuiu.RadochinaAP.Sprint3.Task0.V30.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                              *");
            Console.WriteLine("* Тема: Добавление к итоговому проектов по спринту                                                       *");
            Console.WriteLine("* Задание #0                                                                                             *");
            Console.WriteLine("* Вариант #30                                                                                            *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу используя цикл for,                                                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                                                         *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Сумма ряда =  " + ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}