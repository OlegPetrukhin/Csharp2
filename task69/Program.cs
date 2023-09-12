/*
69. Напишите программу, которая на вход принимает 
два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/
int exponnum=ExponNumber(2,3);
int ExponNumber(int a, int b)
{
    if (b==1)
    {
        return a;
    }
    else
    {
        return a*ExponNumber(a,b-1);
    }
}
System.Console.WriteLine(exponnum);