// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
Console.WriteLine("Введите число a = ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b = ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c = ");
int c = int.Parse(Console.ReadLine());

if (a<b+c&b<a+c&c<a+b)
{
    Console.WriteLine("такой  треугольник может существовать  ");
}
else
{
    Console.WriteLine("такой  треугольник не может существовать  ");
}