/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int Degree (int a, int b)
{
    int result = a;
    while (b > 1)
    {
        result = a*result;
        b--;
    }
return result;
}

Console.Clear();
Console.Write("Введите ваше число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите степень, в которую хотите возвести число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Число {a} в степени {b} равно {Degree(a, b)}");


