﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число ");
string n = Console.ReadLine();

if (n.Length > 2)
     {
    Console.WriteLine("Третье число " + n[2]);
     }
else
Console.WriteLine("Третьей цифры нет");

