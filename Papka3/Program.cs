/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

using System;
using static System.Console;

Clear();

WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(ReadLine());

double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine();

PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
    {
        max = numbers[z];
    }
    if (numbers[z] < min)
    {
        min = numbers[z];
    }
}

WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Write(numbers[i] + " ");
    }
    Write("]");
    WriteLine();
}