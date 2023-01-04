// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument}:");
    return int.Parse(Console.ReadLine());
}

int[,] GetTwoDimensionArray(int length, int length2)
{
    int[,] array = new int[length, length2];

    Random r = new Random();

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = r.Next(10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

void CalculateRows(int[,] array)
{
    PrintArray(array);
    int minRow = 0;
    int min = SumRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = SumRow(array, i);
        if (sum < min)
        {
            min = sum;
            minRow = i;
        }
        if (i == array.GetLength(0) - 1 && i == array.GetLength(1) - 1) Console.WriteLine($"Min sum of elements on a {minRow + 1} row = {min}");
    }
}
int SumRow(int[,] array, int i)
{
    int temp = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        temp = temp + array[i, j];
    }
    return temp;
}

int[,] array = GetTwoDimensionArray(ReadInt("length"), ReadInt("length2"));
PrintArray(array);
CalculateRows(array);
