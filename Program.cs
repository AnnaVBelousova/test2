// метод создания двумерного  массива
   void Printarray (int[,]matrix)

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
int[,]matrix = new int[3,2];
Printarray(matrix);

// void FillArray (int[,]matrix)
// {
//     for (int i  = 0; i< matrix.GetLength(0); i++)
//     {
//         for (int j  = 0; j< matrix.GetLength(1); j++)
       
//         {
//            matrix[i,j] = new Random().Next(1,10); 
//         }
//     }
// }
           
// // метод создания одномерного  массива





// // метод выделеня строки из массива


//   int[]Stringoutarray(int[,]array);
// {

//     int [] string = new int[array.GetLength(1)];
//     int rows = new Random().Next(1,10);
//     int column = new Random().Next(1,10);


// for (int i = 0; i<= array.Getlength(0); i++)
// {
// for (int j = 0; j<=array.getlength(1); j++)
// string[i]=array[i,j];


// }
// return array;

// }
