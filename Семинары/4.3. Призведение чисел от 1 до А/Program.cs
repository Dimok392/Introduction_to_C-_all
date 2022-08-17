Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int pr = 1;
for(int i = 1; i<=N; i++)
{
  pr*=i;
  Console.WriteLine(pr);
}