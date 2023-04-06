// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строк


void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void NumberMinSumElements(int[,] matrix)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Строка c наименьшей суммой элементов:{minSum + 1}");
}

void PrintArray(int[, ] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
     }
}


int[,] matrix = new int[4, 4];
FillMatrixRandom(matrix);
PrintArray(matrix);
Console.WriteLine();
NumberMinSumElements(matrix);