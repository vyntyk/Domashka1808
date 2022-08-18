/*Задача 36: Задайте одномерный массив, заполненный
 случайными числами. Найдите сумму элементов, 
 стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using System;
using static System.Console;

Clear();

Write("Введите элементы массива через запятую: ");
int[] array = getArray(ReadLine());
Write($"[{String.Join(", ", array)}]");
WriteLine($"Сумма элементов -> {sumOfElements(array, array.Length)}");

int[] getArray(string arrStr) {

    string[] arr = arrStr.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arr.Length];
    for(int i=0; i < arr.Length; i++) 
    {
        result[i] = int.Parse(arr[i]); 
    }
    return result;
}

int sumOfElements(int[] array, int arraySize)
{
    int sum = 0;

    for(int i=0; i < arraySize; i++)
    {
        if (i % 2 != 0) {
            sum = array[i] + sum;
        }
    }
    return sum;
}