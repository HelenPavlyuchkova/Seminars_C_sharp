// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
//Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8
System.Console.WriteLine("введите число N: ");
int N = int.Parse(Console.ReadLine());
int F0 = 0;
int F1 = 1;
int fib;
System.Console.Write(F0 + " " + F1 + " ");
for (int i = 1; i < N-1; i++)
{
    fib = F0+F1;
    F0 = F1;
    F1 = fib;
    System.Console.Write(fib + " ");
}
System.Console.WriteLine();

//решение через массив
void Print(int[] col)
{
    for(int i = 0; i < col.Length; i++)
    {
        System.Console.Write(col[i]+ " ");
    }
}

int[] mass = new int[N];
mass[0] = 0;
mass[1] = 1;
for (int i = 2; i < mass.Length; i++)
{
    mass[i] = mass[i-1] + mass[i-2];
}
Print(mass);