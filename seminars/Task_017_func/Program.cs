// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine())); // Страховка от ввода отрицательного числа Math.Abs()
}

int CountNumbers(int N)
{
    int count = 0;
    if (N == 0) return 1; // Введение дополнительного условия для того чтобы количество цифр в нуле было равно 1
    while (N > 0)
    {
        N /= 10; // N = N / 10
        count++;
    }
    return count;
}

//---------------------------------------------------------------------------------------

int number = ReadInt("Введите число: ");
int count = CountNumbers(number);

System.Console.WriteLine($"Количество цифр в числе -> {count}");
