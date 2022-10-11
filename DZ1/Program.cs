// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Start:

Console.Write("Введите целое число >- ");
long number = Convert.ToInt64(Console.ReadLine());

void Palindrom(long num)
{
    long avers = num;
    long revers = avers % 10;
    while (avers > 10)
    {
        avers = avers / 10;
        revers = revers * 10 + avers % 10;
    }
    if (num == revers)
    {
        Console.WriteLine($"Введенное число {num} является палиндромом");
    }
    else Console.WriteLine($"Введенное число {num} не является палиндромом");
}
Palindrom(number);
Console.WriteLine();
goto Start;
