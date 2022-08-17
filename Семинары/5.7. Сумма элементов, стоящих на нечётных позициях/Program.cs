// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
int[] mass = new int[6];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 11);
}
Print(mass);

int summ=0;
for (int i = 1; i < mass.Length; i++)
{

    if (i%2 > 0)
    {
        summ = mass[i]+ summ;
    }

}
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях. = {summ}");
//Console.WriteLine($"в массиве колличество чисел в промежутке {count}");