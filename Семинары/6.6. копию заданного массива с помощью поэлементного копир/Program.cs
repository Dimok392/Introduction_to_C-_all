// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,11);
    }
}
void Print(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write(array[i]+" ");
    }
   Console.WriteLine();
}
int [] mass = new int [10];
FillArray(mass);
Print(mass);
int []mass2 = new int [mass.Length];
for (int i = 0; i < mass2.Length; i++)
{
    mass2[i]=mass[i];
}
Print(mass2);