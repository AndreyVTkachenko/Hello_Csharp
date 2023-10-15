// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void FillArray(int[] arr)
{
    Random rand = new Random();

    for (int i = 0; i < 8; i++) // Для любого одномерного массива будет (i < arr.Length)
    {
        arr[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join(" ", arr));
}

//------------------------------------------------------------------------------------------------------

int[] array = new int[8]; // Объявляем массив с ВОСЕМЬЮ ячейками памяти, по умолчанию заполненными нулями
FillArray(array);
PrintArray(array);

int[] temp ={1, 2, 3, 4, 5, 6, 7, 8}; // Будет работать 
PrintArray(temp);                     // для любого массива


// Random rand = new Random();

// for (int i = 0; i < 8; i++)
// {
//     array[i] = rand.Next(0, 2);
// }

// System.Console.WriteLine(string.Join(" ", array));






