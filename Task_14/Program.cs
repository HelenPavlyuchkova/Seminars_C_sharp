// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N
int N = 12;
int i = 1;
while(i < N)
{
    System.Console.Write($"{i*i}, ");
    i++;
}
System.Console.WriteLine($"{i*i}.");