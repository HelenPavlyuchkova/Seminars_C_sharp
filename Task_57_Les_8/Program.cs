// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

int m = 3;
int n = 4;

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
    System.Console.WriteLine();
}
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int[] save = new int[array.Length];//массив, куда сохраняем уникальные элементы
int[] elcount = new int[array.Length];//массив, где хранятся кол-ва уникальных эл-в
int count = 0;
bool exist;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int k = 0; k < count; k++)
        {
            if (array[i, j] == save[k])//если текущий эл-т равен какому-то эл из save, значит он уже сущ-т
            {
                exist = true;
                elcount[k]++;
                break;
            }
        }
        if (exist == false)//если не нашли нашего эл-та после прохода массива save, значит его нет 
        {
            save[count] = array[i, j];//добавим его в save
            elcount[count] = 1;//посчитаем его
            count++;
        }
    }
}
for (int i = 0; i < count; i++)
{
    System.Console.WriteLine(save[i] + "-" + elcount[i]);
}

