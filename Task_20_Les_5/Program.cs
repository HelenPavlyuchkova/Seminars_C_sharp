// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 
void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-9, 10);
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        System.Console.Write(col[i] + " ");
    }
    System.Console.WriteLine();
}

int[] array = new int[4];
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    array[i] = - array[i];
}
PrintArray(array);