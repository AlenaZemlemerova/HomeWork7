void Exercice47()
{
    // Задача 47. Задайте двумерный массив размером m×n, 
    // заполненный случайными вещественными числами.

    Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m,n];
    FillArrayDouble(array);
    PrintArrayDouble(array);    
}

void Exercice50()
{
    //Задача 50. Напишите программу, которая на вход 
    //принимает позиции элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, 
    //что такого элемента нет.

    int[,] array = new int[3,4];
    FillArray(array, 0, 10);
    PrintArray(array);

    Console.WriteLine("Введите номер строки");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int column = Convert.ToInt32(Console.ReadLine());
    row--;
    column--;
    if(row >= 0 && row <= 3 && column >= 0 && column <= 4)
    {
        Console.WriteLine(array[row, column]);
    }
    else Console.WriteLine("Вы вышли за пределы массива");
}

void Exercice52()
{
    //Задача 52. Задайте двумерный массив из 
    //целых чисел. Найдите среднее арифметическое 
    //элементов в каждом столбце.

    Console.WriteLine("Введите количество строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] nums = new int[rows,columns];
    FillArray(nums);
    PrintArray(nums);
    Console.WriteLine("Среднее арифмитическое:");
    double[] arithmeticMean = new double[columns];
    for(int j = 0; j < columns; j++)
    {
        double value = 0;
        for(int i = 0; i < rows; i++)
        {
             value += nums[i,j];
        }
        arithmeticMean[j] = Math.Round(value/rows, 1);
    }
    PrintOneArray(arithmeticMean);

}

void FillArrayDouble(double[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round((((random.NextDouble() * 10) - 5) * 2), 2);
        }
    }
}

void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void PrintOneArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    } 
}

void PrintArrayDouble(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Exercice47();
Exercice50();
Exercice52();