// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

void NumberToBinary(int number) // Применение рекурсии
{
    if (number == 0)
    {
        return;
    }
    NumberToBinary(number / 2);
    System.Console.Write(number % 2);
}

int number = ReadInt("Введите десятичное число для перевода в двоичный формат: ");
NumberToBinary(number);
