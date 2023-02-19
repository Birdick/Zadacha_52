// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Enter the row quantiry of your matrix: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the columns quantity of your matrix: ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Enter the minimum number of your matrix: ");
int numMin = int.Parse(Console.ReadLine()!);
Console.Write("Enter the maximum number of your matrix: ");
int numMax = int.Parse(Console.ReadLine()!);
int[,] matrix2D = GetArray(row, col, numMin, numMax);
PrintArray(matrix2D);
Console.WriteLine();

Console.WriteLine("Enter the column number where you want to get the average sum: ");
int averagenumcol = int.Parse(Console.ReadLine()!);
//ввели номер столбца, где ищем среднее арифметическое

int averageSum = matrix2D[0, averagenumcol];
//задали начальное значение среднего арифметического
double result = 0.0;
{
    for (int i = 0; i <= row; i++)
    {
        averageSum++;
        result = averageSum / row + 1;
    }
}

Console.WriteLine($"The average sum in column {averagenumcol} is {result}");