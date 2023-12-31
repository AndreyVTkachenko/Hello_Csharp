﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 || number < -100)
{
    while (number > 1000 || number < -1000)
    {
        number = number / 10;
    }
    System.Console.WriteLine($"Третья цифра введённого числа - это: {number % 10}");
}
else
{
    System.Console.WriteLine($"В ведённом числе нет третьей цифры");
} 
// Не смог избавиться от отрицательного ответа при вводе отрицательного числа пользователем (((