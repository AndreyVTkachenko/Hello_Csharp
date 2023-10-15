// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

System.Console.WriteLine("Введите своё число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 0;

if(numberA > 0)
{
    numberB = -numberA;
}
else
{
    numberB = numberA;
    numberA = -numberA;
}
while (numberA >= numberB)
{
    System.Console.Write(numberB + " "); // В отличие от WriteLine - вывод в строку
    numberB = numberB + 1; // Либо же numberB ++
}
