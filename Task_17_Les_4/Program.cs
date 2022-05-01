// Задача 28: Напишите программу, которая принимает на вход число N, а выдает произведение чисел от 1 до N
System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int mult = 1;
for (int i = 1; i <= N; i++)
{
    System.Console.Write(i + " ");
    mult = mult * i;
}
System.Console.WriteLine();
System.Console.Write(mult);