﻿///////////////////////////////////////////////////////////////////
// Задание 1. Приложение по определению чётного или нечётного числа
///////////////////////////////////////////////////////////////////

Console.WriteLine("Задание 1. Приложение по определению чётного или нечётного числа");
Console.WriteLine("Введите число");
int number;
number = int.Parse(Console.ReadLine());

string oddness;
if (number % 2 == 0) oddness = "Четное";
else oddness = "Нечетное";

Console.WriteLine("Число {0}: {1}", number, oddness);