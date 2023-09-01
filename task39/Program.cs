/*
39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами:
1) менять числа местами в исходном массиве;
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
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
int[] Mirrow(int[] array)
{
    int temp = 0;
    for (int i = 0;i<array.Length/2;i++)
    {
        temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
    return array;
}
System.Console.WriteLine("Введи числа");
int size = Convert.ToInt32(Console.ReadLine());
int start = Convert.ToInt32(Console.ReadLine());
int finish = Convert.ToInt32(Console.ReadLine()); 
int[] array1 = GerRandomArray(size,start,finish);
PrintArray(array1);
PrintArray(Mirrow(array1));