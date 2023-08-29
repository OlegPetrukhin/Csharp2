/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] GetRandomArray(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);

    }
    return array;
}
void PrintArray(int[] ArrayToPrint)
{
    System.Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        System.Console.Write(ArrayToPrint[i]);
        if (i < ArrayToPrint.Length - 1)
        {
            System.Console.Write(", ");
        }

    }
    System.Console.Write("] -> ");

}
int SumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2!=0)
        {
            sum+=array[i];

        }
        


    }
    return sum;
}
System.Console.Write("Введи числа: ");
int size = Convert.ToInt32(Console.ReadLine());
int start = Convert.ToInt32(Console.ReadLine());
int finish = Convert.ToInt32(Console.ReadLine());
int[] array1 = GetRandomArray(size,start,finish);
PrintArray(array1);
System.Console.WriteLine(SumOdd(array1));

