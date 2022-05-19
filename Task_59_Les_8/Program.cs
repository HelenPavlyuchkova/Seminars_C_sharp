// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на 
// пересечении которых расположен наименьший элемент массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7 
// Наименьший элемент - 1, 
// на выходе получим следующий массив: 
// 9 4 2
// 2 2 6
// 3 4 7


int m = 5;
int n = 6;

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
}
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int min = array[0,0];//присвоили min нулевой эл-т массива
int mini = 0;//индекс строки минимального эл-та массива
int minj = 0;//индекс столбца минимального эл-та массива
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<min)
            {
                min = array[i,j];
                mini = i;
                minj = j;
            }
        }
    }

int[,] newarray = new int [m-1,n-1];//создали новый массив

System.Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i!=mini & j!=minj)
            {
                int a = i, b = j;
                if(i>mini) a--;
                if(j>minj) b--;
                newarray[a,b] = array[i,j];
            }
        }
   }
PrintArray(newarray);