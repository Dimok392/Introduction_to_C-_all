int [] array = {1,2,1,4,3,6,5,4,8,6,4};
int n = array.Length; // определяет длину массива
int find = 4;
int index = 0;

while (index<n)
{
    if(array[index] == find)
{
    System.Console.WriteLine(index);
    break; //в случае выполнения if(array[index] == find) заканчивает проверку.
}
index++;

}


