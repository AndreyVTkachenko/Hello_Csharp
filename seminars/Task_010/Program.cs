// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
    System.Console.WriteLine($"Одно из чисел является квадратом другого");
}
else
{
    System.Console.WriteLine($"Среди введённых чисел ни одно не является квадратом другого");
}
