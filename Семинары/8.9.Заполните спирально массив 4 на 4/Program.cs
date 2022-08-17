// Задача 62: Заполните спирально массив 4 на 4
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
m = n;
int summ = 0;
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 1+j;
            summ=array[i,j];

        }

    }
}
int[,] matrix1 = new int[m, n];
FillMatrix(matrix1);
Print(matrix1);
Console.WriteLine();
// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix1.GetLength(1); j++)
//     {
      
//     }

// }