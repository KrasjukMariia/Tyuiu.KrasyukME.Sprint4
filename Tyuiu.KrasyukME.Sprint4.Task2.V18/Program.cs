using Tyuiu.KrasyukME.Sprint4.Task2.V18.Lib;
namespace Tyuiu.KrasyukME.Sprint4.Task2.V18
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
            Random rnd = new Random();
            int len;

            Console.WriteLine("Введите число элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(2, 9);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение четных элементов массива = {ds.Calculate(numsArray)}");
            Console.ReadKey();
        }
    }
}
