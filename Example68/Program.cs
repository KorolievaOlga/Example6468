﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;
using static System.Console;
Clear();
Write("Введите a: ");
int a1 = int.Parse(ReadLine());
Write("Введите b: ");
int a2 = int.Parse(ReadLine());

WriteLine($"Функция Аккермана равна {Akkerman(a1, a2)}");

int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    if (b == 0) return Akkerman(a - 1, 1);
    return Akkerman(a - 1, Akkerman(a, b - 1));
}