﻿int Ack (int n, int m)
{
    while (n != 0) 
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = Ack (n, m - 1);
        }
        n--;
    }
    return m + 1;
}
Console.WriteLine(Ack(3,5));