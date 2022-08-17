int a = 12821;
int b = a / 1000;
Console.WriteLine($"b={b}");
int d = 10;
int c = a % 100;
Console.WriteLine($"c={c}");

if (a<99999&a>9999)
{


if (b % d == c / d & b / d == c % d)
{
    Console.WriteLine($"число {a} является полиндромом");
}

else
{
    Console.WriteLine($"число {a} не является полиндромом");
}
}
else 
{
    Console.WriteLine($"число {a} не пятизначное");
}
