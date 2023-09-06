/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] GetRandom2DArray(int rows,int cols,int deviation)
{
    double[,] result = new double[rows,cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i,j] =Math.Round( new Random().NextDouble()*(deviation+deviation)-deviation,1);
            
        }
        
    }
    return result;
}
void Print2DArray(double[,] printToArray)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < printToArray.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
        
    }
    System.Console.WriteLine();
    for (int i = 0; i < printToArray.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");
        for (int j = 0; j < printToArray.GetLength(1); j++)
        {
            System.Console.Write(printToArray[i,j]+"\t");
            
        }
        System.Console.WriteLine();
        
    }
}
System.Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = GetRandom2DArray(rows,cols,10);
Print2DArray(array);