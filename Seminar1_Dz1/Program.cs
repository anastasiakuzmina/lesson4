/*

 Console.Write("ВВеди число: ");
 int number = int.Parse(Console.ReadLine());
 int result = number * number;
 Console.WriteLine($"Квадрат числа {number} = {result}");
 int result_2 = Convert.ToInt32(Math.Pow(number, 2));
 Console.WriteLine($"Квадрат числа {number} = {result_2}");

*/
//**************************************************************************************

/*
 Console.Write("Введите первое число: ");
 int number_one = int.Parse(Console.ReadLine());
 Console.Write("Введите второе число: ");
 int number_two = int.Parse(Console.ReadLine());
 if(number_one > number_two)
 { 
   Console.Write($"max = {number_one}");
 }
 else 
 { 
    Console.Write($"max = {number_two}");
 }

*/

//**************************************************************************************

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//**************************************************************************************
/*
 Console.Write("Введите первое число: ");
 int number_one = int.Parse(Console.ReadLine());
 Console.Write("Введите второе число: ");
 int number_two = int.Parse(Console.ReadLine());
 Console.Write("Введите третье число: ");
 int number_three = int.Parse(Console.ReadLine());
 int max = number_one;
 if (number_one > number_two) max = number_one;
 if (number_two > max) max = number_two;
 if (number_three > max) max = number_three;
    Console.Write("max =");
    Console.Write(max);
*/

//**************************************************************************************

// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
 
//************************************************************************************** 
  /*  Console.WriteLine("Введите число: ");
 int number_start = int.Parse(Console.ReadLine());
 if(number_start  % 2 == 0)
 {
    Console.Write("да");
 } 
 else      
 {
    Console.Write("нет");
 }
*/
//*************************************************************************************
/*
    Console.Write("Введите число: ");
 int number = int.Parse(Console.ReadLine());
 int i = 1;
    Console.Write("Все четные числа: ");
  while (i <= number) 
  {
  if (i % 2 == 0)
   Console.Write($" {i} ");

   i = i + 1;
  }
  */