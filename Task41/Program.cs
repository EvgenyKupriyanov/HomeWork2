// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void ReleaseArray(int[] array)
{
    int count = 0;
     for(int i = 0; i < array.Length; i++)
     {
        if (array[i] > 0)
        {count++;
        }  
     }
     Console.Write(count);
     
}

Console.Write("Введите числа: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
ReleaseArray(array);