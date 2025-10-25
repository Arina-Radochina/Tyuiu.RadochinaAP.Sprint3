using Tyuiu.RadochinaAP.Sprint3.Task4.V27.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                              *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                                               *");
            Console.WriteLine("* Задание #4                                                                                             *");
            Console.WriteLine("* Вариант #27                                                                                        *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=x/(cos(x)+sin(x))        *");
            Console.WriteLine("* При х = 0 пропустить значение. Полученные значения суммировать.                                                                                   *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*********************************************Ы*************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("= " + startValue);
            Console.WriteLine("= " + stopValue);

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            
            Console.WriteLine("Результат = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();

        }
        

    }
}