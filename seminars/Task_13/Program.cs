// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int[] coordinateA = new int[2]; // Создаём массив из 2-х элементов для координат первой точки

System.Console.WriteLine("Введите координату X первой точки: ");
coordinateA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y первой точки: ");
coordinateA[1] = Convert.ToInt32(Console.ReadLine());

int[] coordinateB = new int[2]; // Создаём массив из 2-х элементов для координат второй точки

System.Console.WriteLine("Введите координату X второй точки: ");
coordinateB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y второй точки: ");
coordinateB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((coordinateB[0] - coordinateA[0]), 2) + Math.Pow((coordinateB[1] - coordinateA[1]), 2)), 3));

// Math.Pow(3, 4) - Возведение числа 3 в степень 4
// Math.Sqrt(11) - Извлечение квадратного корня из 11
// Math.Round(3.1415577855, 4) - Округление чмсла до 4 знаков после запятой
