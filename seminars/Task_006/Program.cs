// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

int randomNumber = new Random().Next(10, 100); // Создание генерации случайных чисел в пределах [10, 100)
System.Console.WriteLine(randomNumber);

int leftNumber = randomNumber / 10;
int rightNumber = randomNumber % 10;

if(leftNumber > rightNumber)
{
    System.Console.WriteLine($"Левое число больше и равно: {leftNumber}");
}
else if(leftNumber < rightNumber)
{
    System.Console.WriteLine($"Правое число больше и равно: {rightNumber}");
}
else
{
    System.Console.WriteLine($"Числа равны {leftNumber} = {rightNumber}");
}
