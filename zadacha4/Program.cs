// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)



void FillMat(int[,,] mat)
{
    int count = 10;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for (int k = 0; k < mat.GetLength(2); k++)
            {
                mat[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < mat.GetLength(2); k++)
            {
                Console.Write($"{mat[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}



int[,,] matrix3D = new int[2, 2, 2];
FillMat(matrix3D);
PrintIndex(matrix3D);
Console.WriteLine();