// See https://aka.ms/new-console-template for more information

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк  ");
int lineVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnVol = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[lineVol, columnVol];
FillArrayRandomNum(num);
PrintArray(num);

void FillArrayRandomNum(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
