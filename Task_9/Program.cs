// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление
Console.Clear();

int a = 25;
int b = 5;
if(a % b == 0)
{
    System.Console.WriteLine($"{a} кратно {b}");
}
else
{
    System.Console.WriteLine($"не кратно, остаток {a % b}");
}

// второй вариант решения
//Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 % num2 == 0)
{
    System.Console.WriteLine($"{num1} кратно {num2}");
}
else
{
    System.Console.WriteLine($"не кратно, остаток от деления равен {num1 % num2}");
}