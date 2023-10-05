// Задача 29: Напишите программу, которая задаёт принимет на вход длинну массива, и далее элементы массива. Программа должна вывести массив
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);

    Console.WriteLine($"[{string.Join(", ", array)}]");
