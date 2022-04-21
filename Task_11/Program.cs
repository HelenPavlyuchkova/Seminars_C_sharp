// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
Console.Clear();
int x = new Random().Next(-1000, 1001);
System.Console.WriteLine($" x = {x}");
int y = new Random().Next(-1000, 1001);
System.Console.WriteLine($" y = {y}");

// Console.WriteLine("Введите координату х: ");
// int x = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату y: ");
// int y = int.Parse(Console.ReadLine());
if(x ==0 | y == 0)
{
    System.Console.WriteLine("Точка не принадлежит ни одной из координатных плоскостей");
}
else if(x > 0 & y > 0)
{
    System.Console.WriteLine("Точка в 1й четверти плоскости");
}
else if(x < 0 & y > 0)
{
    System.Console.WriteLine("Точка в 2й четверти плоскости");
}
else if(x < 0 & y < 0)
{
    System.Console.WriteLine("Точка в 3й четверти плоскости");
}
else
{
    System.Console.WriteLine("Точка в 4й четверти плоскости");
}
