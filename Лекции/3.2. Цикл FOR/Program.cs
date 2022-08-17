//Цикл FOR
//
string Method4(int count, string text)
{
    string result = String.Empty;//пустая строка 
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(4, "text");
System.Console.WriteLine(res);

// цикл в цикле
//вывод таблицы умножения
for (int i = 2; i <= 10 ; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    }
    System.Console.WriteLine();
}