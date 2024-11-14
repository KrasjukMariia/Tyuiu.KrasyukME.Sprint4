using Tyuiu.KrasyukME.Sprint4.Task0.V25.Lib;
namespace Tyuiu.KrasyukME.Sprint4.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Красюк М. Е. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма четных элементов = " + ds.GetSumEvenArrEl(array));
            Console.ReadKey();
        }
    }
}
