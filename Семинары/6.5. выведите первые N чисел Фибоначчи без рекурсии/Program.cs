// Задача 44: не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int f1 = 0;
int f2 = 1;
Console.Write(f1 +" " +f2 + " ");
int f;
for (int i = 1; i < n; i++)
{
    f = f1+f2;
    f1=f2;
    f2=f;
    Console.Write(f +" ");
}

//Console.Write(Fibonaci(i));
