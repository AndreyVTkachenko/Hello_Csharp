// Поиск позиции нужного элемента массива

int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length; // Обращение к длине массива
int find = 18;
int index = 0;

while(index <n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break; // Остановка действия цикла
    }
    index++;
}
