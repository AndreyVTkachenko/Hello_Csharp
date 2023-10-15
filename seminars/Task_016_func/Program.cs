// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

int ReadInt(string text) // Создание функции
{
    System.Console.Write(text);
    int tempNumber = Convert.ToInt32(Console.ReadLine ());
    return tempNumber; // Тип возвращаемого значения должен совпадать с типом функции
}


// int ReadInt(string text) // Создание функции без создания переменной (int tempNumber)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine ());
// }

int SumNumbers(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}

//----------------------------------------------------------------------------------------


int number = ReadInt("Введите число: ");
int sum = SumNumbers(number);

System.Console.WriteLine($"Сумма чисел от 1 до {number}: {sum}");
