// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

void Main()
{
    int number = ReadInt("Введите искомое число");
    int[] array = NewArray(10, 0, 10); // Задание случайного массива функцией с параметрами, указанными в круглых скобках
    PrintArray(array);
    Console.WriteLine(Exist(array, number));
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] NewArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

bool Exist(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}

Main();