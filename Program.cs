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

// метод заполнения двумерного массива
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

           
 // метод создания одномерного  массива

int[]Createarray(int count)
{
   return new int [count];
}
// печать одномерного массива

  string Print(int[]array)
{
    return String.Join(' ', array);
} 

// метод выделеня строки из массива
int[] Stringoutarray (int[,]matrix, int str_number, int[]str, int column)
{

for (int j = 0; j <= column-1; j++)
{
 str[j]=matrix[str_number,j];  
}
 return str;
}

// метод помещения строки в массив
int[,] Strinmatrix (int[]str, int str_number, int[,]matrix)
{

   int count = str.Length;
for ( int j = 0; j <= count-1; j++)
{
   // int[] test = {1,2,3};
   matrix[str_number,j] = str[j];
   // matrix[str_number,j] = test[j];
  
}
return matrix;
}
// Метод, который упорядочивает строку
void Selectionsort(int[]str)

{
   for (int i = 0; i <=str.Length - 1; i++)

   {
      int minposition = i;
      for (int a = i+1; a < str.Length; a ++)
      {
        if (str[a] < str [minposition]) 
        {
         minposition = a;
        }
      }
      int temperary = str[i];
      str[i] = str[minposition];
      str[minposition] = temperary;
   }
}

int rows = new Random().Next(1,10);
int column = new Random().Next(1,10);

// int rows = 3;
// int column = 3;
int[,]matrix = new int[rows, column];
int[,]matrix_2 = new int[rows, column];

FillArray(matrix);
Printarray(matrix);
//Printarray(matrix_2);

int [] str = new int[column];

Createarray(column);

// string array_text = Print(str);
// Console.WriteLine(array_text);

//int str_number = 1;

for (int str_number = 0; str_number<=matrix.GetLength(1)-1; str_number++ )
{
int[]string_current = Stringoutarray(matrix,str_number,str,column);
Selectionsort(string_current);

string array_text = Print(string_current);
Console.WriteLine(array_text);

// matrix_2 = Strinmatrix(string_current, str_number, matrix);


// See https://aka.ms/new-console-template for more information
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//1Создать и заполнить массив
//  выделение строки из массива
// подсчет суммы элементов строки
// вложить результат в новый одномерный массив
// подсчет суммы элементов во всех строках
// вложить все результаты в одномерный массив
// Сравнить элементы нового одномерного массива
// Вывести адрес наименьшего элемента

// метод создания двумерного  массива
 
 
void PrintArray(double[,]matrix)
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


    void FillArray (double[,]matrix)
{
    for (int i  = 0; i< matrix.GetLength(0); i++)
    {
       for (int j  = 0; j< matrix.GetLength(1); j++)
        {
           matrix[i,j] = new Random().Next(1,10); 
        }
    }

}

// Заполнение одномерного массива
 void Fill_1d(double[]array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
       // Next() - заполнение случайными неотрицательными числами
        array[index] = 0;
        
        index ++; 
    }
} 
// печать 1мерного массива
string Print1(double[]array)
{
    return String.Join(' ', array);
}

double[] Summaofstrings(double[,]matrix)
{
    double[] array = new double [matrix.GetLength(1)-1];

     
    Fill_1d(array);

    // string array_text = Print1(array);
    // Console.WriteLine(array_text);

    
    
    for (int i  = 0; i< matrix.GetLength(0); i++)
    {
       for (int j  = 0; j< matrix.GetLength(1); j++)
      
       
        { 
           
            array[i] = array[i]+matrix[i,j];

        }

   }



    string array_text = Print1(array);
    Console.WriteLine(array_text);
return array;
}

// Метод, который упорядочивает строку
int Selectionsort(double[]str)

{
    //int a=0;
   for (int i = 0; i <=str.Length - 1; i++)

 {
 int minposition = i;
for ( i+1; i+1 < str.Length; i+1 ++)
     {
        if (str[i+1] < str [minposition]) 
        {
          minposition = i+1;
       }
     }
//       int temperary = str[i];
//       str[i] = str[minposition];
//       str[minposition] = temperary;
    }
   Console.WriteLine(i+1);
    return i+1;
}

// int row  = new Random().Next(1,10); 
// int col  = new Random().Next(1,10); 
int row = 3;
int col = 4;

double[,]matrix = new double [row, col];

FillArray(matrix);
PrintArray(matrix);
Summaofstrings(matrix);
double[]array = Summaofstrings(matrix);

Selectionsort(array);

}

// Printarray(matrix_2);



