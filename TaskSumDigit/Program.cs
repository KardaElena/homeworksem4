/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/


int DigitSum(int num)
{
int sum = 0;

if (num > 0)

{   
    while(num > 0)
    {
        sum = num%10 + sum;
        num = num/10;
        Console.WriteLine(num);
        Console.WriteLine(sum);
    }
}

else if (num < 0)
{
    while(num < 0)
    {
        sum = num%10 + sum;
        num = num/10;
    }
sum = sum-(sum*2);
}

else sum = 0;

return sum;
}

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр в числе {number} равна {DigitSum(number)}");


