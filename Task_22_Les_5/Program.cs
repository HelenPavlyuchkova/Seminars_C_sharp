// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123. [5, 18, 123, 6, 2] -> 1

void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-10, 100);
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

int[] mass = new int[123];
FillArray(mass);
PrintArray(mass);
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if(mass[i] <= 99 & mass[i] >= 10)
    {
        count++;
    }
}
System.Console.WriteLine($"в заданном массиве присутствуют числа из промежутка [10, 99] {count} раз");