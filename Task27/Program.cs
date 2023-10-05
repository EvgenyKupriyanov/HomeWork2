// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void f(int n)
{
     int summ = 0;
     while (n > 0)
     {
         summ = summ + n % 10;
         n = n / 10;
     }
     Console.Write(summ);
 }

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
f(n);
