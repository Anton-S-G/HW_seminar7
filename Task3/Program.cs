// Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = { 55, 3, 73, 15, 4, 34, 1, 10, 43, 9, 12, 78 };
int j = array.Length - 1;

void ShowArray(int[] arr, int j)
{
    // int j = arr.Length - 1;
    if (j == 0)
    {
        Console.Write(arr[j]);
        return;
    }

    Console.Write(arr[j] + " ");
    j--;
    ShowArray(arr, j);
}
ShowArray(array, j);