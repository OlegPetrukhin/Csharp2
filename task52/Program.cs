/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void AverageGetRandom2DArray(int[,] array)
{
    System.Console.Write("\t");
    double average = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum+=array[i,j];

           
            
        }
        average=sum/array.GetLength(1);
        System.Console.Write($"{average}\t");
            
    }

}
System.Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = GetRandom2DArray(rows,cols,10);
Print2DArray(array);
System.Console.WriteLine();
AverageGetRandom2DArray(array);
