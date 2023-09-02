/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int[] Arr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Convert.ToInt32(Console.ReadLine());   
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i<array.Length-1)
        {
            System.Console.Write(", ");
        }
        
    }
    System.Console.Write("] -> ");
}
int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
        
    }
    return count;
}
System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = Arr(size);
PrintArray(array1);
System.Console.WriteLine(CountPositiveNum(array1));