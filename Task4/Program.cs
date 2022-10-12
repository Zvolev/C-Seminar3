/* Напишитепрограмму, которая на вход принимает число N 
и выдает на выход таблицу квадратов от 1 до N*/

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt(" введите число N >- ");

for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine(Math.Pow(i, 2));  // System.Console.WriteLine(i*i);
}