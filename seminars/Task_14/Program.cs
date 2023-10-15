// Заполнение массива и вывод результата в терминал

int[] array = new int[5]; // Создаём массив из 5 ячеек, пока пустых

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine()); // Заполняем массив в терминале

}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " "); //Выводим заполненный массив одной строкой через пробел в терминал
}




