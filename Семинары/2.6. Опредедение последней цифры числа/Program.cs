Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());


int c = a/100;
Console.WriteLine($"c={c}");
if (c<10)
{
     Console.Write($"последняя цифра равна {a%10}");
}
if (c>=10)
{
    Console.Write($"последняя цифра равна {(a/10)%10}");
}

