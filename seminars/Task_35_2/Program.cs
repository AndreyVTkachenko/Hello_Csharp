// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int[,] matrix = FillMatrix(row, col, 0, 9);
    PrintMatrix(matrix);
    FreqDictionary(matrix, col, row);
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

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixToPrint)
{
    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FreqDictionary(int[,] matrix, int row, int col)
{
    // int[] countArray = new int[10];
    int max = matrix.Cast<int>().Max();
    int[] countArray = new int[max+1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // for (int k = 0; k < countArray.Length; k++)
            //     if (k == array[i, j])
            //     {
            //         countArray[k]++;
            //     }
            countArray[matrix[i,j]]++;
        }
    }

    for (int k = 0; k < countArray.Length; k++)
    {
        if (countArray[k] != 0) Console.WriteLine($"Число {k} в матрице встречается {countArray[k]}");
    }
}

Main();
