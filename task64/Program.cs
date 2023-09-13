/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void NaturalNum(int N)
{
    if (N>=1)
    {
        System.Console.Write(N);
        if (N>1)
        {
            System.Console.Write(", ");
        }
        NaturalNum(N-1);
    }
}
NaturalNum(5);
