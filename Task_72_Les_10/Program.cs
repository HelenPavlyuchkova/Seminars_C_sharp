// Задача 72: Заданы 2 массива: info и data. В массиве data хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве info хранится
// информация о количестве бит, которые занимают числа из массива data.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info. 
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }-биты
// - info = {2, 3, 3, 1 }-размеры чисел(кол-во бит) из data
// выходные данные: - 1, 7, 0, 1

int[] array1 = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };//data
int[] array2 = { 2, 3, 3, 1 };//info

int Transfer(int[] data, int[] info)
{
    int[] result = new int[info.Length];
    int count = 0;//отступ до текущей цифры
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = count; j < count + info[i]; j++)
        {
            result[i] += data[j] * Convert.ToInt32(Math.Pow(2,info[i]+count-j-1));

        }
        count += info[i];
        System.Console.Write(result[i] + " ");
    }
    return result[0];
}

Transfer(array1, array2);