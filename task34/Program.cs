/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
int[] GetRandomArray(int size,int min, int max)
{
    int[] array1 = new int[size];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i]=new Random().Next(min,max);
        
    }
    return array1;
}
void PrintArray(int[] ArrayToPrint)
{
    System.Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        System.Console.Write(ArrayToPrint[i]);
        if (i<ArrayToPrint.Length-1)
        {
            System.Console.Write(", ");
        }
        
        
    }
    System.Console.Write("] -> ");
}
int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>99 && array[i]<1000 && array[i]%2==0)
        {
            count++;
        }    
    }
    return count;
}
System.Console.Write("Введи числа для массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int start = Convert.ToInt32(Console.ReadLine());
int finish = Convert.ToInt32(Console.ReadLine());
int[] array1 = GetRandomArray(size,start,finish);
PrintArray(array1);
System.Console.WriteLine(EvenCount(array1));