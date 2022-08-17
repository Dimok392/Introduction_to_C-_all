// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
int[] mass = new int[4];
int per = -1;
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
Print(mass);
int a = 7;
bool b = false;
for (int i = 0; i < mass.Length; i++)
{

    if (mass[i] == a) b = true;

}
if (b) Console.WriteLine($"в массиве есть число а {a}");
else
{
    Console.WriteLine($"в массиве нет числа а {a}");
}






