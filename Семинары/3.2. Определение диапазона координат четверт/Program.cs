Console.WriteLine("введите номер четверти");
int a = int.Parse (Console.ReadLine());
int x;
int y;

    if (a==1)
    {
        x = new Random().Next(0,100);
        Console.WriteLine($"x={x}");
        y = new Random().Next(0,100);
        Console.WriteLine($"y={y}");
    }
    if(a==2)
    {
        x = new Random().Next(-100,0);
        Console.WriteLine($"x={x}");
        y = new Random().Next(0,100);
        Console.WriteLine($"y={y}");
    }
    if (a==3)
    {
        x = new Random().Next(-100,0);
        Console.WriteLine($"x={x}");
        y = new Random().Next(-100,0);
        Console.WriteLine($"y={y}");
    }
    if (a==4)
    {
        x = new Random().Next(0,100);
        Console.WriteLine($"x={x}");
        y = new Random().Next(-100,0);
        Console.WriteLine($"y={y}");
    }
    else 
    {  
        Console.WriteLine("такой четверти нет");
    }