// найти вторую цифру трехзначного числа
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = number % 100;
number = number / 10;
System.Console.WriteLine(number);

