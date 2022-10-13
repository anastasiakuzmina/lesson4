//************************************************************************************************************
//***Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.******
//************************************************************************************************************
/*
int [,] Getarray(int m, int n)
{
    var random = new Random();
    var array = new int [m,n];
    
    for (int i=0; i < m; i++)
    { Console.WriteLine("");
     for (int j=0; j < n; j++)
    {
        array[i,j] =random.Next(0,10);
        Console.Write($"{array[i,j]} ");
    }
    }
    Console.WriteLine(""); 
    return array;
}

int [,] Getresult(int [,] array)
{
     for (int i=0; i < array.GetLongLength(0); i++)  
         for (int j=0; j < array.GetLongLength(1); j++)
            for (int k=0; k < array.GetLongLength(1)-1; k++)
            {
                  if (array[i, k] < array[i, k + 1])
                     {
                         int tmp = array[i, k + 1];
                         array[i, k + 1] = array[i, k];
                         array[i, k] = tmp;
                     }
            }
 return array;
}




Console.Write("Укажите количество строк ");
int m = int.Parse(Console.ReadLine()); 
Console.Write("Укажите количество столбцов: ");
int n = int.Parse(Console.ReadLine()); 
var array = Getarray( m,  n);
array = Getresult(array);
 Console.WriteLine("");
 Console.WriteLine("Отсортиврованный масив:");
for (int i=0; i < m; i++)
 {  Console.WriteLine("");
     for (int j=0; j < n; j++)
      Console.Write($" {array[i,j]}");
 }

*/
//************************************************************************************************************
//***Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов..******
//************************************************************************************************************
/*
int [,] Getarray(int m, int n)
{
    var random = new Random();
    var array = new int [m,n];
    
    for (int i=0; i < m; i++)
    { Console.WriteLine("");
     for (int j=0; j < n; j++)
    {
        array[i,j] =random.Next(0,10);
        Console.Write($"{array[i,j]} ");
    }
    }
    Console.WriteLine(""); 
    return array;
}

int Getresult(int [,] array)
{   
    int sum = 0;
    int minsum = 0;
    int minstr=0;
     for (int i=0; i < array.GetLongLength(0); i++)  
        { 
          if (minsum < sum)
          {
            minstr = i;
            minsum=sum;
          }
          sum=0;
         for (int j=0; j < array.GetLongLength(1); j++)
          {
            sum=sum+array[i,j];  
          }
            if (minsum < sum)       
              minstr = i;
        }
 return minstr;
}

Console.Write("Укажите количество строк ");
int m = int.Parse(Console.ReadLine()); 
Console.Write("Укажите количество столбцов: ");
int n = int.Parse(Console.ReadLine()); 
var array = Getarray( m,  n);
int result = Getresult(array);
 Console.WriteLine("");
 Console.WriteLine($"{result} cтрока:");
*/


//************************************************************************************************************
//*** Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.******
//************************************************************************************************************
/*
int [,] Getarray(int m, int n)
{
    var random = new Random();
    var array = new int [m,n];
    
    for (int i=0; i < m; i++)
    { Console.WriteLine("");
     for (int j=0; j < n; j++)
    {
        array[i,j] =random.Next(0,10);
        Console.Write($"{array[i,j]} ");
    }
    }
    Console.WriteLine(""); 
    return array;
}

int [,] Getresult(int [,] arrayA, int [,] arrayB)
{   
    var arrayC = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i=0; i < arrayA.GetLength(0); i++)
        for (int j=0; j < arrayB.GetLength(0); j++)
            for (int k=0; k < arrayB.GetLength(1); k++)
                {
      
                 arrayC[i,k]=arrayC[i,k]+arrayA[i,j]*arrayB[j,k];
   
                }
    
    Console.WriteLine(""); 
    return arrayC;

}

Console.Write("Укажите количество строк ");
int m = int.Parse(Console.ReadLine()); 
Console.Write("Укажите количество столбцов: ");
int n = int.Parse(Console.ReadLine()); 
Console.Write("массив А");
var arrayA = Getarray( m,  n);
Console.Write("массив Б");
var arrayB = Getarray( m,  n);
var arrayC = Getresult(arrayA, arrayB);
 Console.Write("Полученный массив:");
for (int i=0; i < arrayC.GetLength(0); i++)
    {
       Console.WriteLine("");
       for (int j=0; j < arrayC.GetLength(1); j++)
            Console.Write($" {arrayC[i,j]}");
    }


*/

//***************************************************************************************************************************************************************************
//***.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*****
//***************************************************************************************************************************************************************************
/*
int [,,] Getarray(int m, int n, int l)
{
    var random = new Random();
    var array = new int [m,n,l];
    var tmparray = new int [m*n*l];
    for (int i=0; i < tmparray.Length; i++ )
    {
        tmparray[i]=random.Next(10,100);
        if (i>0)
        {
            for (int j=0; j < i; j++ )
            {
                while(tmparray[i]==tmparray[j])
                {
                    tmparray[i]=random.Next(10,100);
                    j=0;
                }
            }
        }
        
    }
int count = 0;
    for (int x = 0; x < m; x++)
        for(int y = 0; y < n; y++)
            for(int z = 0; z < l; z++)
            {
                array[x,y,z]=tmparray[count];
                count++;
            }
    return array;
}

void WriteArray (int[,,] array)
{
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        Console.Write( $"{array[x,y,z]}({x},{y},{z}) ");
      }
      Console.WriteLine();
    }
  }
}

Console.WriteLine("Задайте трехмерный массив размерностью m, n, l ");
Console.Write("Укажите m: ");
int m = int.Parse(Console.ReadLine()); 
Console.Write("Укажите n: ");
int n = int.Parse(Console.ReadLine()); 
Console.Write("Укажите l: ");
int l = int.Parse(Console.ReadLine()); 
var array = Getarray(m,n,l);
WriteArray(array);
*/
//*********************************************************************
//***напишите программу, которая заполнит спирально массив 4 на 4.******
//*********************************************************************
/*

void WriteArray(int [,] result)
{
for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
        if (result[i,j] > 9) 
         Console.Write($"{result[i,j]} ");
        else 
         Console.Write($" {result[i,j]} ");
    }
    Console.WriteLine();
  }
}

Console.Write("Укажите размерность массива m: ");
int m = int.Parse(Console.ReadLine()); 
var spiral = new int[m,m];
int count = 1;
int i=0;
int j = 0;
while (count <= m * m)
{
  spiral[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < m - 1)
    j++;
  else if (i < j && i + j >= m - 1)
    i++;
  else if (i >= j && i + j > m - 1)
    j--;
  else
    i--;
}

WriteArray(spiral);
*/