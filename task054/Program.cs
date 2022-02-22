// 54. В матрице чисел найти сумму элементов главной диагонали

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
// int Sum(int[,] array)
// {
//     int sum = 0;
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             if (m == n) sum += array[m, n];
//         }
//     }
//     return sum;
// }

int Sum(int[,] array)
{
    int sum = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        sum+=array[m, m];
    }
    return sum;
}

int m = 5;
int n = 5;

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма элементов главной диагонали равна: " + Sum(array));