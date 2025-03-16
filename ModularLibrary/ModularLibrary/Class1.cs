using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularLibrary
{
    public class MathimaticFunctions
    {
        // 7.4. Возвращает максимум из трех выражений
        public static double MaxOfThreeExpressions(double a, double b)
        {
            double x = Math.Pow(Math.Cos(a + b), 2);
            double y = Math.Sin(a + b);
            double z = (x + y) / 2;

            return Math.Max(x, Math.Max(y, z));
        }

        // 7.9. Подсчет количества повторений числа в массиве
        public static int CountOccurrences(int[] array, int n)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num == n) count++;
            }
            return count;
        }

        // 7.10. Подсчет количества вхождений символа в строке
        public static int CountCharOccurrences(string str, char ch)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == ch) count++;
            }
            return count;
        }

        // 7.11. Поиск максимального элемента и подсчет количества максимумов
        public static (int max, int count) FindMaxAndCount(int[] array)
        {
            int max = array[0];
            int count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                }
                else if (array[i] == max)
                {
                    count++;
                }
            }

            return (max, count);
        }

        // 7.16. Замена элементов диагонали матрицы на нули
        public static void ReplaceDiagonalWithZeros(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                matrix[i, i] = 0;
            }
        }

        // 7.17. Замена всех отрицательных чисел в матрице на единицы
        public static void ReplaceNegativesWithOnes(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0) matrix[i, j] = 1;
                }
            }
        }

        // 7.18. Сумма минимальных элементов матрицы по строкам
        public static int SumOfMinElements(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < min) min = matrix[i, j];
                }
                sum += min;
            }

            return sum;
        }

        // 7.21. Получение новой строки, прочитанной с конца
        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7.22. Добавление символов в начало строки
        public static string AddSymbolsToString(string str)
        {
            return "++++----" + str;
        }

        // 7.23. Формирование строки из k символов
        public static string CreateStringFromChar(char ch, int k)
        {
            return new string(ch, k);
        }

        // 7.24. Суммирование первых n элементов массива
        public static int SumFirstNElements(int[] array, int n)
        {
            int sum = 0;
            for (int i = 0; i < n && i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
