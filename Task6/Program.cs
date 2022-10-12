/*Задача 6*: Напишите программу, которая генерирует последовательность случайных чисел до тех пор, 
пока не сгенерирует кратное число введенному в начале.*/

Console.Clear();
Start:
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Input:
int multi = Prompt("Введите число (не равное 0) >- ");
if (multi == 0) // проверка на введение 0
{
    Console.WriteLine($"Введено число 0. ");
    goto Input;
}

int a = 1; // при подстановке 0 программа не работает: 0 нет смысла делить

while ((a % multi) != 0)
{
    a = new Random().Next(1,1000); // установил ограничение в диапазоне чисел
    Console.WriteLine(a);   // для наглядности то, сколько чисел генерируется прежде чем программа выдаст ответ
}

Console.WriteLine($"Сгенерированное число {a} кратно, введенному числу {multi} (частное равно {a / multi})");
Console.WriteLine();
goto Start;

