Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 23;
int c =7;
if (a%b==0&a%c==0)
{
    Console.WriteLine($"Число {a} одновременно кратно числу {b} и {c}");

}
else 
{
    Console.WriteLine($"Число {a} одновременно не кратно числу {b} и {c}");
}