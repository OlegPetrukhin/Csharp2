﻿/*
49. Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.
*/
Console.Clear();
int[,] GetRandom2DArray(int rows, int cols, int deviation )
{
    int[,] result = new int[rows,cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i,j] = new Random().Next(-deviation,deviation);
            
        }
        
    }
    return result;
}
void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
        
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i,j]+"\t");
            
        }
        System.Console.WriteLine();
    }
    
}
int[,] DoubleEven2DArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] result = new int[rows,cols];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (i%2==0 && j%2==0)
            {
                result[i,j] = array[i,j]*array[i,j];
            }
            
        }
        
    }
    return result;
}
int[,] randomArray = GetRandom2DArray(5,6,10);
Print2DArray(randomArray);
System.Console.WriteLine();
Print2DArray(DoubleEven2DArray(randomArray));