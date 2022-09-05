// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
Console.WriteLine ("Введите число");

int number = int.Parse (Console.ReadLine());
int count = 1;

while (number-1 >= count) { 

    Console.Write ($"{count+1} ");
    count += 2;
} 
