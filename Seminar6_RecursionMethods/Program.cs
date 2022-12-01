//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void ReverseArray(int[] array)
{
    for(int i=0; i<array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 -i] = temp;
    }
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
ReverseArray(myArray); //все изменения произойдут не с копией, а с оригиналом myArray. Т е он изменится. 
//проверим:
ShowArray(myArray);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/*Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] Fib(int n, int a, int b)
{
    int[] array = new int[n];
    for(int i=2; i<n; i++)
    {
        array[0]= a;
        array[1] = b;
        array[i] = array[i-1] + array[i-2];
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

int[] myArray = Fib(n,a,b);
ShowArray(myArray);
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[n];
    for(int i=0; i<array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int[] myCopy = CopyArray(myArray);

ShowArray(myCopy);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input C: ");
int c = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a< b+c && b< a+c && c<a+b;
}

Console.WriteLine(Triangle(a, b, c));
*/
