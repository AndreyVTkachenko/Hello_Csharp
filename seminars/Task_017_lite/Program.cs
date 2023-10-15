// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberCopy = number;
int count = 0;
while (number > 0)
{
    number /= 10; // number = number / 10
    count++;
}

System.Console.WriteLine($"Количество цифр в числе {numberCopy} равно {count}");


