﻿// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число, умноженное само на себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число "); // Вывод в терминал приглашения пользователя ко вводу
int number = Convert.ToInt32(Console.ReadLine()); // Чтение целого числа из терминала с конвертацией (Convert.ToInt32 ())
int result = number * number;
// System.Console.WriteLine("Квадрат введённого числа: " + result  + веришь?);
System.Console.WriteLine($"Квадрат введённого числа равен: {result} веришь?"); // форматированная строка
