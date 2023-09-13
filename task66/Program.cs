/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int result = SumNumber(4,8);
int SumNumber(int m, int n)
{
    int sum = 0;
    if (m>n)
    {
        return sum;
    }
    else
    return sum+=m+SumNumber(m+1,n);
}
System.Console.WriteLine(result);
