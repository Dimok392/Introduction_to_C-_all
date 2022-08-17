//Упорядочивание массива
// Сортировка массива способом нахождения минимального с заменой местами с текущим элементом

int [] array = {10,92,43,95,68,86,49,73};
void PrintArray( int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+" ");
    }
    System.Console.WriteLine();
}
PrintArray(array);
void SelectionSort ( int [] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[j]<array[minPosition]) minPosition=j;
    }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]=temporary;
    }
}
SelectionSort(array);
PrintArray(array);