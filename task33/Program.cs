/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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
bool FindElemet(int[] array,int number)
{
    bool number1 = false;
    for (int i=0; i<array.Length;i++)
    {
        if (array[i]==number)
        {
            number1 = true; 
            break;
        }
        

    }
    return number1;
}
System.Console.WriteLine("Введи число: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число, которое хотите найти: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int[] userarray =GetRandomArray(arrayL,min,max);
bool number1 = FindElemet(userarray,usernumber);
PrintArray(userarray);
System.Console.WriteLine(number1);