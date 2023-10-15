// Поиск позиции нужного элемента массива, заданного случайным способом

void FillArray(int[] collection) // Создание функции заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll) // Создание функции вывода массива
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        System.Console.WriteLine(coll[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Создание функции определения позиции элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Вводим (-1) для варианта когда необходимого элемента не окажется в массиве
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // Остановка после первого найденного индекса массива 
        }
        index++;
    }
    return position;
}


int[] array = new int[10]; // new int[10] - создание массива, в котором 10 элементов (по умолчанию нули)

FillArray(array); // вызов функции создания
array[4] = 4; // Принудительное добавление числа 4 в индекс 4
array[6] = 4; // Принудительное добавление числа 4 в индекс 6
PrintArray(array); // вызов функции вывода
System.Console.WriteLine(); // Вывод пустой строки - дальнейшее не является частью вывода массива

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);
