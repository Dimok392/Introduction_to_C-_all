int numberA = new Random().Next(10,99); //Случайный отрезок от 1,,,9
Console.WriteLine(numberA);
int numberB = numberA/10;
int numberC = numberA%10;
int max;
if (numberB>numberC) max = numberB;
else max = numberC;
Console.WriteLine(max);