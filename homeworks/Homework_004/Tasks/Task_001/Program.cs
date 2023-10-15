// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int ResultPov(int N, int M)
{
    if (M == 0) return 1;
    int count = 0;
    int result = 1;
    while (count < M)
    {
        result  *= N;
        count++;
    }
    return result;
}
//---------------------------------------------------------------------------

int N = ReadInt("Введите число: ");
int M = ReadInt("Введите показатель степени: ");
if (M < 0)
{
    System.Console.WriteLine("Вы ввели отрицательный показатель степени, а это ненатуральное число");
}
else
{
System.Console.WriteLine($"Число {N} в степени {M} равно: {ResultPov(N, M)}");
}