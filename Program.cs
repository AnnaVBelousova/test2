// // See https://aka.ms/new-console-template for more information


void PrintArray(int[,]matrix)
{

for (int rows = 0; rows < matrix.GetLength(0); rows ++)
{
    for (int column = 0; column < matrix.GetLength(1); column ++)
    {
       Console.Write($" {matrix[rows, column]}");
    }
    Console.WriteLine();
}
}

    void FillArray (int[,]matrix)
{
    for (int i  = 0; i< matrix.GetLength(0); i++)
    {
       for (int j  = 0; j< matrix.GetLength(1); j++)
        {
           matrix[i,j] = new Random().Next(1,10); 
        }
    }

}
//сортировка

 void PrintArray2 (int[]arr)
  {
    int count = arr.Length;
    for (int i = 0; i< count; i++)

    {
        Console.WriteLine (arr[i]) ;
        }
Console.WriteLine();
}
void Sort (int[]arr)
{
    for (int i =0; i< arr.Length-1; i++)
    {
        int minposition = i;
        for (int j = i+1; j<arr.Length; j++)
        {
            if (arr[j]< arr[minposition])
            {
                minposition = j;
            }
            int temp = arr[i];
            arr[i] = arr[minposition];
            arr[minposition] = temp;


        }
    }
}

int[,]array = new int[2,3];
FillArray(array);
PrintArray(array);

 int[,]arr = new int[2,3];
 FillArray(arr);
 int[]matrix = new int[3];

for (int i = 0; i<array.GetLength(0); i++)
{
    
    
    for (int j = 0; j<array.GetLength(1); j++)
    {
       
        matrix[i] = array[i,j];
       
        Sort(matrix);
        PrintArray2(matrix);
        arr[i,j] = matrix[i];
    }
    Console.WriteLine(arr);
}

