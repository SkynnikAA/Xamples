﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;
int num;
bool not = true;
Boolean begin = true;

Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
    {
        if (i % 2 != 1)
            {
                Console.Write(i + ", ");
                not = false;
            }
        i++;
    }

        if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
        


begin = false;
