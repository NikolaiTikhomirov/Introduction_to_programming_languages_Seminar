// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int m = 6;
// int n = 3;
// double[,] array = new double[m, n];

// FillArrayRandomeRealNumbers(array);
// PrintArray(array);


// double[,] FillArrayRandomeRealNumbers(double[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = Math.Round(random.NextDouble()*10, 1);
//         }
//     }
//     return arr;
// }

// void PrintArray(double[,] col)
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



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int m = 6;
// int n = 3;
// int[,] array = new int[m, n];

// FillArrayRandome(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine(PrintArrayValueByCoordinates(array));

// string PrintArrayValueByCoordinates (int[,] collection)
// {
//     string result = string.Empty;
//         Console.WriteLine("Введите координаты элемента из двумерного массива, который вы хотите увидеть:");
//         bool isParsedRowPosition = int.TryParse(Console.ReadLine(), out int rowPosition);
//         bool isParsedColumnPosition = int.TryParse(Console.ReadLine(), out int columnPosition);
//         if(!isParsedRowPosition || !isParsedColumnPosition)
//         {
//             result = "Координаты введены не корректно";
//             return result;
//         }
//         if(rowPosition > collection.GetLength(0) || columnPosition > collection.GetLength(1) || rowPosition < 1 || columnPosition < 1)
//         {
//             result = "такого числа в массиве нет";
//             return result;
//         }
//     result = collection[rowPosition - 1, columnPosition - 1].ToString();
//     return result;
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


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 6;
int n = 3;
double[,] array = new double[m, n];

FillArrayRandomeRealNumbers(array);
PrintTwoDimensionalArray(array);
double [] arithmeticMeanArray = ArithmeticMeanColumns(array);
PrintArray(arithmeticMeanArray);

double [] ArithmeticMeanColumns (double [,] collection)
{
    double [] arithmeticMeanColumnsArray = new double [collection.GetLength(1)];
    for (int i = 0; i < collection.GetLength(1); i++)
    {
        for (int j = 0; j < collection.GetLength(0); j++)
        {
            arithmeticMeanColumnsArray[i] = Math.Round((arithmeticMeanColumnsArray[i] + collection[j, i])/2, 1);
        }
    }

    return arithmeticMeanColumnsArray;
}

double[,] FillArrayRandomeRealNumbers(double[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(random.NextDouble()*10, 1);
        }
    }
    return arr;
}

void PrintTwoDimensionalArray(double[,] col)
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

void PrintArray(double[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}