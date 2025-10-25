using Tyuiu.RadochinaAP.Sprint3.Task6.V8.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                                      *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                                                                       *");
            Console.WriteLine("* Задание #6                                                                                                                     *");
            Console.WriteLine("* Вариант #8                                                                                                                     *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                                                 *");
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [18, 28] сумму всех делителей больше 11    *");
            Console.WriteLine("*                                                                                                                                *");
            Console.WriteLine("*********************************************Ы************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            int startValue = 18;
            int stopValue = 28;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
