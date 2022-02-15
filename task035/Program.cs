// 35. Определить, присутствует ли в заданном массиве, некоторое число

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());

for (int j = 0; j < array.Length; j++)
{
    if (array[j] == number) count = 1;
}
if (count > 0) Console.WriteLine("Это число присутствует в массиве");
else Console.WriteLine("Искомое число в массиве отсутствует");

