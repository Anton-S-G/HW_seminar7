// Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); // Первое число в промежутке чисел
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());  // Второе число в промежутке чисел


string ShowNumber (int start, int end)
{
    if (start == end) // 1 2 3 4 x
    {
        return start.ToString();
    }
    return start + " " + ShowNumber(start + 1, end);
}
Console.WriteLine(ShowNumber(firstNumber, secondNumber));