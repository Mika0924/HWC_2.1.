﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

double a,b,c;
Console.Write("число а ");
a = Double.Parse(Console.ReadLine());
Console.Write("число b ");
b = Double.Parse(Console.ReadLine());
Console.Write("число c ");
c = Double.Parse(Console.ReadLine());
    if (a>b)
        if(a>c)
        Console.WriteLine($"{a} больше");
    if (c>b)
        if(c>a)
        Console.WriteLine($"{c} больше");
    if (b>a)
        if(b>c)
        Console.WriteLine($"{b} больше");