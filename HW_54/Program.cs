// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int ReadInt()
{
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

void SortRow(int[,] array, int row)
{
    for (int i = 0; i < array.GetLength(0); i++)
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
        SortRow(array, i);
}

int[,] array = GetTwoDimensionArray(5, 5);

PrintArray(array);
SortEveryRow(array);
PrintArray(array);

