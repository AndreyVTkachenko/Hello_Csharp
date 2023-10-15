// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountNumbers(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

//---------------------------------------------------------------------------------------

int number = ReadInt("Введите число: ");
int count = CountNumbers(number);
System.Console.WriteLine(count);
