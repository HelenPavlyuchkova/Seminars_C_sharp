﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

System.Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

void IntNum(int n, int m)
{
    if (m == n + 1)
    {
        return;
    }
    Console.WriteLine(m);
    IntNum(n, m + 1);
}


IntNum(N, 1);