using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.IlyinME.Sprint5.Task4.V13.Lib;

namespace Tyuiu.IlyinME.Sprint5.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Ильин М. Е. | АСОиУБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Ильин Максим Евгеньевич | АСОиУБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V0.txt (файл взять из архива  *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:/DataSprint5 и       *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение.           *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле             *");
            Console.WriteLine("* y = cos(x) + x^2 / 2. Вычислить значение по формуле (Полученное         *");
            Console.WriteLine("* значение округлить до трёх знаков после запятой) и вернуть полученный   *");
            Console.WriteLine("* результат на консоль.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V13.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
