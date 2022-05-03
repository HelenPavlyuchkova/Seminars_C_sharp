// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 3 -> 11 2 -> 10
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
string s = String.Empty;
//int A = 0;
while (N > 0)
{
    int A = N % 2;
    s = A.ToString() + s;//строка, в которой наши остатки накапливаются, как sum =sum+A, но меняем местами слагаемые
    N = N / 2;
}
System.Console.WriteLine(s);