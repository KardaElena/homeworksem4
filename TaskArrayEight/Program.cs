/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(в примере показаны два разных массива, создаем именно для 8 элементов)

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

void FillArrayEight (int[] array)
{
    int i = 0;
    for (i = 0; i < 7; i++);
    array[i] = new Random().Next(1, 10);
}

void PrintArray (int[] array)
{
    foreach(var element in array)
    Console.Write($"{element} ");
}

Console.Clear();
int [] array = new int[8];
FillArrayEight(array);
PrintArray(array);
