/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
double[] GetRandomArray(int size, double start, double end)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(end-start)+start,2);

    }
    return array;
}
void PrintArray(double[] ArrayToPrint)
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
double Difference(double[] array)
{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min>array[i])
        {
            min = array[i];
        }  
    }
    for (int i = 1; i < array.Length; i++)
    {
        if (max<array[i])
        {
            max = array[i];
        }  
    }
    dif = max - min;
    return dif;


}
System.Console.Write("Введи числа: ");
int size = Convert.ToInt32(Console.ReadLine());
double start = Convert.ToDouble(Console.ReadLine());
double  finish = Convert.ToDouble(Console.ReadLine());
double[] array1 = GetRandomArray(size,start,finish);
PrintArray(array1);
System.Console.WriteLine(Difference(array1));