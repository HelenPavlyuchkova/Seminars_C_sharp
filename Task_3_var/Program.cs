//  Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите день недели (число) от 1 до 7: ");
string day = Console.ReadLine();

if(day != "1" & day != "2" & day != "3" & day != "4" & day != "5" & day != "6" & day != "7")
{
    Console.WriteLine("Введенное число не является днём недели");
}

if(day == "1") 
{
    Console.WriteLine("понедельник");
}
 if(day == "2") 
{
    Console.WriteLine("Вторник");
}
if(day == "3") 
{
    Console.WriteLine("Среда");
}
if(day == "4") 
{
    Console.WriteLine("Четверг");
}
if(day == "5") 
{
    Console.WriteLine("Пятница");
}
if(day == "6") 
{
    Console.WriteLine("Суббота");
}
if(day == "7") 
{
    Console.WriteLine("Воскресенье");
}


