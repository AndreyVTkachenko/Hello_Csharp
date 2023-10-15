// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// РЕАЛИЗАЦИЯ С ВВОДОМ РАЗМЕРА МАССИВА И ЕГО ГРАНИЦ ПОЛЬЗОВАТЕЛЕМ

void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int beginRange = ReadInt("Введите начальную границу элементов матрицы: ");
    int endRange = ReadInt("Введите конечную границу элементов матрицы");
    double[,] matrix = FillMatrix(row, col, beginRange, endRange);
    PrintMatrix(matrix);
}


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


double[,] FillMatrix(int row, int col, int beginRange, int endRange)
{
    double[,] matrix = new double[row, col];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = Math.Round(rand.Next(beginRange, endRange) + rand.NextDouble(), 1);
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


Main();

