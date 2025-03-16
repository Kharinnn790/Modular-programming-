using System;
using ModularLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("(4, 9, 10, 11, 16, 17, 18, 21, 22, 23, 24)\n");
                Console.WriteLine("или напишите 'exit' для выхода из программы. ");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "exit") 
                    break;

                switch (choice)
                {
                    case "4":
                        Console.WriteLine("Введите a и b:");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Максимум: {MathimaticFunctions.MaxOfThreeExpressions(a, b)}\n");
                        break;

                    case "9":
                        Console.WriteLine("Введите массив из 10 целых чисел через пробел:");
                        int[] array9 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Console.WriteLine("Введите число n:");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Число {n} повторяется {MathimaticFunctions.CountOccurrences(array9, n)} раз(а)\n");
                        break;

                    case "10":
                        Console.WriteLine("Введите строку:");
                        string str10 = Console.ReadLine();
                        Console.WriteLine("Введите символ:");
                        char ch10 = Console.ReadLine()[0];
                        Console.WriteLine($"Символ '{ch10}' встречается {MathimaticFunctions.CountCharOccurrences(str10, ch10)} раз(а)\n");
                        break;

                    case "11":
                        Console.WriteLine("Введите массив целых чисел через пробел:");
                        int[] array11 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        var result = MathimaticFunctions.FindMaxAndCount(array11);
                        Console.WriteLine($"Максимальный элемент: {result.max}, количество: {result.count}\n");
                        break;

                    case "16":
                        Console.WriteLine("Введите размер квадратной матрицы:");
                        int size16 = int.Parse(Console.ReadLine());
                        int[,] matrix16 = new int[size16, size16];
                        Console.WriteLine("Введите элементы матрицы построчно:");
                        for (int i = 0; i < size16; i++)
                        {
                            int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                            for (int j = 0; j < size16; j++)
                            {
                                matrix16[i, j] = row[j];
                            }
                        }
                        MathimaticFunctions.ReplaceDiagonalWithZeros(matrix16);
                        Console.WriteLine("Матрица после замены диагонали на нули:\n");
                        PrintMatrix(matrix16);
                        break;

                    case "17":
                        Console.WriteLine("Введите размер квадратной матрицы:");
                        int size17 = int.Parse(Console.ReadLine());
                        int[,] matrix17 = new int[size17, size17];
                        Console.WriteLine("Введите элементы матрицы построчно:");
                        for (int i = 0; i < size17; i++)
                        {
                            int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                            for (int j = 0; j < size17; j++)
                            {
                                matrix17[i, j] = row[j];
                            }
                        }
                        MathimaticFunctions.ReplaceNegativesWithOnes(matrix17);
                        Console.WriteLine("Матрица после замены отрицательных элементов на единицы:\n");
                        PrintMatrix(matrix17);
                        break;

                    case "18":
                        Console.WriteLine("Введите размер матрицы (строки и столбцы):");
                        int rows18 = int.Parse(Console.ReadLine());
                        int cols18 = int.Parse(Console.ReadLine());
                        int[,] matrix18 = new int[rows18, cols18];
                        Console.WriteLine("Введите элементы матрицы построчно:");
                        for (int i = 0; i < rows18; i++)
                        {
                            int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                            for (int j = 0; j < cols18; j++)
                            {
                                matrix18[i, j] = row[j];
                            }
                        }
                        Console.WriteLine($"Сумма минимальных элементов по строкам: {MathimaticFunctions.SumOfMinElements(matrix18)}\n");
                        break;

                    case "21":
                        Console.WriteLine("Введите строку:");
                        string str21 = Console.ReadLine();
                        Console.WriteLine($"Реверсированная строка: {MathimaticFunctions.ReverseString(str21)}\n");
                        break;

                    case "22":
                        Console.WriteLine("Введите строку:");
                        string str22 = Console.ReadLine();
                        Console.WriteLine($"Строка с добавленными символами: {MathimaticFunctions.AddSymbolsToString(str22)}\n");
                        break;

                    case "23":
                        Console.WriteLine("Введите символ:");
                        char ch23 = Console.ReadLine()[0];
                        Console.WriteLine("Введите количество символов k:");
                        int k23 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Строка из {k23} символов: {MathimaticFunctions.CreateStringFromChar(ch23, k23)}\n");
                        break;

                    case "24":
                        Console.WriteLine("Введите массив целых чисел через пробел:");
                        int[] array24 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Console.WriteLine("Введите количество элементов n:");
                        int n24 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Сумма первых {n24} элементов: {MathimaticFunctions.SumFirstNElements(array24, n24)}\n");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Неверный выбор. Попробуйте снова!\n");
                        break;
                }
            }
        }
        // вывод матрицы
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}