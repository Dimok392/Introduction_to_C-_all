Console.WriteLine("трёхзначное число");
int num = new Random().Next(100,1000); //int.Parse(Console.ReadLine());
Console.WriteLine(num);
int num2 = num/100;
int num3 = num%10;
int num4 = num2*10 + num3;
Console.Write($"после удаления средней цыфры получил {num4}");

