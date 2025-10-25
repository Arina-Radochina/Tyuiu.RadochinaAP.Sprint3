using Tyuiu.RadochinaAP.Sprint3.Task3.V11.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                              *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                             *");
            Console.WriteLine("* Задание #2                                                                                             *");
            Console.WriteLine("* Вариант #12                                                                                            *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Используя цикл foreach заменить буквы q на                                                                                *");
            Console.WriteLine("* цифру 7 в строке: sqwreq vqwqq q                                                                                     *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*********************************************Ы*************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Результат = " + ds.ReplaceCharOnNum(value, replaceable, replacement));
            Console.ReadKey();
        }
    }
}
