﻿//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
void ShowNumbers(int M, int N)
{
    if (M == N) 
    {
        Console.Write(M);
        return;
    }
    Console.Write(M + ", "); 
    ShowNumbers(M + 1, N); 
}
Console.Write("Введите число М: "); 
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: "); 
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(M, N);

