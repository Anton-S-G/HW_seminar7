﻿Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine()); // Первое число в промежутке чисел
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());  // Второе число в промежутке чисел


string ShowNumber (int start, int end)
{
    if (start == end) // 1 2 3 4 x
    {
        return start.ToString();
    }
    return start + " " + ShowNumber(start + 1, end);
}
Console.WriteLine(ShowNumber(M, N));