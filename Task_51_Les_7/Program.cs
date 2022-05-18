// 51. Задайте двумерный массив. Найдите сумму элементов, у которых оба индекса равны друг другу

int m = 4;
int n = 3;
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

//первый способ
//int sum = 0;
// for (int i = 0; i < mass.GetLength(0); i++)
// {
//     for (int j = 0;j < mass.GetLength(1);j++)
//     {
//         if(i == j)
//         {
//             sum += mass[i,j];
//         }
//     }
// }
// System.Console.WriteLine($"Сумма элементов главной диагонали = {sum}");

//рациональный способ
int minsize = mass.GetLength(0);//переменная для поиска минимального кол-ва эл-в. задали условие равенства, чтобы не проверять его в else
if(mass.GetLength(1) < mass.GetLength(0))//проверка для решения случая, когда кол-во строк больше, чем столбцов. Чтобы не выйти за пределы цикла
{
    minsize = mass.GetLength(1);
}

int result = 0;
for (int i = 0; i < minsize; i++)
{
    result = result + mass[i,i];
}
System.Console.WriteLine($"Сумма элементов главной диагонали = {result}");
