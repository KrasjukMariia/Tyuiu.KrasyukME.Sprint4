using Tyuiu.KrasyukME.Sprint4.Task7.V1.Lib;
namespace Tyuiu.KrasyukME.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Красюк М. Е. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("Введите количевство строк матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количевство столбцов мтарицы: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите строку цифр: ");
            string value = Console.ReadLine();

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine($"* Результат:{String.Concat(Enumerable.Repeat(" ", 62))}*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine($"Сумма четных цифр матрицы 3 на 3 составленной из строки равна:\n" +
                $"{ds.Calculate(n, m, value)}");
            Console.ReadKey();
        }
    }
}

