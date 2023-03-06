// Задача 47.
// Задайте двумерный массив размером m x n, 
// заполненный случайными вещественными числами

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

double [,] GetMatrix (int rows, int cols, double minValue, double maxValue)
{
    double [,] matrix = new double [rows,cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i,j] = new Random().NextDouble () + new Random().Next(-10, 10);
        }
    }
    return matrix; 
}

void PrintMatrix(double[,] matr) 
{
    for (int i = 0; i < rows; i++) 
    {
        for (int m = 0; m < cols; m++)
        {
            Console.Write(matr[i,m] + "\t");
        }
        Console.WriteLine(); 
    }
}

double [,] resultMatrix = GetMatrix(rows, cols, 0, 1); 

PrintMatrix(resultMatrix);
*/

// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве и возвращает значение этого элемента
// или указание что такого элемента нет

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите нижний порог диапазона: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхний порог диапазона: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = GetMatrix(rows, cols, minValue, maxValue);

PrintMatrix(resultMatrix);

Console.Write("Введите номер строки: ");
int countRows = Convert.ToInt32(Console.ReadLine()) - 1; // т.к. первая строка имеет индекс 0 вычитаем 1

Console.Write("Введите номер столбца: ");
int countCols = Convert.ToInt32(Console.ReadLine()) - 1; // то же самое

if (countRows + 1 <= rows && countCols + 1 <= cols)
{
    int count = resultMatrix[countRows, countCols];
    Console.WriteLine($"Искомое число: {count}");
}
else
{
    Console.Write("Такого числа нет в массиве ");
}
*/

// Задача 52.
// Задайте двумерный массив из целых чисел, 
// найдите среднее арифметическое в каждом столбце.

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите нижний порог диапазона: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхний порог диапазона: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = GetMatrix(rows, cols, minValue, maxValue);

PrintMatrix(resultMatrix);


for (int i = 0; i < cols; i++)
{
    double count = 0;
    for (int m = 0; m < rows; m++)
    {
        
        double count1 = resultMatrix[m, i];
        count = count + count1;
    }
    Console.WriteLine($"Среднее арифметическое столбца {i+1} = {count / rows}");
}
*/






