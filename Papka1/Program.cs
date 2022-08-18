/*Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, которая покажет 
 количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using System;
using static System.Console;

Clear();

Write("Enter the size of array: ");
int size = int.Parse(ReadLine()!);

Write("Enter the min value of array: ");
int minV = int.Parse(ReadLine()!);

Write("Enter the max value of array: ");
int maxV = int.Parse(ReadLine()!);

int[] array = GetRandomArray(size, minV, maxV);
Write($"[{string.Join(", ", array)}]");
WriteLine();

WriteLine($"Количество четных чисел -> {CountNumbers(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int CountNumbers(int[] array)
{
    int num = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            num++;
        }
    }
    return num;
}