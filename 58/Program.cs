// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void FillArray_1(int[,] array_1)
{
    for (int i = 0; i < array_1.GetLength(0); i++)
        for (int j = 0; j < array_1.GetLength(1); j++)
            array_1[i, j] = Convert.ToInt32(new Random().Next(1, 7));
}

void PrintArray_1(int[,] array_1)
{
    for (int i = 0; i < array_1.GetLength(0); i++)
    {
        for (int j = 0; j < array_1.GetLength(1); j++)
            Console.Write($"{array_1[i, j],4}\t");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность квадратных матриц");
int rows_1 = Convert.ToInt32(Console.ReadLine());
int cols_1 = rows_1;

int[,] array_1 = new int[rows_1, cols_1];
FillArray_1(array_1);
Console.WriteLine("Первая матрица:");
PrintArray_1(array_1);
//______________________________________________________________________________________________________________

void FillArray_2(int[,] array_2)
{
    for (int i = 0; i < array_2.GetLength(0); i++)
        for (int j = 0; j < array_2.GetLength(1); j++)
            array_2[i, j] = Convert.ToInt32(new Random().Next(1, 7));
}

void PrintArray_2(int[,] array_2)
{
    for (int i = 0; i < array_2.GetLength(0); i++)
    {
        for (int j = 0; j < array_2.GetLength(1); j++)
            Console.Write($"{array_2[i, j],4}\t");
        Console.WriteLine();
    }
}
int rows_2 = rows_1;
int cols_2 = rows_2;

int[,] array_2 = new int[rows_2, cols_2];
FillArray_2(array_2);
Console.WriteLine("Вторая матрица:");
PrintArray_2(array_2);

//________________________________________________________________________________________


void PrintArray_3(int[,] array_3)
{
    for (int i = 0; i < array_3.GetLength(0); i++)
    {
        for (int j = 0; j < array_3.GetLength(1); j++)
            Console.Write($"{array_3[i, j],4}\t");
        Console.WriteLine();
    }
}
int rows_3 = rows_1;
int cols_3 = rows_3;

int[,] array_3 = new int[rows_3, cols_3];
FillMatrix(array_1, array_2, array_3);
Console.WriteLine("Их произведение:");
PrintArray_3(array_3);

void FillMatrix(int[,] array_1, int[,] array_2, int[,] array_3)
{
    for (int i = 0; i < array_3.GetLength(0); i++)
    {
        for (int j = 0; j < array_3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array_1.GetLength(1); k++)
            {
                sum = sum + array_1[i, k] * array_2[k, j];
            }
            array_3[i, j] = sum;
        }
    }
}