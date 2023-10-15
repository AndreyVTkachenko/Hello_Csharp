// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


void Main()
{
    int rows = ReadInt("Введите количество строк: ");
    int cols = ReadInt("Ведите количество стобцов: ");
    int[,] matrix = FillMatrix(rows, cols, 0, 99);
    PrintMatrix(matrix);
    UpheavalArray(matrix);
    System.Console.WriteLine();
    PrintMatrix(matrix);
}


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}


void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void UpheavalArray(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int buffer = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = buffer;
    }
}


Main();
