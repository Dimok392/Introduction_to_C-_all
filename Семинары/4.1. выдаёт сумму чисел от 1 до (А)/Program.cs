// написать программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до (А)
Console.WriteLine("Введите число А:");
int A = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= A; i++)
{
    Console.WriteLine(i);
    sum +=i;//эквивалентно sum=sum+i
    Console.WriteLine(sum);
}
