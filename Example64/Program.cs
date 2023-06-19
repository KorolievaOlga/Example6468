﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
using System;
using static System.Console;
Clear();
Write("Введите число N: ");
int number = int.Parse(ReadLine());
int count = 1;
NaturalNumbers(number, count);
void NaturalNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalNumbers(n, count + 1);
        Write(count + "    ");
    }
}