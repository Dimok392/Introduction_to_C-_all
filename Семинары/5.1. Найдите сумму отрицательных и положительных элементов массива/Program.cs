// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
void Print(int [] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int [] mass = new int [3];
Print(mass);
for (int i = 0; i < mass.Length; i++)
{
    mass[i]=new Random().Next(-9,10);
    Console.Write($" {mass[i]}");
}   
Console.WriteLine();

int summPos=0;
int summNeg=0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i]>0)
    {
       summPos+=mass[i]; 
    }
    else 
    {
        summNeg+=mass[i];
    }
}
Console.WriteLine($"Сумма положительных чисел = {summPos}");
Console.WriteLine($"Сумма отрицательных чисел = {summNeg}");

