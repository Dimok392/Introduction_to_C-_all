// ## двумерные массивы ##  
// string [,] table = new string [2,3];массив строк
// string - тип данных строки;
// [,]- говорит о том что массив двумерный.
// table - наименование массива, 
// new string - новый  строчный массив,
// [2,3] - задаётся количество строк и столбцов

// Двумерный массив чисел записывается следующим образом
// int [,] matrix = new int [5,8]; 
// int- тип данных строки;
// [,]- говорит о том что массив двумерный.
// matrix - наименование массива,
// new int - новый числовой массив,
// [5,8] - задаётся количество строк и столбцов
// Где 5 - это количество строк
// А 8 - это количество столбцов

string [,] table = new string [2,5];
table [1,2]= "слово"; // Обращение к конкретному элементу массива.
for (int rows = 0; rows <2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
       System.Console.Write($"-{table[rows,columns]}-");
    }
    System.Console.WriteLine();
}

//Пример числового двумерного массива

void PrintArray (int[,]matr)
{
for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0) - определяет размер массива по строкам
{
    for (int j = 0; j < matr.GetLength(1); j++) //matrix.GetLength(2) - определяет размер массива по столбцам
    {
        System.Console.Write(matr[i,j]);
    }
    System.Console.WriteLine();
}
}

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random ().Next(1,10);
        }
    }
}

int [,] matrix = new int [5,8]; 
FillArray(matrix);
PrintArray(matrix);