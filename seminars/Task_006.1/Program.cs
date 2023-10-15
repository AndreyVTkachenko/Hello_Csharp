// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

// БОЛЕЕ ОПТИМИЗИРОВАННОЕ РЕШЕНИЕ МИНИМИЗИРУЮЩЕЕ ИСПОЛЬЗОВАНИЕ ПАМЯТИ

Random rand = new Random();              // Создание генерации случайных чисел в пределах [10, 100)
int randomNumber = rand.Next(10, 100);   // без использования дополнительной памяти при повторном обращении

// int randomNumber = new Random().Next(10, 100); // Создание генерации случайных чисел в пределах [10, 100)

System.Console.WriteLine(randomNumber);

// int leftNumber = randomNumber / 10;
// int rightNumber = randomNumber % 10;

if(randomNumber / 10 > randomNumber % 10) // В условии if сразу используем математическое выражение без объявления переменной
{
    System.Console.WriteLine($"Левое число больше и равно: {randomNumber / 10}");
}
else if(randomNumber / 10 < randomNumber % 10)
{
    System.Console.WriteLine($"Правое число больше и равно: {randomNumber % 10}");
}
else
{
    System.Console.WriteLine($"Числа равны {randomNumber / 10} = {randomNumber % 10}");
}