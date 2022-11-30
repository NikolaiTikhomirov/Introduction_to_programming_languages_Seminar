// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int palindromeOrNot = int.Parse(Console.ReadLine());
while(palindromeOrNot < 10000 || palindromeOrNot > 99999)
{
    Console.Write("Вы ввели неверное число. Введите пятизначное число: ");
    palindromeOrNot = int.Parse(Console.ReadLine());
}
if(Revers(palindromeOrNot))
{
    Console.WriteLine("Число является палиндромом!");
}
else
{
    Console.WriteLine("Число не является палиндромом!");
}

bool Revers(int numberRevers)
 {
    int count = 5;
    int index = 0;
    int temp = numberRevers;
    int newNumber = 0;
    while(index < count)
        {
            newNumber = newNumber * 10 + temp % 10;
            temp = temp / 10;
            Console.WriteLine(newNumber);
            index++;
        }
    bool a = newNumber == numberRevers;
    return a;
 }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125