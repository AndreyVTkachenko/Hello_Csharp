// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if((number > 99 && number < 1000) || (number < -99 && number > -1000)) - с добавлением при вводе отрицательных чисел
if(number > 99 && number < 1000)
{
    number = Math.Abs(number % 10); // Math.Abs - Взятие числа по модулю
    System.Console.WriteLine("Последняя цифра " + number);
}
else
{
    System.Console.WriteLine("Введите корректное число от 0 до 999");
}
