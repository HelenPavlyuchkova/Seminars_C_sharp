﻿// Задача 5.Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
int N = 5,
    i = -N;
while(i < N)
{
    Console.Write($"{i}, ");
    i++;
}
Console.Write($"{i}. ");
