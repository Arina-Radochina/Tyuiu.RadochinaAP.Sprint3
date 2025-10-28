using Tyuiu.RadochinaAP.Sprint3.Task7.V9.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                                      *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                                                      *");
            Console.WriteLine("* Задание #7                                                                                                                     *");
            Console.WriteLine("* Вариант #9                                                                                                                     *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функций                                                                   *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("*********************************************Ы************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("*******************************************************************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1, 7:f2}   |", startValue + i, valueArray[i]);
            }

            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
