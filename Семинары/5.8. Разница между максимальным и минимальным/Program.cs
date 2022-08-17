// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
int[] mass = new int[4];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 101);
}
Print(mass);
int min = mass[0];
int max=mass[0];
for (int j = 0; j <mass.Length; j++)
{

if (mass[j] > max)
    {
        max = mass[j];
    }
if (mass[j] < max)
    {
        min = mass[j];
     
    }
}        
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"разница между максимальным и минимальным числом массива = {max - min}");
// }
// // Console.WriteLine($"сумма элементов, стоящих на нечётных позициях. = {max}");
