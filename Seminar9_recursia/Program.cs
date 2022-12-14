// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int m, int n)
{
    if (m > n)
    {
        ShowNums(m, n + 1);
        Console.Write($"{n} ");
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        ShowNums(m + 1, n);
    }
    else Console.WriteLine($"{m}");
}   

ShowNums(10, 11);
*/

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double MathPow(double a, double b)
{
    if(b > 0)
        return MathPow(a, b - 1) * a;
    else if( b < 0)
        return MathPow(a, b + 1) / a;
    else return 1;
}

Console.WriteLine(MathPow(3, -3));
*/