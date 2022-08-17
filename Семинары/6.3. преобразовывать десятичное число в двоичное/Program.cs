// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Введите десятичное число которое необходимо перевести в двоичную систему ");
int a = int.Parse(Console.ReadLine());
string m = String.Empty;
while(a>0)
{ 
Console.Write(a%2 + " ");
m =a%2+m;
a=a/2;
}
Console.WriteLine();
Console.Write(m + " ");