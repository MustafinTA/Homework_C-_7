// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк");
var m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);

double[,] FillArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().NextDouble() * 10;
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(arr[i, j], 3)} ");
        }
        System.Console.WriteLine();
    }
}
