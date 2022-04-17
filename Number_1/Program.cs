// найти 3ю цифру трехзначного числа
System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

System.Console.WriteLine("Последняя цифра: " + num % 10);


// Вторая цифра в 3х-значном числе. Вариант решения первый
int numa = 1302;

if(numa > 99)
{
    Console.WriteLine((numa / 10) % 10);
}

// найти вторую цифру трехзначного числа. Вариант второй
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = number % 100;
number = number / 10;
System.Console.WriteLine(number);
