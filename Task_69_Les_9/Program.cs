// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵) A = 2; B = 3 -> 8

Console.Clear();
System.Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine()!);
System.Console.Write("введите число В: ");
int B = int.Parse(Console.ReadLine()!);
int PowNum(int a, int b)
{
    if (b <= 0) return 1;
    
    return a * PowNum(a,b-1);
}
System.Console.WriteLine(PowNum(A, B));


//вспомним решение без рекурсии
// System.Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine()!);
// System.Console.Write("введите число В: ");
// int B = int.Parse(Console.ReadLine()!);

// int num = A;
// for(int i = 1; i < B; i++)
// {
//     num = num * A;
// }
// System.Console.WriteLine(num);