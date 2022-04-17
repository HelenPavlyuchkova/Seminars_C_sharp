// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
Console.Clear();
System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if((a % 23 == 0) & (a % 7 == 0))
{
    System.Console.WriteLine($"Число {a} кратно 23 и 7");
}
else
{
    System.Console.WriteLine($"Число {a} НЕ кратно 23 и 7");
}