// Задача 26: Напишите программу, которая принимает на вход число и выдает количество цифр в числе
System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
while (num > 0)
{
    num = num / 10;
    count++;
}
System.Console.WriteLine(count);

//второй способ
System.Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine(a.ToString().Length);
