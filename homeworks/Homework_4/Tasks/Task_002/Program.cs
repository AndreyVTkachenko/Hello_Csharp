// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


int SumNumbers(int number)
{
    int remainder = 0;
    int result = 0;
    while (number > 0)
    {
        remainder = number % 10;
        number /= 10;
        result += remainder;
    }
    return result;
}



//---------------------------------------------------------------------------

int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр в заданном числе равна: {SumNumbers(number)}");




