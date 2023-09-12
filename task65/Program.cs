/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.
*/
void NaturalNum(int m, int n)
{
    if (m<=n)
    {
        System.Console.Write(m+", ");
        NaturalNum(m+1, n);

    }
}

NaturalNum(1,10);