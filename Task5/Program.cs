/* Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел из 10 элементов
 в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.*/
Console.Clear();

int big5 = 0;

for (int i = 0; i < 10; i++)
{
    int a = new Random().Next(1, 11);
    if (a > 5)
        big5++;
        Console.Write($"{a} ");
}
Console.WriteLine($"Чисел больше 5 сгенерировано {big5}");
Console.WriteLine();
