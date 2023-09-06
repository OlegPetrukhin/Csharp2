/*
 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
 что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
void FindElementInGetRandom2DArray(int[,] array, string number)
{
    string str;
    int count = 0;
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str = i.ToString()+j.ToString();
            if (number == str)
            {
                System.Console.WriteLine("Эта позиция существует в данном масиве");
                count++;
                break;
            }
            if (count==0 && array.GetLength(0)-i==1 && array.GetLength(1)-j==1 )
            {
                System.Console.WriteLine("Эта позиция не существует в данном масиве");
                break;
                
            }
            
            
            
        }
        
    }
    

}
System.Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите позицию числа в данном массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = number.ToString();
int[,] array = GetRandom2DArray(rows,cols,10);
Print2DArray(array);
System.Console.WriteLine();
System.Console.Write($"{num} -> ");
FindElementInGetRandom2DArray(array, num);

