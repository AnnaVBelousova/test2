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

// int row = new Random().Next(1,10);
// int column = new Random().Next(1,10);
// int[,]matrix = new int[row, column];
// Printarray(matrix);
// FillArray(matrix);

           
// // метод создания одномерного  массива

int[]Createarray(int count)
{
   return new int [count];
}
// печать одномерного массива

  string Print(int[]array)
{
    return String.Join(' ', array);
} 


// // метод выделеня строки из массива

//int rows = new Random().Next(1,10);
//int column = new Random().Next(1,10);
int rows = 2;
int column = 3;
int[,]matrix = new int[rows, column];
FillArray(matrix);
Printarray(matrix);
int [] str = new int[column];

Createarray(column);
string array_text = Print(str);
Console.WriteLine(array_text);
//метод заполнения строки значениями из массива

 int[] Stringoutarray (int[,]matrix)
 {


for (int i = 0; i<= rows; i++)
{
for (int j = 0; j<=column; j++)
{
   for (int k = 0; k<=column; k++)
{
str[k]=matrix[i,j];
}

}

 }
 return str;
 }

Stringoutarray(matrix);
Console.WriteLine(str);
 