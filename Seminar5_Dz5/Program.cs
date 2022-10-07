//**************************************************************************************************************************************************************************
//************* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.***********
//**************************************************************************************************************************************************************************
/*
int[] GetArray(int size)
{
    var array = new int[size];
    var random = new Random();
    for (int i=0; i < array.Length; i++)
    {
        array[i] =random.Next(99,999);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int Getcount(int [] array )
{
    int count=0;
    for (int i=0; i < array.Length; i++)
    {

        if (array[i]%2==0) count=count+1;
    }
    return count;
}

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()); 
Console.WriteLine("Полученный массив: ");
var array = GetArray(size);

int result = Getcount(array);
Console.Write($"Количество четных чисел в массиве: {result} ");
 */

//******************************************************************************************************************************************
//************* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.***********
//******************************************************************************************************************************************
/*
int[] GetArray(int size)
{
    var array = new int[size];
    var random = new Random();
    for (int i=0; i < array.Length; i++)
    {
        array[i] =random.Next(-10,10);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int Getsumodd(int [] array )
{
    int sum=0;
    for (int i=1; i < array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()); 
Console.WriteLine("Полученный массив: ");
var array = GetArray(size);
 int result = Getsumodd(array);
Console.Write($"Сумма нечетных элементов массива: {result} ");
*/
//**************************************************************************************************************************************************************************
//***Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.*******
//**************************************************************************************************************************************************************************
/*
int[] GetArray(int size)
{
    var array = new int[size];
    var random = new Random();
    for (int i=0; i < array.Length; i++)
    {
   //  array[i] = int.Parse(Console.ReadLine());
       array[i] =random.Next(0,10);
    }
    return array;
}

int [] Getmult(int [] array )
{
    int size = 0;
    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
       var mult = new int[size];
       for (int i=0; i < size; i++)
        {
            mult[i]=array[i]*array[array.Length-i-1];
        }
         return mult;
    }
    else 
     {
            size = (array.Length / 2) + 1;
            var mult = new int[size];
             for (int i=0; i < size-1; i++)
        {
            mult[i]=array[i]*array[array.Length-i-1];
        }
        mult[size-1]=array[size-1];
         return mult;
     }
   
}

void WRArray(int [] warray)
{
    for (int i=0; i < warray.Length; i++)
    {
       Console.Write($"{warray[i] } "); 
    }
}

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()); 
var array = GetArray(size);
Console.Write("Исходный массив: ");
WRArray(array);
Console.WriteLine("");
Console.WriteLine("Полученный массив: ");
var mult = Getmult(array);
WRArray(mult);
*/

//*****************************************************************************************************************************************
//*******************Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.****************
//*****************************************************************************************************************************************
/*
double [] GetArray(int size)
{
    var array = new double[size];
    Console.WriteLine("Введите элементы массива: ");
  //  var random = new Random();
    for (int i=0; i < array.Length; i++)
    {
     array[i] = double.Parse(Console.ReadLine());
    //   array[i] =random.Next(0,10);
    }
    return array;
}

void WRArray(double [] warray)
{
    for (int i=0; i < warray.Length; i++)
    {
       Console.Write($"{warray[i] } "); 
    }
}

double diff(double [] array)
{
    double max = array[0];
    double min = array[0];
    for (int i=1; i < array.Length-1; i++)
    {
        if (array[i] > max)           
         max=array[i];
         if (min>array[i])
             min=array[i]; 

    }
    double res=max-min;
    return res;
}

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()); 
var array = GetArray(size);
Console.Write("Исходный массив: ");
WRArray(array);
double result = diff(array);
Console.Write($"Разность максимального и минимального элемента массива: {result} ");
*/