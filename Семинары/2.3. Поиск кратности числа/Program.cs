
Console.WriteLine("Введите 1-е чило");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е чило");
int b = int.Parse(Console.ReadLine());
if (a%b==0)
{

 Console.WriteLine($"число {b} кратно числу {a}");

}
else 
{
    Console.WriteLine($"остаток {a%b} ");
}

