/*
42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
System.Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string BinaryNumber(int num)
{
    string result = string.Empty;
    int temp=0;
    for (int i = number; i>0; i/=2)
    {
        temp = i%2;
        result = temp + result;
        
    }
    return result;
}
string result = BinaryNumber(number) ;
System.Console.WriteLine(result);