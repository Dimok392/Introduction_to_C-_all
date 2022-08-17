int dni = 6;//new Random().Next(1,8); //Случайный отрезок от 1,,,9
Console.Write($"{dni} день недели");
int vih1 = 6;
int vih = 7;
if (dni==6 | dni==7)
{
    Console.Write($" это выходной");
}
else
{
    Console.Write($" это будний день");
}