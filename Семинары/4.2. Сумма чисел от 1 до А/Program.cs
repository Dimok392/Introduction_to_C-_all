Console.WriteLine("Введите число А:");
int A = int.Parse(Console.ReadLine());

int SumOfnumbers(int N)    //объявление функции
{
    int sum = 0;
    for (int i = 1; i <= N; i++)
    {
        sum += i;//эквивалентно sum=sum+i
        Console.WriteLine(i);
    }
    Console.WriteLine();
    return sum;
}

  Console.WriteLine(SumOfnumbers(A));