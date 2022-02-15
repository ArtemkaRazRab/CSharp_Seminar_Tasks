// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
int count=0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    if(array[j] > 9 & array[j] < 100) count = count + 1;
}
Console.WriteLine();
Console.Write("Массив совержит следующее количество элементов из отрезка [10,99] - ");
Console.Write(count);
