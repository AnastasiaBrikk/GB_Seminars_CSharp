// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int FindSum(int num)
{
    int sum = 0;
    for(int current = 1; current<=num; current++)
        sum+=current; //sum = sum + current
    return sum;
}

Console.WriteLine($"Sum from 1 to {number} is {FindSum(number)}");
*/

// 1 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. (должно работать и с отрицательными)

/*int DigitSum(int number)
{
    int sum = 1;
    if(number<0) number=number*-1;
    while(number>=10)
    {
        number = number/10;
        sum++;
    }
    return sum;
}


Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of digits number {num} is {DigitSum(num)}");
*/


// 2 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*int Factorial(int number)
{
    int product = 1;
    for(int current = 1; current <=number; current++)
    {
        product *= current;
    }
    return product;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
*/

/*int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
*/