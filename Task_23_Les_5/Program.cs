// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3

void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-10, 10);
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

int[] mass = new int[7];
int[] res = new int[4];
FillArray(mass);
PrintArray(mass);

void MultArrNum(int[] array, int[] result)
{
    result[result.Length-1] = array[array.Length/2];//последний элемент рез-го массива = среднему эл-ту первого массива
    for (int i = 0; i < array.Length/2; i++)
    {
        result[i] = array[i] * array[array.Length-1-i];
    }
}
MultArrNum(mass, res);
PrintArray(res);