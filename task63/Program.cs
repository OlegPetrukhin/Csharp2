/*
63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/
void NaturalNum(int N, int start=1)
{
    if (start<=N)
    {
        System.Console.Write(start+", ");
        NaturalNum(N,start+1);
    }
}
NaturalNum(5);