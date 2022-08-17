int x = new Random().Next(-100,100);
int y = new Random().Next(-100,100);
Console.WriteLine($"x={x},y={y}");
if (x==0 | y==0)
{
    Console.WriteLine("не принадлежит конкрктной четверти");

}

else if (x>0 & y>0)
{
    Console.WriteLine("точка принадлежит 1-ой четверти");
}
else if (x>0 & y<0)
{
    Console.WriteLine("точка принадлежит 2-ой четверти");
}
else if (x<0 & y<0)
{
    Console.WriteLine("точка принадлежит 3-ей четверти");
}
else if (x<0 & y>0)
{
    Console.WriteLine("точка принадлежит 4-ой четверти");
}
