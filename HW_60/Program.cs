// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,] GetTwoDimensionArray(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    Random random = new Random();

    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = random.Next(100);
        }
    }


    return array;
}

int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument}:");
    return int.Parse(Console.ReadLine());
}

bool HasValue(int[,] array, int x, int y)
{
    if (x > 0 && y > 0 && x < array.GetLength(0) && y < array.GetLength(1))
    {
        return true;
    }

    return false;
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

void PrintThirdDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{i}-{j}-{k}: {array[i, j, k]} ");
            }
        }
    }
    Console.WriteLine();
}

void SortRow(int[,] array, int row)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[row, i] > array[row, j])
            {
                int temp = array[row, i];
                array[row, i] = array[row, j];
                array[row, j] = temp;
            }
        }
    }
}

void SortEveryRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array, i);
    }
}

int[,,] GetThreeDimensionUniqueArray(int length1, int length2, int length3)
{
    int[,,] array = new int[length1, length2, length3];
    Random rnd = new Random();

    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                int value = rnd.Next(10000);
                if (!HasValueInThreeDimensionmArray(array, value))
                    array[i, j, k] = value;
                else
                {
                    k--;
                }
            }
        }
    }

    return array;
}

bool HasValueInThreeDimensionmArray(int[,,] array, int value)
{
    foreach (int item in array)
    {
        if (item == value)
        {
            return true;
        }
    }

    return false;
}

int[,,] array = GetThreeDimensionUniqueArray(ReadInt("Length1"), ReadInt("Length 2"), ReadInt("Length3"));
PrintThirdDimensionArray(array);