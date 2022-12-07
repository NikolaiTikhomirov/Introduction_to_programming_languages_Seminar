// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] Array = GenerateArray(100, 999, 15);
// PrintArray(Array);

// Console.WriteLine($"Колличество четных чисел в массиве равно {CountEvenNumbers(Array)}");

// int CountEvenNumbers (int[] col)
// {
//     int evenNumbers = 0;
//     for (int i = 0; i < col.Length; i++)
//     {
//         if(col[i]%2 == 0) evenNumbers++;
//     }
//     return evenNumbers;
// }

// int[] GenerateArray (int min, int max, int length)
// {
//     int[] array = new int [length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     Console.WriteLine($"[{string.Join(", ", arr)}]");
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] Array = GenerateArray(-100, 100, 7);
// PrintArray(Array);

// Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах в массиве равна {SumNonEvenIndexNumbers(Array)}");

// int SumNonEvenIndexNumbers (int[] col)
// {
//     int sumNonEvenIndex = 0;
//     for (int i = 1; i < col.Length; i = i + 2)
//     {
//         sumNonEvenIndex = sumNonEvenIndex + col[i];
//     }
//     return sumNonEvenIndex;
// }

// int[] GenerateArray (int min, int max, int length)
// {
//     int[] array = new int [length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     Console.WriteLine($"[{string.Join(", ", arr)}]");
// }



// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Array = GenerateArray(-10, 10, 5);
PrintArray(Array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DifferenceBetweenMinMax(Array)}");

double DifferenceBetweenMinMax (double[] col)
{
    double min = col[0];
    double max = col[0];
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] < min) min = col[i];
        if (col[i] > max) max = col[i];
    }
    Console.WriteLine($"{min}, {max}");
    return max - min;
}

double[] GenerateArray (int min, int max, int length)
{
    double[] array = new double [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}
