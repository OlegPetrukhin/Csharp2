/*
45. Напишите программу, которая будет создавать копию заданного одномерного 
массива с помощью поэлементного копирования.
*/
int[] GerRandomArray(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next(start,end);
    }
    return array;
}
void PrintArray(int[] arraytoprint)
{
    System.Console.Write("[");
    for (int i = 0;i<arraytoprint.Length;i++)
    {
        System.Console.Write(arraytoprint[i]);
        if (i<arraytoprint.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("] -> ");
}
int[] CopyRandomArray(int[] array)
{
    int[] array1 = new int[array.Length];
    for (int i=0;i<array.Length;i++)
    {
        array1[i]=array[i];
    }
    return array1;
}
System.Console.WriteLine("Введи числа");
int size = Convert.ToInt32(Console.ReadLine());
int start = Convert.ToInt32(Console.ReadLine());
int finish = Convert.ToInt32(Console.ReadLine()); 
int[] array1 = GerRandomArray(size,start,finish);
PrintArray(array1);
PrintArray(CopyRandomArray(array1));