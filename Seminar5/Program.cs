// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] Array = GenerateArray(-10, 10, 10);
// PrintArray(Array);
// ReversNumbersArray(Array);
// PrintArray(Array);


// int[] ReversNumbersArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * -1;
//     }
//     return arr;
// }

// int[] GenerateArray (int min, int max, int length)
// {
//     Random random = new Random();
//     int[] array = new int[length];

//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }

//     return array;
// }

// // void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     Console.Write("[");
//     while (position < count - 1)
//     {
//         Console.Write($"{col[position]}, ");
//         position++;
//     }
//     Console.Write($"{col[col.Length - 1]}]");
//     Console.WriteLine();
// }

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да


// Console.WriteLine("Какоке число вы хотите найти в массиве?");
// int a = int.Parse(Console.ReadLine());
// int[] Array = GenerateArray(-10, 10, 10);
// PrintArray(Array);
// Console.WriteLine(FindNumberInArray(Array, a));

// string FindNumberInArray(int[] arr, int aa)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (aa == arr[i]) return "Yes";
//     }
// return "No";
// }
// int[] GenerateArray (int min, int max, int length)
// {
//     Random random = new Random();
//     int[] array = new int[length];

//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }

//     return array;
// }
// void PrintArray(int[] col)
// {
//     Console.WriteLine($"[{string.Join(", ", col)}]");
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// int [] Array = GenerateArray(0, 150, 7);
// Console.WriteLine(Count(Array));
// PrintArray(Array);

// int Count (int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] >= 10 && arr[i] < 99) count++;
//     }
//     return count;
// }
// int[] GenerateArray (int min, int max, int length)
// {
//     Random random = new Random();
//     int[] array = new int[length];

//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }

//     return array;
// }
// void PrintArray(int[] col)
// {
//     Console.WriteLine($"[{string.Join(", ", col)}]");
// }



// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] Array = GenerateArray(0, 10, 5);

PrintArray(Array);
int[] NewArray = SomeNewMassive(Array);
PrintArray(NewArray);



int[] SomeNewMassive(int[] arr)
{
    int n = arr.Length / 2 + arr.Length % 2;
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        if (i == arr.Length - 1 - i)
        {
            result[i] = arr[i];
        }
        else
        {
            result[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    }
    return result;
}


int[] GenerateArray(int min, int max, int length)
{
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}
void PrintArray(int[] col)
{
    Console.WriteLine($"[{string.Join(", ", col)}]");
}