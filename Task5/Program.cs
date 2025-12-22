// Матрицу A(m, n) (m и n – константы со значением на ваш выбор) заполнить натуральными
// числами от 1 до n*m по спирали, начинающейся в левом верхнем углу и закрученной по часовой стрелке

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 5;
            int[,] matrix = new int[n, m];
            int num = 1;

            int top = 0, bottom = n - 1;
            int left = 0, right = m - 1;

            while (num <= n * m)
            {
                for (int j = left; j <= right && num <= n * m; j++)
                {
                    matrix[top, j] = num++;
                }
                top++;

                for (int i = top; i <= bottom && num <= n * m; i++)
                {
                    matrix[i, right] = num++;
                }
                right--;

                for (int j = right; j >= left && num <= n * m; j--)
                {
                    matrix[bottom, j] = num++;
                }
                bottom--;

                for (int i = bottom; i >= top && num <= n * m; i--)
                {
                    matrix[i, left] = num++;
                }
                left++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
