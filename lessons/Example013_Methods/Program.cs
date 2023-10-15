// Вид 1

void Method1()
{
    System.Console.WriteLine("Автор ...");
}
Method1(); // Вызов метода 



// Вид 2

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения");


void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

Method2_1("Текст", 4); // Method2_1(msg: "Другой текст", count: 4); - Явное указание аргументов.
                       // Method2_1(count: 4, msg: "Другой текст"); - В этом случае очередность не важна.



// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);



// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
System.Console.WriteLine(res);
