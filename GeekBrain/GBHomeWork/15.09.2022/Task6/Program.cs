﻿// Задача 6: Напишите программу, которая 
// на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.WriteLine("Введите число, ");
int number = Convert.ToInt32(Console.ReadLine());
int chet = number % 2;
if (chet == 0) 
{
    Console.WriteLine($"Число {number} чётное");
}
else Console.WriteLine($"Число {number} не чётное ");

