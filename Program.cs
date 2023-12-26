// See https://aka.ms/new-console-template for more information
// using System.Diagnostics;

// Console.WriteLine("Hello, World!");
// коментарий однострочный
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имя_переменной  = значение;
// camelCase: fitstNumber, secondNumber;
// int number = 9; // number = 9
// int result = number * number; // 9*9 =81

// Console.ReadLine() - получить информацию из строчки
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(input + 1000);


// Console.Write("Введите число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber == secondNumber*secondNumber)
// {
//     Console.WriteLine("Да, " + firstNumber  + " является кватратом от числа " + secondNumber);

// }
// else
// {
//     Console.WriteLine("НET, " + firstNumber + " не является кватратом от числа " + secondNumber);

// }


// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите чсло N: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = -N;
while (negativeN <=N);
Console.Write(negativeN);
Console.Write(' ');


