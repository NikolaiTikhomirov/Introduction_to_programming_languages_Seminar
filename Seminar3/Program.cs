// Решение в группах задач:
// Задача 18: Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// bool isParsed = int.TryParse(Console.ReadLine(), out int number);


// if(!isParsed)
// {
//     Console.WriteLine("Номер четверти ввели не корректно");
//     return;
// }

// GetCoordinates(number);

// void GetCoordinates(int number)
// {
//     if(number == 1)
//     {
//         Console.WriteLine("x > 0 && y > 0");
//         return;
//     }

//     if(number == 2)
//     {
//         Console.WriteLine("x < 0 && y > 0");
//         return;
//     }

//     if(number == 3)
//     {
//         Console.WriteLine("x < 0 && y < 0");
//         return;
//     }

//     if(number == 4)
//     {
//         Console.WriteLine("x > 0 && y < 0");
//         return;
//     }
// Console.WriteLine("Введены некорректные четверти");
// }





// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
 
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

// bool isParsedxa = int.TryParse(Console.ReadLine(), out int xa);
// bool isParsedya = int.TryParse(Console.ReadLine(), out int ya);
// bool isParsedxb = int.TryParse(Console.ReadLine(), out int xb);
// bool isParsedyb = int.TryParse(Console.ReadLine(), out int yb);

// //  if(!isParsedxa && isParsedxa)
// // {
// //     Console.WriteLine("Номер четверти ввели не корректно");
// //     return;
// // }


// double distanse = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya));

// Console.WriteLine(distanse);


// Задача 22: Напишите программу, которая принимает на
//  вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//  int[] array =  
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4




Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());
int Nmin = 1;
int[] ArrayQuadrate = new int[N+1-Nmin];
FillArrayQuadrate(ArrayQuadrate);
PrintArray(ArrayQuadrate);


void FillArrayQuadrate(int[] Collection)
{
    int length = Collection.Length;
    int index = 0;
    while(index < length)
    {
        Collection[index] = (int) Math.Pow(Nmin,2);
        index++;
        Nmin++;
    }
}

void PrintArray(int[] Col)
{
    int count = Col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(Col[position]);
        position++;
    }
}






// bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

// bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

// if(!isParsedX || !isParsedY)
// {
//     Console.WriteLine("Координаты ввели не корректно");
//     return;
// }

// int quarterNumber = GetQuarterNumberByCoordinates(x,y);
// if(quarterNumber == - 1)
// {
//     Console.WriteLine("Координаты равны нулю");
//     return;
// }
// Console.WriteLine(quarterNumber);

// // возвращаемый_тип_данных НазваниеМетода()
// // {
// //    return 1; // оператор return возвращает из метода значение и останавливает его.
// //}

// int GetQuarterNumberByCoordinates(int x, int y)
// {
//     if(x > 0 && y > 0)
//     {
//         return 1;
//     }

//     if(x < 0 && y > 0)
//     {
//         return 2;
//     }

//     if(x < 0 && y < 0)
//     {
//         return 3;
//     }

//     if(x > 0 && y < 0)
//     {
//         return 4;
//     }

//     return -1;
// }

// void PrintArray(int[] array)
// {
//     for(int i= 0; i< array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

// double Calculate(int a, int b)
// {
//     return a * b + b * a;
// }