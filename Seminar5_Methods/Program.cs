// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.


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

int GetNegativeSum(int[] array)
{
    int sum = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i] < 0)
            sum+=array[i];
    return sum;
}


Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int negativeSum = GetNegativeSum(myArray);
Console.WriteLine("Sum of negative elements is " + negativeSum);
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int min, int max)
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
bool FindNumber(int [] array, int num)
{
    for(int i=0; i<array.Length; i++)
        if(array[i]==num) return true;
    return false;
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.Write("Input a number to find: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
bool findNum = FindNumber(myArray, findNumber);
Console.WriteLine(findNum);
*/

// Задача 2.Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] CreateRandomArray(int size, int min, int max)
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
int ElementsCount(int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
        if(array[i]> min && array[i]<max) count++;
    return count;
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

Console.Write("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

int numSum = ElementsSum(myArray, A, B);
Console.WriteLine(numSum);
*/

//Задача 3. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] CreateRandomArray(int size, int min, int max)
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
void ArrayChange(int[] array)
{
    for(int i=0; i<array.Length; i++)
        array[i] *= (-1);
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

ArrayChange(myArray);
*/
