// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void Main()
{
    int[] array = FillArray(7, 0, 10); 
    int[] array2 = array[..]; // Копирование массива. При этом дальнейшие изменения в одном их них никак не повлияют на другой

    array[0] = 100; 
    array2[6] = -99;

    PrintArray(array);
    PrintArray(array2);
    // int[] newArray = CopyArray(array);
    // PrintArray(newArray);
    int[] array3 = CopyArray(array);
    PrintArray(array3);
}

int[] CopyArray(int[] arrayToCopy)
{
    int[] copiedArray = new int[arrayToCopy.Length];
    for(int i = 0; i < copiedArray.Length; i++)
    {
        copiedArray[i] = arrayToCopy[i];
    }

    return copiedArray;
}

int[] FillArray(int size = 5, int leftRange = 0, int rightRange = 20)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

Main();
