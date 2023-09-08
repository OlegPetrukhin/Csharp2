/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
        if (arrayToPrint.GetLength(0)-i!=1)
        {
            System.Console.WriteLine();
        }
        
    }
}
int[,] Decreas2DArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
             for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1)-1; j++)
                {
                    int temp = 0;
                    if (array[i,j+1]>array[i,j])
                    {
                        temp = array[i,j];
                        array[i,j] = array[i,j+1];
                        array[i,j+1] = temp;

                    }

            
                }
        
            }
        
            
        }
       
    }
    
    return array;
}
System.Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] userarray = GetRandom2DArray(rows,cols,10);
Print2DArray(userarray);
System.Console.WriteLine();
System.Console.WriteLine();
Print2DArray(Decreas2DArray(userarray));
