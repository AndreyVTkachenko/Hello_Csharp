// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ReadMatrix(string text)
{
    System.Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

//----------------------------------------------------------------------------------------------------------

int row = ReadInt("Введите количество строк: ");
int col = ReadInt("Введите количество столбцов: ");
int dep = ReadInt("Введите количество чего-то там: ");



if (row <= 1 || col <= 1 || dep <= 1)
{
    System.Console.WriteLine("По введённым параметрам массив не является трёхмерным.");
    return;
}
else if (row * col * dep > 90)
{
    System.Console.WriteLine("При введённых аргументах создание трехмерного массива только с неповторяющимися двузначными числами невозможно.");
    return;
}

int rez = row * col * dep;
int[] array = ReadMatrix($"Введите через пробел {rez} двузначных неповторяющиеся чисел для заполнения трёхмерного массива.");

for (int x = 0; x < array.Length; x++)
{
    if (array[x] < 10 || array[x] > 99)
    {
        System.Console.WriteLine("Вы ввели некорректные элементы, не являющиеся двузначными.");
        return;
    }
    else if (array.Length != rez)

    {
        System.Console.WriteLine($"Вы ввели количество элементов, не равное {rez}");
        return;
    }
    else
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    System.Console.WriteLine("Вы ввели повторяющиеся элементы.");
                    return;
                }
            }

        }
}

int[,,] matrix = new int[row, col, dep];
for (int i = 0, x = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        for (int k = 0; k < dep; k++)
        {
            matrix[i, j, k] = array[x];
            x++;
            System.Console.Write($"\t{matrix[i, j, k]}, ({i} {j} {k})");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

