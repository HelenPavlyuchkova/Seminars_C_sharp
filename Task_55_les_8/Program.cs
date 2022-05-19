// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.

int m = 5;
int n = 3;

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " "); ;
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

if(m != n)
{
    System.Console.WriteLine("найти решение задачи невозможно");
    return;
}

int temp = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = i; j < array.GetLength(1); j++)
    {
        temp = array[i, j];
        array[i, j] = array[j, i];
        array[j, i] = temp;
    }
}
PrintArray(array);

//на примере 1й строки
// int temp = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         temp = array[0,j];
//         array[0,j] = array[j,0];
//         array[j,0] = temp;
//     }
// }
// PrintArray(array);