// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Convert.ToDouble(new Random().Next(-10000, 10000))/100; 
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
*/



// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.Write("Введите индекс элемента по горизонтали: ");
int gor = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс элемента по вертикали: ");
int ver = Convert.ToInt32(Console.ReadLine());

if (ver < matrix.GetLength(1) && gor < matrix.GetLength(0)) 
Console.Write($"Это элемент {matrix[gor, ver]} ");
else Console.Write("Такого числа в массиве нет ");
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}



for (int j = 0; j < matrix.GetLength(1); j++)
{
    double Average = 0;
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Average += matrix[i, j];
        count++;
    }

    Console.WriteLine($"Столбец {j}  - {Math.Round(Average / count, 2)}");
}

