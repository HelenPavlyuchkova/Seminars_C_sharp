// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

int m = 5;
int n = 4;
int[,] massiv = new int[m, n];

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        System.Console.Write(massiv[i, j] + " "); ;
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

int temp = 0;
for (int i = 0; i < massiv.GetLength(1); i++)//i проходит по столбцам
{
    temp = massiv[0, i];
    massiv[0, i] = massiv[massiv.GetLength(0) - 1, i];//меняем местами эл-ты первой строки с эл-ми последней
    massiv[massiv.GetLength(0) - 1, i] = temp;
}

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        System.Console.Write(massiv[i, j] + " "); ;
    }
    System.Console.WriteLine();
}
