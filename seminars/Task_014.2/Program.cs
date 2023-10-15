// Вывод списка элементов массива через задаваемый разделитель

int[] array = {12, 10, 15, 20, 21, -7, 0, -11, 13, 5};

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + ", "); // Выводит запятую после последнего элемента массива - не айс...
// }
System.Console.WriteLine(string.Join(", ", array)); // В кавычках указываем необходимый разделитель
System.Console.WriteLine(string.Join(" ||  ", array)); // В кавычках указываем необходимый разделитель
System.Console.WriteLine(string.Join(" //  ", array)); // В кавычках указываем необходимый разделитель
System.Console.WriteLine(string.Join(" : ", array)); // В кавычках указываем необходимый разделитель