// Задача 2: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = [1, 2, 3, 4, 5];


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],3}");
    }
}

void PrintReverseArray(int[] arr, int index)
{
    if (index >= arr.Length) return;
    PrintReverseArray(arr, index+1);
    Console.Write($"{arr[index],3}");
}

PrintArray(array);
Console.Write(" => ");
PrintReverseArray(array, 0);



