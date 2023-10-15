// Отдельное приветствие для определённого пользователя с помощью условия If
Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username?.ToLower() == "andrew")
{
    Console.WriteLine("Ура! Это же Andrew!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
