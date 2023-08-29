/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
Console.Clear();
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
void GetSum(int[] array)
{
    int sumpos = 0;
    int sumneg = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            sumpos+=array[i];
        }
        else
        {
            sumneg+=array[i];
        }
        
    }
    System.Console.WriteLine($"Сумма положительных чисел: {sumpos}"); 
    System.Console.WriteLine($"Сумма отрицательных чисел: {sumneg}"); 
}
System.Console.WriteLine("Введи число: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] userarray =GetRandomArray(arrayL,min,max);
PrintArray(userarray);
GetSum(userarray);