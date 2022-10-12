/* Напишите программу на вход которой приходит два числа и 
она находит растояние между ними в 2d пространстве*/
Console.Clear();

const int X = 0;
const int Y = 1;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[2];
    answer[X] = Prompt($"введите х {point} -> ");
    answer[Y] = Prompt($"введите y {point} -> ");
    return answer;
}

int Power2(int arg)
{
    return arg * arg; // Math.Pow(arg, 2) - возведение в степень
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double lenght = Math.Sqrt(Power2(p1[X] - p2[X]) + Power2(p1[Y] - p2[Y])); //Math.Sqrt - квадратный корень

System.Console.WriteLine($"{lenght:f2}");