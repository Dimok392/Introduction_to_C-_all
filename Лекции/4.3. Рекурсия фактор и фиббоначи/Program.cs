/// Рекурсия - функция которая вызывает сама себя
// 
// Нахождение Факториала с помощью рекурсии

double Factorial (int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}
for (int i = 1; i < 50; i++)
{
    System.Console.WriteLine($"{i}={Factorial(i)}");
}





//// Числа Фиббоначи  0 1 1 2 3 5
double Fibbonaci(int n)
{
    if (n==1||n==2) return 1;
    else return Fibbonaci(n-1)+Fibbonaci(n-2);
}
for (int i = 1; i <50; i++)
{
    System.Console.WriteLine(Fibbonaci(i));
}