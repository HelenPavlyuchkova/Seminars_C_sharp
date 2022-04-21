// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
//int number = new Random().Next(1, 5);
System.Console.WriteLine("Введите номер четверти, от 1 до 4: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    System.Console.WriteLine("Диапазон координат точки: х > 0, у > 0");
}
else if(number == 2)
{
    System.Console.WriteLine("Диапазон координат точки: х < 0, у > 0");
}
else if(number == 3)
{
    System.Console.WriteLine("Диапазон координат точки: х < 0, у < 0");
}
else if(number == 4)
{
    System.Console.WriteLine("Диапазон координат точки: х > 0, у < 0");
}
else
{
    System.Console.WriteLine("Заданное число не является номером четверти");
}