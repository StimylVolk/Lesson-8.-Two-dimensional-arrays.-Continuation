// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// C = A · B =  
// c11 = a11 · b11 + a12 · b21 = 2 · 3 + 4 · 3 = 6 + 12 = 18
// c12 = a11 · b12 + a12 · b22 = 2 · 4 + 4 · 3 = 8 + 12 = 20
// c21 = a21 · b11 + a22 · b21 = 3 · 3 + 2 · 3 = 9 + 6 = 15
// c22 = a21 · b12 + a22 · b22 = 3 · 4 + 2 · 3 = 12 + 6 = 18

int m = InputNumbers("Enter the number of rows of the 1st matrix: ");
int n = InputNumbers("Enter the number of columns of the 1st matrix (and rows of the 2nd): ");
int p = InputNumbers("Enter the number of columns of the 2nd matrix: ");
int range = InputNumbers("Enter a range of random numbers: from 1 to ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\n1st matrix:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\n2nd matrix:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nThe product of the first and second matrices:");
PrintArray(resultMatrix);