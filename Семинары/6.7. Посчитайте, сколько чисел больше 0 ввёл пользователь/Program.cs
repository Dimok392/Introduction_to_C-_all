// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел " );
string d = Console.ReadLine();
string [] arr = d.Split(" ");
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    int m = int.Parse(arr[i]);
    if (m>0)
    count=count+1;
    // Console.Write(sum );
    // Console.Write(arr[i] + ",");
    // Console.Write(count);
}
 Console.Write(count);