// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int m = 4;
// int n = 4;
// int[,] array = new int[m, n];

// Fill2DArrayRandome(array);
// Print2DArray(array);
// Console.WriteLine();
// array = SortDescendingRows(array);
// Print2DArray(array);


// int[,] SortDescendingRows (int[,] sortedArray)
// {
//     for (int i = 0; i < sortedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < sortedArray.GetLength(1); j++)
//         {
//             int maxIndex = j;
//             for (int k = j; k < sortedArray.GetLength(1); k++)
//             {
//                 if (sortedArray[i, k] > sortedArray[i, maxIndex]) {maxIndex = k;}
//             }
//                 int maxTemp = sortedArray[i, j];
//                 sortedArray[i, j] = sortedArray [i, maxIndex];
//                 sortedArray[i, maxIndex] = maxTemp;
//         }
//     }
//     return sortedArray;
// }

// int[,] Fill2DArrayRandome(int[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(1, 10);
//         }
//     }
//     return arr;
// }

// void Print2DArray(int[,] col)
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



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int m = 6;
// int n = 4;
// int[,] array = new int[m, n];

// Fill2DArrayRandome(array);
// Print2DArray(array);
// Console.WriteLine();
// FindMinSumRow(array);

// void FindMinSumRow (int[,] sortedArray)
// {
//     int minSumRow = 1;
//     int minSum = 0;
//     for (int i = 0; i < sortedArray.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < sortedArray.GetLength(1); j++)
//         {
//             sumRow = sumRow + sortedArray[i, j];
//         }
//         if (i == 0) minSum = sumRow;
//         if (sumRow < minSum)
//         {
//             minSum = sumRow;
//             minSumRow = i + 1;
//         }
//     }
//     Console.WriteLine($"{minSumRow} строка");
// }

// int[,] Fill2DArrayRandome(int[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(1, 5);
//         }
//     }
//     return arr;
// }

// void Print2DArray(int[,] col)
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


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int m = 2;
// int n = 2;
// int[,] array1 = new int[m, n];
// int[,] array2 = new int[m, n];


// Fill2DArrayRandome(array1);
// Fill2DArrayRandome(array2);
// Print2DArray(array1);
// Console.WriteLine();
// Print2DArray(array2);
// Console.WriteLine();
// int [,] multiplicatedMatrix = Multilication2Matrix(array1, array2);
// Print2DArray(multiplicatedMatrix);

// int[,] Multilication2Matrix (int[,] arr1, int [,] arr2)
// {
//     int[,] newArray = new int[arr1.GetLength(0), arr1.GetLength(1)];
//     if(arr1.GetLength(1) != arr2.GetLength(0))
//     {
//         Console.WriteLine("Произведение этих матриц невозможно!");
//         return newArray;
//     }
//     for (int i = 0; i < arr1.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr2.GetLength(0); k++)
//             {
//                 newArray[i, j] += arr1[i, k] * arr2[k, j];
//             }
//         }
//     }
//     return newArray;
// }

// int[,] Fill2DArrayRandome(int[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(1, 5);
//         }
//     }
//     return arr;
// }

// void Print2DArray(int[,] col)
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



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array = new int[2, 2, 2];

// Fill3DArrayRandome(array);
// Print3DArray(array);
// Console.WriteLine();

// int[,,] Fill3DArrayRandome(int[,,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 bool checkingTemp = false;
//                 int newNonRepeatingRandom = 0;
//                 while(checkingTemp == false)
//                 {
//                     checkingTemp = true;
//                     Random random = new Random();
//                     int temp = random.Next(10, 100);
//                     for (int x = 0; x < arr.GetLength(0); x++)
//                     {
//                         for (int y = 0; y < arr.GetLength(1); y++)
//                         {
//                             for (int z = 0; z < arr.GetLength(2); z++)
//                             {
//                                 if (temp == arr[x, y, z]) checkingTemp = false;
//                                 else newNonRepeatingRandom = temp;
//                             }
//                         }
//                     }
//                 }
//                 arr[i, j, k] = newNonRepeatingRandom;
//             }
//         }
//     }
//     return arr;
// }

// void Print3DArray(int[,,] col)
// {
//     for (int i = 0; i < col.GetLength(0); i++)
//     {
//         for (int j = 0; j < col.GetLength(1); j++)
//         {
//             for (int k = 0; k < col.GetLength(2); k++)
//             {
//                 Console.Write($"{col[i, j, k]} ({i}, {j}, {k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] array = new int [4,4];
array = FillArraySpiral(array);
Print2DArray(array);


int [,] FillArraySpiral (int [,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0) / 2 && i < arr.GetLength(1) / 2; i++)
    {
        for (int j = i; j < arr.GetLength(1) - i; j++)
        {
            arr[i, j] = random.Next(1, 5);
        }
        Print2DArray(array);
        Console.WriteLine();
        for (int k = i + 1; k < arr.GetLength(0) - i; k++)
        {
            arr[k, arr.GetLength(1) - 1 - i] = random.Next(1, 5);
        }
        Print2DArray(array);
        Console.WriteLine();
        for (int l = arr.GetLength(1) - i - 2; l >= 0; l--)
        {
            arr[arr.GetLength(0) - 1 - i, l] = random.Next(1, 5);
        }
        Print2DArray(array);
        Console.WriteLine();
        for (int m = arr.GetLength(0) - i - 2; m > 0 + i; m--)
        {
            arr[m, 0 + i] = random.Next(1, 5);
        }
        Print2DArray(array);
        Console.WriteLine();
    }
    return arr;
}

void Print2DArray(int[,] col)
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
