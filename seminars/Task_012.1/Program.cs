﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] array = { "X > 0 & Y > 0", "X < 0 & Y > 0", "X < 0 & Y < 0", "X > 0 & Y < 0" }; // Самостоятельно создаём строчный массив из 4 элементов. Необходимо помнить какой элемент массива какой четверти соответствует, а также расположить их в порядке возрастания.

if (number > 0 && number <5)
{
    System.Console.WriteLine(array[number - 1]);
}
else
{
    System.Console.WriteLine("Такой четверти не существует");
}
