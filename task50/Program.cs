// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

System.Console.WriteLine("Введите номер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine()) - 1;
System.Console.WriteLine("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine()) - 1;
int[,] matrix = new int[3, 3];

FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();

if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1))
{
    Console.WriteLine($" {matrix[rows, colums]}");
}
else Console.WriteLine("такого числа в массиве нет");

int[,] FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}