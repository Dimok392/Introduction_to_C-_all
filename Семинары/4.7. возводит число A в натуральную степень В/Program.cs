// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = 2;
int b = 4;
int degree = 1;
int pr = a;
while (degree < b)
{
    pr*=a; 
    degree++;
 
}
   Console.WriteLine(pr);