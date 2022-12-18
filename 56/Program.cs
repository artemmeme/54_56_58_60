//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int min = 0;
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4}\t");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];
FillArray(array);
Console.WriteLine("Получился массив:");
PrintArray(array);
SumLine(array, 0);

int sumLine = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLine(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        min = i;
    }
}
Console.WriteLine($"{min + 1} - строкa с наименьшей суммой. Сумма в данной строчке = {sumLine} ");

int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

