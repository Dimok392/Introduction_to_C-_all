int number, i;

number = 12;

i= -number;
while(i<=number)
{
if (i == number)
    Console.Write($"{i}, ");
else 
    Console.Write($"{i}. ");
i++;
}


