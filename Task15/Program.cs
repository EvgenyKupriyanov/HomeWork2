// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int[] week = {1, 2, 3, 4, 5, 6, 7};

int i = Convert.ToInt32(Console.ReadLine());

if (i <= week[6])
     {
    if (i <= week[4])
     {
    Console.WriteLine("Рабочий день");
     }
    else
    Console.WriteLine("Выходной день");
     }
else
Console.WriteLine("Нет такого дня");
