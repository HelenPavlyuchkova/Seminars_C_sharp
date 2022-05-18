// 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и 
// замените эти элементы на их квадраты.
int m = 3;
int n = 4;
int[,] mass = new int[m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0;j < mass.GetLength(1);j++)
    {
        mass[i,j] = new Random().Next(0,10);
        System.Console.Write(mass[i,j] + " ");
    }
System.Console.WriteLine();
}
System.Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i=i+2)//шаг=2, обходим только четные индексы
{
    for (int j = 0; j < mass.GetLength(1); j=j+2)
    {
        mass[i,j] = mass[i,j]*mass[i,j];
    }
}
System.Console.WriteLine("Получили массив: "); //нумерация с нуля
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0;j < mass.GetLength(1);j++)
    {
        System.Console.Write($"{mass[i,j]} ");
    }
System.Console.WriteLine();
}