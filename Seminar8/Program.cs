// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int m = 6;
// int n = 3;
// int[,] array = new int[m, n];

// FillArrayRandome(array);
// PrintArray(array);
// SwapArray(array);
// Console.WriteLine();
// PrintArray(array);

// int [,] SwapArray(int[,] collection)
// {
//     int[,] swapedArray = collection;
//     int tepm = 0;
//     for (int i = 0; i < collection.GetLength(1); i++)
//     {
//         tepm = swapedArray[collection.GetLength(0)-1, i];
//         swapedArray[collection.GetLength(0)-1, i] = swapedArray[0,i];
//         swapedArray[0,i] = tepm;
//     }
//     return swapedArray;
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


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int m = 4;
int n = 4;
int[,] array = new int[m, n];

FillArrayRandome(array);
PrintArray(array);
Console.WriteLine();
array = ReplaceRowsAndColumns(array);
PrintArray(array);


int[,] ReplaceRowsAndColumns(int[,] collection)
{
    int[,] replacedArray = collection;
    if(collection.GetLength(0) != collection.GetLength(1))
    {
        Console.WriteLine("Это невозможно");
        return replacedArray;
    }
    else
    {
    int temp = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = i; j < collection.GetLength(1); j++)
        {
            temp = replacedArray[i, j];
            replacedArray[i, j] = replacedArray[j, i];
            replacedArray[j, i] = temp;
        }
    }
    }
    return replacedArray;
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



// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 1 встречается 1 раз 2 встречается 1 раз 8 встречается 1 раз 9 встречается 3 раза
// 1, 2, 3 4, 6, 1 2, 1, 6
// 1 встречается 3 раза 2 встречается 2 раз 3 встречается 1 раз 4 встречается 1 раз 6 встречается 2 раза
