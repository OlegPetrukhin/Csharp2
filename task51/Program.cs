/*
51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/
int[,] GetRandom2DArray(int rows,int cols,int deviation)
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
void Print2DArray(int[,] printToArray)
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
int SumDiagonal2DArray(int[,] array)
{
    int sum=0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (i==j)
            {
                sum+=array[i,j];
            }
            
        }
        
    }
    return sum;
}
int[,] userArray = GetRandom2DArray(5,5,10);
Print2DArray(userArray);
System.Console.WriteLine(SumDiagonal2DArray(userArray));