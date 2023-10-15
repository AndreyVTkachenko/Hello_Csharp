// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


void Main()
{
    int M = ReadInt("Введите начальное число M: ");
    int N = ReadInt("Введите конечное число N: ");
    if (M < 0 || N < 0)
    {
        System.Console.WriteLine("Вы ввели некорректные числа.");
        return;
    }
    System.Console.WriteLine($"Число, определённое функцией Аккермана по введённым параметрам равно: {FuncAckerman(M, N)}");
}


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int FuncAckerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return FuncAckerman(M - 1, 1);
    else
    {
        return FuncAckerman(M - 1, FuncAckerman(M, N - 1));
    }
}


Main();
