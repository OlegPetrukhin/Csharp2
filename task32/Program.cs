﻿/*
32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
int[] GetRandomArray(int arrayLength1, int start, int end)

{
    int[] array = new int[arrayLength1];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}
void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i=0; i<arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
       if (i<arrayToPrint.Length - 1)
       {
        Console.Write (", ");
       }
    }
    Console.WriteLine("]");
}
int[] Replacement(int[] array)
{
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]>0)
        {
            array[i]*=-1;
        }
        else 
        {
            array[i]*=-1;
        }
    }
    return array;
}
System.Console.WriteLine("Введи число: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] userarray =GetRandomArray(arrayL,min,max);
PrintArray(userarray);
PrintArray(Replacement(userarray));