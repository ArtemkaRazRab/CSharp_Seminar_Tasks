// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции.

int[] array = new int[30];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1) count = count + array[j];

}
Console.WriteLine();
Console.Write("Сумма чисел стоящих на нечетной позиции в массиве равна - ");
Console.Write(count);
