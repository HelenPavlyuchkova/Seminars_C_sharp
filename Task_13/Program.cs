// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
int x1, x2, y1, y2;

x1 = 7;
y1 = -5;
x2 = 10; 
y2 = -1;
int AB = (int)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); //кастомизировали int в int
//double AB = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
System.Console.WriteLine(AB);