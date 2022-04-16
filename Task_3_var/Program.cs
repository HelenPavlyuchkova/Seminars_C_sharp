//  Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
int day = 1;
Console.WriteLine("Введите номер дня недели: ");
Console.Write($"{day}");
//int day = Convert.ToInt32(ReadLine());

if(day == 1) 
{
    Console.WriteLine("понедельник");
}
 if(day == 2) 
{
    Console.WriteLine("Вторник");
}
if(day == 3) 
{
    Console.WriteLine("Среда");
}
if(day == 4) 
{
    Console.WriteLine("Четверг");
}
if(day == 5) 
{
    Console.WriteLine("Пятница");
}
if(day == 6) 
{
    Console.WriteLine("Суббота");
}
if(day == 7) 
{
    Console.WriteLine("Воскресенье");
}


