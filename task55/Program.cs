/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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
int[,] UserArray(int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;

            
        }
        
    }
    return array;
}  
System.Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = GetRandom2DArray(rows,cols,10);
Print2DArray(array);
System.Console.WriteLine();
Print2DArray(UserArray(array));
