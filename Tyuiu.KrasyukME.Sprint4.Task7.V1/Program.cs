using Tyuiu.KrasyukME.Sprint4.Task7.V1.Lib;
namespace Tyuiu.KrasyukME.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "135792468";
            Console.Title = "Спринт #4 | Выполнил: Красюк М. Е. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Строка: " + value);

            Console.WriteLine();
            Console.WriteLine("Матрица 3x3:");
            int[,] matrix = new int[3, 3];
            for (int i = 0, k = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++, k++)
                {
                    matrix[i, j] = int.Parse(value[k].ToString());
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество четных чисел: " + ds.Calculate(3, 3, value));

            Console.ReadKey();

        }
    }
}

