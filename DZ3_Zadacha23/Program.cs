﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int N=Convert.ToInt32(Console.ReadLine());
int i=0;
while (i!=N)
 {
    Console.Write(i*i*i);
    Console.Write(' ');

    i++;
 }
 Console.WriteLine();


