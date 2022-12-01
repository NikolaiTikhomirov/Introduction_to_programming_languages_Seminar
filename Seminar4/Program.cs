//Задача 24: Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28 4 -> 10 8 -> 36
/*bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed || number < 1)
{
    Console.WriteLine("Incorrect number");
    return;
}
int sum = GetSumOfNumbersInInterval(number);
Console.WriteLine(sum);*/

// int[] numbers = new int[] { 1, 2, 3, 4 };

// int[] sums = new int[] { 1, 3, 6, 10 };

// for (var i = 0; i < numbers.Length; i++)
// {
//     int sum = GetSumOfNumbersInInterval(numbers[i]);

//     if (sum != sums[i])
//     {
//         Console.WriteLine($"Ожидали получить {sums[i]} а получили {sum}");
//     }
//     else
//     {
//         Console.WriteLine("okay");
//     }
// }

// int GetSumOfNumbersInInterval(int number)
// {
//     int sum = 0;
//     for (var i = -1; i <= number; i++)
//     {
//         sum += i;
//     }

//     return sum;
// }






// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());
// int lengthNumber = 0;
// while(a > 0)
// {
//     a = a / 10;
//     lengthNumber++;
// }
// Console.WriteLine(lengthNumber);




// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

// bool isParsed = int.TryParse(Console.ReadLine(), out int number);
// if (!isParsed || number < 1)
// {
//     Console.WriteLine("Incorrect number");
//     return;
// }


// double multiplication = GetMultiplicationOfNumbersInInterval(number);
// Console.WriteLine(multiplication);

// int[] numbers = new int[] { 1, 2, 3, 4 };


// double GetMultiplicationOfNumbersInInterval(int number)
// {
//     double multiplication = 1;
//     for (var i = 1; i <= number; i++)
//     {
//         multiplication = i*multiplication;
//     }

//     return multiplication;
// }



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] Array = new int[8];

Method(Array);
PrintArray(Array);

void Method (int[] coll)
{
    int length = coll.Length;
    int index = 0;
    while (index < length)
    {
        coll[index] = new Random().Next(0, 2);
        index++;
    }
    
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}


