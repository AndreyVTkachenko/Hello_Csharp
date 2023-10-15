// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Fibonacci(int number)
{
    int[] array = new int[number];
    if (number == 1)
    {
        array[0] = 0;
    }
    else
    {
        array[0] = 0;
        array[1] = 1;
        for (int i = 2; i < number; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

//----------------------------------------------------------------------------
  
int number = ReadInt("Введите число: ");
if (number == 0)
{
    System.Console.WriteLine("Ряд Фибоначчи не имеет нулевого элемента.");
}
else
{
PrintArray(Fibonacci(number));
}
int[] array = new int[number];
Fibonacci(number);
