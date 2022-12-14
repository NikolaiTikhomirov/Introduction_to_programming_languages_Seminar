// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int m = 3;
// int n = 4;
// int[,] array = new int[m, n];

// FillArray(array);
// PrintArray(array);

// int[,] FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = i + j;
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] col)
// {
//     for (int i = 0; i < col.GetLength(0); i++)
//     {
//         for (int j = 0; j < col.GetLength(1); j++)
//         {
//             Console.Write($"{col[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }


// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 47 2
// 5 92 3
// 8 42 4

// Новый массив будет выглядеть вот так:
// 1 47 2
// 5 81 9
// 8 42 4
// 25 мин

// int m = 5;
// int n = 5;
// int[,] array = new int[m, n];

// FillArrayRandome(array);
// PrintArray(array);
// Console.WriteLine();
// QuadrateNegativeIndexValue(array);
// PrintArray(array);

// int[,] QuadrateNegativeIndexValue(int[,] collection)
// {
//     for (int i = 1; i < collection.GetLength(0); i = i + 2)
//     {
//         for (int j = 1; j < collection.GetLength(1); j = j + 2)
//         {
//             collection[i, j] = collection[i, j] * collection[i, j];
//         }
//     }
//     return collection;
// }

// int[,] FillArrayRandome(int[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(-10, 10);
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] col)
// {
//     for (int i = 0; i < col.GetLength(0); i++)
//     {
//         for (int j = 0; j < col.GetLength(1); j++)
//         {
//             Console.Write($"{col[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int m = 6;
int n = 3;
int[,] array = new int[m, n];

FillArrayRandome(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(SumElementsMainDiagonal(array));




int SumElementsMainDiagonal(int[,] collection)
{
    int sum = 0;
    for (int i = 0; i < collection.GetLength(0) && i < collection.GetLength(1); i++)
    {
        sum = sum + collection[i, i];
    }
    return sum;
}

int[,] FillArrayRandome(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(-10, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]} ");
        }
        Console.WriteLine();
    }
}

