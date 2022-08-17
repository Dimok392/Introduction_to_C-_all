// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
int[] mass = new int[123];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-10, 100);
}
Print(mass);
int count = 0;
for (int i = 0; i < mass.Length; i++)
{

    if (mass[i]>=10& mass[i]<=99)
    {
    count = count+1;
    } 

}
Console.WriteLine($"в массиве колличество чисел в промежутке {count}");



