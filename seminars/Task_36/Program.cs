// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


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

int row = ReadInt("Введите количество строк: ");
int col = ReadInt("Введите количество стобцов: ");
int[,] array = FillMatrix(row, col, 0, 9);
PrintMatrix(array);

int[,] newArray = new int[row - 1, col - 1];
int indexI = 0; int indexJ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[indexI, indexJ] > array[i, j])
        {
            indexI = i;
            indexJ = j;
        }
    }
}

for (int i = 0, newRow = 0; i < array.GetLength(0); i++)
{
    if (i == indexI) continue;  //переход к следующей итерации
    for (int j = 0, newCol = 0; j < array.GetLength(1); j++)
    {
        if (j == indexJ) continue;
        newArray[newRow, newCol] = array[i, j];
        newCol++;
    }
    newRow++;
}

System.Console.WriteLine();
PrintMatrix(newArray);
