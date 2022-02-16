// 36. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

int[] array = new int[12];
int countEven = 0;
int countNotEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) countEven = countEven + 1;
    else countNotEven = countNotEven + 1;
}
Console.Write("Четные числа из массива: " + countEven);
Console.WriteLine();
Console.Write("Нечетные числа из массива: " + countNotEven);
