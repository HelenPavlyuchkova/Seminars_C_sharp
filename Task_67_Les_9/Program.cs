// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12  45 -> 9

int Rec(int number)
{
    if (number == 0)
    {
        return 0;
    }
    // System.Console.WriteLine(number % 10 + " ");
    //int summa = Rec(number / 10);
    System.Console.WriteLine(number % 10 + " ");//вместо 11 строки
    return Rec(number / 10) + number % 10;
}
int sum = Rec(1234);
System.Console.WriteLine(sum);