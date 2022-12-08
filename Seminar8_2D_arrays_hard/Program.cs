// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)

void Show2dArray(int[,] array)

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) &&
       row2 >= 0 && row2 < array.GetLength(0) &&
       row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    Console.WriteLine("Impissible to change!");
}

Console.Write("Input a number of the first row to change: ");
int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input a number of the second row to change: ");
int r2 = Convert.ToInt32(Console.ReadLine()) - 1; //строки исчисляются с 0, а пользователь считает с 1. Для удобства пользователя.
*/

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) //int[,,] трёхмерный массив.
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void RowsToColumns(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
        for(int i=0 ; i<array.GetLength(0); i++)
            for(int j = i; j<array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
    else Console.WriteLine("Impossible to change!");
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
RowsToColumns(myArray);
Show2dArray(myArray);
*/


//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
int[,] myArray = new int[5, 5];
for (int i = 0; i < 5; i++)
    for (int j = 0; j < 5; j++)
        myArray[i, j] = new Random().Next(0, 9);

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Show2dArray(myArray);

int[] GetMinIndexes(int[,] array)
{
    int[] minIndexes = { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[minIndexes[0], minIndexes[1]])
            {
                minIndexes[0] = i;
                minIndexes[1] = j;
            }
    return minIndexes;
}


int[,] New2dArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int[] minIndexes = GetMinIndexes(array);
    for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
        if (i != minIndexes[0])
        {
            for (int j = 0, l = 0; j < array.GetLength(1); j++, l++)
                if (j != minIndexes[1])
                {
                    newArray[k, l] = array[i, j];
                }
                else l--;
        }
        else k--;

    return newArray;
}

int[,] ResultArray = New2dArray(myArray);
Show2dArray(ResultArray);
*/
