// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98 2.


// Random random = new Random();

// int a = random.Next(100, 1000);
// Console.WriteLine(a);
// int b = a / 100;
// int c = a % 10;
// int result = b*10+c;
// Console.Write(result);



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

// int a2 = int.Parse(Console.ReadLine());
// int b2 = int.Parse(Console.ReadLine());

// var remainder = b2 % a2;
// if(remainder == 0)
// {
//     Console.WriteLine("Кратное");
// }
// else
// {
//     Console.WriteLine("не кратное");
//     Console.WriteLine(remainder);
// }




// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 46 -> нет 161 -> да

// int a3 = int.Parse(Console.ReadLine());


// if(a3 % 7 == 0 && a3 % 23 == 0)
// {
//     Console.WriteLine("Кратное");
// }
// else
// {
//     Console.WriteLine("не кратное");
// }


//  Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

// int a4 = int.Parse(Console.ReadLine());
// int b4 = int.Parse(Console.ReadLine());

// int kvadrat1 = a4 * a4;
// int kvadrat2 = b4 * b4;

// if(kvadrat1 == b4 || kvadrat2 == a4)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("no");
// }


// ВАЖНАЯ ШТУКА!!!!!!!!!!!!!!!!!!!!!!!!!!
// bool isParsed = int.TryParse(Console.ReadLine(), out int number);
