/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
Console.Clear();
int[,] GetRandom2DArray2(int rows, int cols, int deviation )
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
void UmnArray(int[,] array, int[,] array2)
{
    int[,] result = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i,j] = array[i,j]*array2[i,j];


            
        }
        
    }
    Print2DArray(result);

}
System.Console.Write("Введите количество сток: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] userarray = GetRandom2DArray(rows,cols,10);
int[,] userarray2 = GetRandom2DArray2(rows,cols,10);
Print2DArray(userarray);
System.Console.WriteLine();
System.Console.WriteLine();
Print2DArray(userarray2);
System.Console.WriteLine();
System.Console.WriteLine();
UmnArray(userarray,userarray2);