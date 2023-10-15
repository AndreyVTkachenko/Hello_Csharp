// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void Main()
{

    int[] array = NewArray(3, 0, 100);
    PrintArray(array);
    if (Triangle(array))
    {
        Console.WriteLine("Такой треугольник существует");
    }
    else Console.WriteLine("Такой треугольник не возможен");
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

//Проверка треугольник ли 
bool Triangle(int[] array)
{
    if ((array[0] < array[1] + array[2]) && (array[1] < array[0] + array[2]) && (array[2] < array[1] + array[0]))
    {
        return true;
    }
    return false;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",  ", array) + "]");
}

Main();
