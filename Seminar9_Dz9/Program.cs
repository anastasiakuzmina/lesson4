﻿//********************************************************************************************************************************************
//***Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.******
//********************************************************************************************************************************************
/*
int Getn(int n)
{
 Console.Write($" {n}");
if (n==1) return 1;
else return Getn(n-1);
}

Console.Write("Укажите значение N: ");
int n = int.Parse(Console.ReadLine()); 
 Getn(n);
 */
//**********************************************************************************************************************
//***Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*****
//**********************************************************************************************************************

/*
int GetSumN(int m, int n)
{
if (m==n) return 0;
else 
    return m+GetSumN(m+1,n);  
}

Console.Write("Укажите значение M: ");
int m = int.Parse(Console.ReadLine()); 
Console.Write("Укажите значение N: ");
int n = int.Parse(Console.ReadLine()); 
if (m<n) Console.Write($"Результат: {GetSumN(m,n)}");
else Console.Write($"Результат: {GetSumN(n,m)}");
*/
//*****************************************************************************************************************
//***Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*****
//*****************************************************************************************************************
/*
int funAkkerman(int m, int n)
{
if (m == 0)
{
    return n + 1;
}
else 
    if (n == 0 && m > 0)
    {
        return funAkkerman(m - 1, 1);
    }
    else
    {
        return funAkkerman(m - 1, funAkkerman(m, n - 1));
    }
}

Console.Write("Укажите значение M: ");
int m = int.Parse(Console.ReadLine()); 
Console.Write("Укажите значение N: ");
int n = int.Parse(Console.ReadLine()); 
Console.Write($"Результат функции Аккермана: {funAkkerman(m,n)} ");
*/