// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.WriteLine("Введите номер дня недели: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());

if (DayWeek > 7 || DayWeek < 1) // Подбавим креативчику)))
{
    System.Console.WriteLine($"Мне жаль, но тебе пора лечиться от алкоголизма...");
}
else if (DayWeek < 6)
{
    System.Console.WriteLine($"Держись братан! Ещё не выходной...");
}
else if (DayWeek > 5 && DayWeek < 8)
{
    System.Console.WriteLine($"Да! Хватай пивас - идём бухать!!!");
}
