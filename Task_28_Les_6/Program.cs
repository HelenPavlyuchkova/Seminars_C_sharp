// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного
// копирования. 
void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write($"{arr[index]} ");
    }
    Console.WriteLine();
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int[] array2 = new int[array.Length];
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array[i];
}
PrintArray(array2);
// array2[1]=44; //пробуем заменить элемент во втором массиве
// PrintArray(array);// первый массив не изменился
// PrintArray(array2);

// если копировать массив целиком, получим не копию, а один и тот же массив
// int[] array3= new int[array.Length];
// array3=array;
// array3[2]=55;
// PrintArray(array);
// PrintArray(array3);
