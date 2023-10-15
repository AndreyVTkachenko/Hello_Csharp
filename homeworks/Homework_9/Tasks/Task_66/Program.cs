// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void Main()
{
    int N = ReadInt("Введите начальное число M: ");
    int M = ReadInt("Введите конечное число N: ");

    if (M < N)
    {
        SumNumbers(M, N);
        System.Console.WriteLine($"Сумма всех натуральных чисел в заданном диапазоне равна: {SumNumbers(M, N)}");
    }
    else
    {
        SumNumbers(N, M);
        System.Console.WriteLine($"Сумма всех натуральных чисел в заданном диапазоне равна: {SumNumbers(N, M)}");
    }
}


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int SumNumbers(int M, int N)
{
    if (M == N) return M;
    return N + SumNumbers(M, N - 1);
}


Main();
