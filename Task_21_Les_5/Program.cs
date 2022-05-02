// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

int[] array = new int[5];
FillArray(array);
PrintArray(array);

System.Console.WriteLine("введите искомое число f: ");
int f = int.Parse(Console.ReadLine());
bool b = false;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] == f) b=true;
    break;
}
if(b) System.Console.WriteLine("заданное число есть в массиве");
else System.Console.WriteLine("заданного числа НЕТ в массиве");

// int IndexOfNum (int[] massiv, int find)
// {
//     int position = -1;
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         if(massiv[i] == find)
//         {
//             position = i;
//             break;
//         }
//     }
//     return position;
// }
// int N = IndexOfNum(array, f);
// System.Console.WriteLine($"номер позиции искомого элемента: {N}");
