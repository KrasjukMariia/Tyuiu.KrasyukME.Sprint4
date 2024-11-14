
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KrasyukME.Sprint4.Task7.V1.Lib
{

    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int evenCount = 0;

            // Заполнение матрицы из строки
            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++, k++)
                {
                    matrix[i, j] = int.Parse(value[k].ToString());

                    // Если элемент четный, увеличиваем счетчик
                    if (matrix[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
            }

            return evenCount;
        }
    }
}