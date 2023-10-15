// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= number)
{
    System.Console.Write(Math.Pow(count, 2) + " ");
    count++;
}

