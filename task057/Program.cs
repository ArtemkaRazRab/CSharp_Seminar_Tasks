// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива

void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}

void Ordering(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            for (int k = 0; k < matr.GetLength(1) - n - 1; k++)
            {
                if (matr[m, k] < matr[m, k + 1])
                {
                    int t = matr[m, k];
                    matr[m, k] = matr[m, k + 1];
                    matr[m, k + 1] = t;
                }
            }
        }
    }
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Ordering(matrix);
PrintArray(matrix);
