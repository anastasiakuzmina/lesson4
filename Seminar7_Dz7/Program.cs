//**********************************************************************************************************************
//*******************Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.****************
//***********************************************************************************************************************
/*


Console.Write("Задайте количество строк m: ");
int m = int.Parse(Console.ReadLine()); 
Console.Write("Задайте количество столбцов n: ");
int n = int.Parse(Console.ReadLine()); 
var random = new Random();
    var array = new double [m,n];
    
    for (int i=0; i < m; i++)
    { Console.WriteLine("");
     for (int j=0; j < n; j++)
    {
        array[i,j] =Convert.ToDouble(random.Next(-100,100))/10;
        if  (array[i,j] > 0)
        Console.Write($" {Math.Round(array[i,j],2)} ");
        else Console.Write($"{Math.Round(array[i,j],2)} ");
    }
    }
*/

//**************************************************************************************************************************************************************************
//***Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.******
//***************************************************************************************************************************************************************************
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
    return array;
}


var array = Getarray(4, 4);
Console.WriteLine("");
Console.Write("Укажите строку искомого элемента: ");
int i = int.Parse(Console.ReadLine()); 
Console.Write("Укажите столбец искомого элемента: ");
int j = int.Parse(Console.ReadLine()); 
try {
     Console.Write($"Искомый элемент {array[i,j]} ");
    }
catch 
{ 
    Console.Write($"такого элемента [{i}; {j}] нет");
}
*/

//************************************************************************************************************
//***Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.******
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

void Getresult(int [,] array, int m, int n)
{
    int result=0;
    for (int i=0; i < n; i++)
    { result=0;
     for (int j=0; j < m; j++)
    {
        result=array[j,i] + result;
    }
    Console.Write($"{result} ");
    } 
}


Console.WriteLine("");
Console.Write("Укажите количество строк ");
int m = int.Parse(Console.ReadLine()); 
Console.Write("Укажите количество столбецов: ");
int n = int.Parse(Console.ReadLine()); 
var array = Getarray(m, n);
Console.Write("Среднее арифмитическое столбцов: ");
Getresult(array,m,n);
*/