// Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
System.Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= A; i++)
{
    System.Console.Write(i + " ");
    sum = sum + i;
}
// System.Console.WriteLine(sum);
System.Console.WriteLine();

//через цикл while
int j = 1;
while(j <= A)
{
    System.Console.Write(j + " ");
    // sum += j;
    j++;
}
System.Console.WriteLine(sum);

//через метод
int SumOfNum(int N)
{
    int sum1 = 0;
    for (int i = 1; i<= N; i++)
    {
        sum1 += i;
        System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
    return sum1;
}
int s = SumOfNum(A);
System.Console.WriteLine(s);