//  Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива
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

int[] array = new int[12];
FillArray(array);
PrintArray(array);

int sumPos = 0;
int sumNeg = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPos = sumPos + array[i];
    }
    else
    {
        sumNeg = sumNeg + array[i];
    }
}
System.Console.WriteLine($"Сумма положительных чисел: {sumPos}, и сумма отрицательных чисел: {sumNeg}");

