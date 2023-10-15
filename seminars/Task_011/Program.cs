// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int[] coordinates = new int[2]; // Создание массива с именем coordinates с двумя ячейками памяти
System.Console.Write("Введите координату X: ");
coordinates[0] = Convert.ToInt32(Console.ReadLine()); // Записываем значение в ячейку 0

System.Console.Write("Введите координату Y: ");
coordinates[1] = Convert.ToInt32(Console.ReadLine()); // Записываем значение в ячейку 1

if (coordinates[0] > 0 && coordinates[1] > 0)
{
    System.Console.WriteLine("Точка находится в 1-й четверти");
}
else if (coordinates[0] < 0 && coordinates[1] > 0)
{
    System.Console.WriteLine("Точка находится во 2-й четверти");
}
else if (coordinates[0] < 0 && coordinates[1] < 0)
{
    System.Console.WriteLine("Точка находится в 3-й четверти");
}
else if (coordinates[0] > 0 && coordinates[1] < 0)
{
    System.Console.WriteLine("Точка находится в 4-й четверти");
}
else
{
    System.Console.WriteLine("Введены неправильные координаты");
}
