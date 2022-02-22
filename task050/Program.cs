// 50. В двумерном массиве n×k заменить четные элементы на противоположные

void FillArray(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[n, k] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[n, k]} ");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[n, k] % 2 == 0) array[n, k] = -array[n, k];
        }
    }
}
int n = 5;
int k = 4;

int[,] array = new int[n, k];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);