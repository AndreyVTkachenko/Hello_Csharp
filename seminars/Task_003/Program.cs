// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

System.Console.WriteLine("Введите номер дня недели: ");
int DeyWeek = Convert.ToInt32(Console.ReadLine());

if(DeyWeek == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if(DeyWeek == 2)
{
   System.Console.WriteLine("Вторник"); 
}
else if(DeyWeek == 3)
{
   System.Console.WriteLine("Среда"); 
}
else if(DeyWeek == 4)
{
   System.Console.WriteLine("Четверг"); 
}
else if(DeyWeek == 5)
{
    System.Console.WriteLine("Пятница");
}
else if(DeyWeek == 6)
{
    System.Console.WriteLine("Суббота");
}
else if(DeyWeek == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}

// Если в условии If выполняется только одно действие, то фигурные скобки можно опустить
// System.Console.WriteLine("введите номер дня недели: ");
// int DayWeek = Convert.ToInt32(Console.ReadLine());

// if (DayWeek == 1)
// System.Console.WriteLine("сегодня понедельник");
// else if (DayWeek == 2)
// System.Console.WriteLine("сегодня вторник");
// else if (DayWeek == 3)
// System.Console.WriteLine("сегодня среда");
// else if (DayWeek == 4)
// System.Console.WriteLine("сегодня четверг");
// else if (DayWeek == 5)
// System.Console.WriteLine("сегодня пятница");
// else if (DayWeek == 6)
// System.Console.WriteLine("сегодня суббота");
// else if (DayWeek == 7)
// System.Console.WriteLine("сегодня воскресенье");
// else System.Console.WriteLine("такого дня не существует");