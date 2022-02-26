// 56. Написать программу, которая обменивает элементы первой строки и последней строки

int[,] array = new int[5, 6];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 20);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     Console.Write(array[0, i] + " ");
// }
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     Console.Write(array[array.GetLength(0) - 1, i] + " ");
// }
Console.WriteLine();
int m = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    m = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = array[0, i];
    array[0, i] = m;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}