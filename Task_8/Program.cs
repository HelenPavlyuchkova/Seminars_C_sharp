// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
int num = new Random().Next(10, 100); //10, 11, ...99
System.Console.WriteLine($"Возьмем число: {num}");

if((num % 10) > (num / 10))
{
    System.Console.WriteLine($"Наибольшая цифра справа: {num % 10}");
}
else
{
    System.Console.WriteLine($"Наибольшая цифра слева: {num / 10}");
}
