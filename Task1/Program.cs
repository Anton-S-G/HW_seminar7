Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
// int start = 1;
// start = 1, end = 5
// void ShowNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         Console.Write(start); 
//         return; // Ломает всю программу, если попали в этот фрагмент 
//     }
//     Console.Write(start + " "); // 1 2 3 4 5
//     ShowNumbers(start + 1, end);
// }
// ShowNumbers(M, N); // start = 1, end = N

string ShowNumber (int start, int end)
{
    if (start == end) // 1 2 3 4 x
    {
        return start.ToString();
    }
    return start + " " + ShowNumber(start + 1, end);
}
Console.WriteLine(ShowNumber(M, N));