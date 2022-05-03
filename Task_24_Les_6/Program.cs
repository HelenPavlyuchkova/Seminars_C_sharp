// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.) [1 2 3 4 5] -> [5 4 3 2 1]

int[] array = new int[7];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();

int temp = 0;
for (int i = 0; i < array.Length/2; i++)
{
    temp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = temp; 
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
