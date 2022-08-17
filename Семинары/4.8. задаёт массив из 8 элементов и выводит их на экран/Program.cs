// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// int [] mass = new int [8];
// int[] a;
// for (int i = 0;i<mass.Length;i++)
// {
//     mass[i]=new Random().Next(0,9);
//    // Console.Write($"[{mass[i]}]");

// }
//  Console.Write($"{a ={mass[i]}}");
int n;
Console.WriteLine("Введите количество элементов массива ");
n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    a[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine("Массив: {0}", String.Join(" ", a));
Console.ReadLine();