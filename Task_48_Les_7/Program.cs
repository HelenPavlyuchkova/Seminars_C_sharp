// 48. Задайте двумерный массив размера m на n,каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран. m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

System.Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов n");
int n = int.Parse(Console.ReadLine()!);

int[,] mass = new int [m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = i+j;
        System.Console.Write(mass[i,j] + " ");
    }
System.Console.WriteLine();
}
