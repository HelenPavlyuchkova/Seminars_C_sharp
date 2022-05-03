// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
// такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
System.Console.WriteLine("введите длину стороны А: ");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("введите длину стороны B: ");
int B = int.Parse(Console.ReadLine());
System.Console.WriteLine("введите длину стороны C: ");
int C = int.Parse(Console.ReadLine());

if(A + B > C && B + C > A && A + C > B)
{
    System.Console.WriteLine($"треугольник со сторонами А ={A}, В ={B}, С ={C} существует");
}
else
{
    System.Console.WriteLine($"треугольник со сторонами А ={A}, В ={B}, С ={C} НЕТ");
}