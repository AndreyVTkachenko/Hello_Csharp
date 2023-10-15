// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

System.Console.WriteLine("Ведите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB * numberB == numberA)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}

