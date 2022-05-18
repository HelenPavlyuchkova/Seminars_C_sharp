// 46.  Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int m = 5;
int n = 4;

int[,] mass = new int [m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0;j < mass.GetLength(1);j++)
    {
        mass[i,j] = new Random().Next(-10,10);
        System.Console.Write(mass[i,j] + " ");
    }
    System.Console.WriteLine();
}
//дополнительно
System.Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1);j++)
    {
        
        mass[i,j] = mass[i,j] * mass[i,j];
        System.Console.Write(mass[i,j] + " ");
    }
    System.Console.WriteLine();
}
